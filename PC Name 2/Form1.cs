using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DoPCName();

            //Stores App Version number on Load
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            this.lblVersion.Text = String.Format(this.lblVersion.Text, version.Major, version.Minor, version.Build, version.Revision);

        }

        private void bCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(DoPCName());
        }

        private void b_refresh_Click_1(object sender, EventArgs e)
        {
            DoPCName();
        }

        //Runs on Load and when pressing refresh or copy to clipboard
        public string DoPCName()
        {
            //Get PC Name
            String q1 = Environment.MachineName;
            tBPCName.Text = q1;
           
            //Get Username
            String q2 = Environment.UserName;
            tBUsername.Text = q2;

            //Get DeviceModel

            ManagementClass mc1 = new ManagementClass("Win32_ComputerSystemProduct");
            //collection to store all management objects
            ManagementObjectCollection moc1 = mc1.GetInstances();
            if (moc1.Count != 0)
            {
                foreach (ManagementObject mo1 in mc1.GetInstances())
                {
                    string IN = (mo1["IdentifyingNumber"]).ToString();
                    string Name = (mo1["Name"]).ToString();
                    string Vendor = (mo1["Vendor"]).ToString();
                    string Version = (mo1["Version"]).ToString();
                    
                    // display general system information
                    if (Vendor.Contains("Dell") ^ Vendor.Contains("HP"))
                    {
                        tBModel.Text = Name;
                        tBSerial.Text = IN;
                    }
                    else if (Vendor.Contains("LEN"))
                    {
                        tBModel.Text = Version;
                        tBSerial.Text = IN;
                    }
                    else
                    {
                        tBModel.Text = "";
                        tBSerial.Text = "";
                    }
                    

                }
            }

            // System Uptime
            DateTime osStartTime = DateTime.Now - new TimeSpan(10000 * GetTickCount64());
            tBSysBoot.Text = (osStartTime).ToString();

            // Clears the IP List
            lvIP.Clear();
            lvIP.View = View.List;

            //Get IP Addresses
            string ips = "";
            IPAddress[] addresses = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in addresses)
            {
                //for IPv4 .. if needed :)
                if (address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    string ip = address.ToString();
                    lvIP.Items.Add(ip);
                    ips += ip;
                    ips += "\n";

                }
            }



            // Show SSID and Signal Strength
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "netsh.exe";
            p.StartInfo.Arguments = "wlan show interfaces";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.Start();

            string s = p.StandardOutput.ReadToEnd();
            try
            {
                string s1 = s.Substring(s.IndexOf("SSID"));
                s1 = s1.Substring(s1.IndexOf(":"));
                s1 = s1.Substring(2, s1.IndexOf("\n")).Trim();
                tBwifi.Text = s1;
            }
            catch { tBwifi.Text = "";  }

            try
            {
                string s2 = s.Substring(s.IndexOf("Signal"));
                s2 = s2.Substring(s2.IndexOf(":"));
                s2 = s2.Substring(2, s2.IndexOf("\n")).Trim();
                tBSigStrn.Text = s2;
            }
            catch { tBSigStrn.Text = ""; }
            p.WaitForExit();

            //Disk Space
            const decimal BytesInGB = 1073741824;
            DriveInfo dInfo = new DriveInfo("C");
            decimal avl = dInfo.AvailableFreeSpace;
            decimal GB = avl / (BytesInGB);
            tBDiskspace.Text = GB.ToString("#.##");

            // OS Version
            /*
                RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");

                var _UBR = registryKey.GetValue("UBR").ToString();
                var _CurrentBuild = registryKey.GetValue("CurrentBuild").ToString();

                string _version = _CurrentBuild + "." + _UBR;
            */

            // Creates a string will all the above information and passes it as a variable for the clipboard
            string copy = "PC Name: " + tBPCName.Text + "\nUsername: " + tBUsername.Text + "\nDevice Model: " + tBModel.Text + "\nSerial Number: " + tBSerial.Text + "\nWiFi: " + tBwifi.Text + "\nSignal Strength: " + tBSigStrn.Text + "\nLast System Boot: " + tBSysBoot.Text + "\nFree Disk Space (Gb): " + tBDiskspace.Text + "\nIP Addresses:\n" + ips;
            return copy;
        }

        private void l_Diskspace_Click(object sender, EventArgs e)
        {

        }
    }
}
