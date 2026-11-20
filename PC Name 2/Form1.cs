using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Management;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace PC_Name_2
{
    public partial class Form1 : Form
    {
        [DllImport("Kernel32.dll")]
        static extern long GetTickCount64();

        // Everything gathered in one go, so it can be collected off the UI thread
        private class PcInfo
        {
            public string PcName = "";
            public string UserName = "";
            public string Model = "";
            public string Serial = "";
            public string Wifi = "";
            public string Signal = "";
            public string LastBoot = "";
            public string DiskSpace = "";
            public List<string> IPs = new List<string>();
        }

        private bool _busy = false;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //Stores App Version number on Load
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            this.lblVersion.Text = String.Format(this.lblVersion.Text, version.Major, version.Minor, version.Build, version.Revision);

            await RefreshAsync();
        }

        private async void bCopy_Click(object sender, EventArgs e)
        {
            PcInfo info = await RefreshAsync();
            if (info != null)
            {
                Clipboard.SetText(BuildCopyText(info));
            }
        }

        private async void b_refresh_Click_1(object sender, EventArgs e)
        {
            await RefreshAsync();
        }

        // Gathers the info on a background thread, then updates the UI.
        // Returns null if a refresh is already running.
        private async Task<PcInfo> RefreshAsync()
        {
            if (_busy) return null;
            _busy = true;
            bCopy.Enabled = false;
            b_refresh.Enabled = false;
            try
            {
                PcInfo info = await Task.Run(() => GatherInfo());
                ApplyInfo(info);
                return info;
            }
            finally
            {
                bCopy.Enabled = true;
                b_refresh.Enabled = true;
                _busy = false;
            }
        }

        // Collects all the information. Does not touch the UI.
        private PcInfo GatherInfo()
        {
            PcInfo info = new PcInfo();

            //Get PC Name and Username
            info.PcName = Environment.MachineName;
            info.UserName = Environment.UserName;

            //Get Device Model and Serial
            GetModelAndSerial(info);

            // System Uptime
            DateTime osStartTime = DateTime.Now - new TimeSpan(10000 * GetTickCount64());
            info.LastBoot = osStartTime.ToString();

            //Get IP Addresses
            info.IPs = GetIPv4Addresses();

            // Show SSID and Signal Strength
            GetWifi(info);

            //Disk Space (the drive Windows is installed on)
            try
            {
                const decimal BytesInGB = 1073741824;
                string systemDrive = Path.GetPathRoot(Environment.SystemDirectory);
                DriveInfo dInfo = new DriveInfo(systemDrive);
                decimal avl = dInfo.AvailableFreeSpace;
                decimal GB = avl / (BytesInGB);
                info.DiskSpace = GB.ToString("#.##");
            }
            catch { info.DiskSpace = ""; }

            return info;
        }

        private static string Prop(ManagementBaseObject mo, string name)
        {
            try
            {
                object value = mo[name];
                return value == null ? "" : value.ToString().Trim();
            }
            catch { return ""; }
        }

        private static void GetModelAndSerial(PcInfo info)
        {
            try
            {
                using (ManagementClass mc = new ManagementClass("Win32_ComputerSystemProduct"))
                using (ManagementObjectCollection moc = mc.GetInstances())
                {
                    foreach (ManagementObject mo in moc)
                    {
                        string serial = Prop(mo, "IdentifyingNumber");
                        string name = Prop(mo, "Name");
                        string vendor = Prop(mo, "Vendor");
                        string version = Prop(mo, "Version");

                        // Lenovo keeps the friendly model name in Version, Dell and HP use Name
                        bool isLenovo = vendor.IndexOf("LEN", StringComparison.OrdinalIgnoreCase) >= 0;
                        string model = isLenovo ? version : name;

                        // Fall back to the other field if the preferred one is empty
                        if (model.Length == 0) model = isLenovo ? name : version;

                        info.Model = model;
                        info.Serial = serial;
                        break;
                    }
                }
            }
            catch
            {
                info.Model = "";
                info.Serial = "";
            }
        }

        private static List<string> GetIPv4Addresses()
        {
            List<string> result = new List<string>();
            try
            {
                foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
                {
                    if (nic.OperationalStatus != OperationalStatus.Up) continue;
                    if (nic.NetworkInterfaceType == NetworkInterfaceType.Loopback) continue;
                    if (nic.NetworkInterfaceType == NetworkInterfaceType.Tunnel) continue;

                    // Skip virtual switches / virtual machine adapters (Hyper-V, WSL, VMware, VirtualBox)
                    string desc = (nic.Description ?? "") + " " + (nic.Name ?? "");
                    if (desc.IndexOf("vEthernet", StringComparison.OrdinalIgnoreCase) >= 0
                        || desc.IndexOf("Hyper-V", StringComparison.OrdinalIgnoreCase) >= 0
                        || desc.IndexOf("VMware", StringComparison.OrdinalIgnoreCase) >= 0
                        || desc.IndexOf("VirtualBox", StringComparison.OrdinalIgnoreCase) >= 0
                        || desc.IndexOf("WSL", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        continue;
                    }

                    foreach (UnicastIPAddressInformation ua in nic.GetIPProperties().UnicastAddresses)
                    {
                        if (ua.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            result.Add(ua.Address.ToString());
                        }
                    }
                }
            }
            catch { }

            // Fall back to the old DNS lookup if nothing was found
            if (result.Count == 0)
            {
                try
                {
                    foreach (IPAddress address in Dns.GetHostAddresses(Dns.GetHostName()))
                    {
                        if (address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            result.Add(address.ToString());
                        }
                    }
                }
                catch { }
            }

            return result;
        }

        private static void GetWifi(PcInfo info)
        {
            try
            {
                using (System.Diagnostics.Process p = new System.Diagnostics.Process())
                {
                    p.StartInfo.FileName = "netsh.exe";
                    p.StartInfo.Arguments = "wlan show interfaces";
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.Start();

                    string output = p.StandardOutput.ReadToEnd();
                    p.WaitForExit(5000);

                    // Each line looks like "    SSID                   : MyNetwork".
                    // Match whole labels so "BSSID" is not mistaken for "SSID".
                    foreach (string rawLine in output.Split('\n'))
                    {
                        string line = rawLine.Trim();
                        int colon = line.IndexOf(':');
                        if (colon <= 0) continue;

                        string label = line.Substring(0, colon).Trim();
                        string value = line.Substring(colon + 1).Trim();

                        if (info.Wifi.Length == 0 && label.Equals("SSID", StringComparison.OrdinalIgnoreCase))
                        {
                            info.Wifi = value;
                        }
                        else if (info.Signal.Length == 0 && label.Equals("Signal", StringComparison.OrdinalIgnoreCase))
                        {
                            info.Signal = value;
                        }
                    }
                }
            }
            catch
            {
                info.Wifi = "";
                info.Signal = "";
            }
        }

        // Puts the gathered info into the form
        private void ApplyInfo(PcInfo info)
        {
            tBPCName.Text = info.PcName;
            tBUsername.Text = info.UserName;
            tBModel.Text = info.Model;
            tBSerial.Text = info.Serial;
            tBSysBoot.Text = info.LastBoot;
            tBwifi.Text = info.Wifi;
            tBSigStrn.Text = info.Signal;
            tBDiskspace.Text = info.DiskSpace;

            // Clears and refills the IP List
            lvIP.Clear();
            lvIP.View = View.List;
            foreach (string ip in info.IPs)
            {
                lvIP.Items.Add(ip);
            }
        }

        // Creates a string with all the above information for the clipboard
        private static string BuildCopyText(PcInfo info)
        {
            string ips = "";
            foreach (string ip in info.IPs)
            {
                ips += ip + "\n";
            }

            return "PC Name: " + info.PcName
                + "\nUsername: " + info.UserName
                + "\nDevice Model: " + info.Model
                + "\nSerial Number: " + info.Serial
                + "\nWiFi: " + info.Wifi
                + "\nSignal Strength: " + info.Signal
                + "\nLast System Boot: " + info.LastBoot
                + "\nFree Disk Space (Gb): " + info.DiskSpace
                + "\nIP Addresses:\n" + ips;
        }
    }
}
