namespace PC_Name_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb_PCName = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbWifi = new System.Windows.Forms.Label();
            this.lbSigStrn = new System.Windows.Forms.Label();
            this.lbIP = new System.Windows.Forms.Label();
            this.lvIP = new System.Windows.Forms.ListView();
            this.bCopy = new System.Windows.Forms.Button();
            this.b_refresh = new System.Windows.Forms.Button();
            this.tBPCName = new System.Windows.Forms.TextBox();
            this.tBUsername = new System.Windows.Forms.TextBox();
            this.tBwifi = new System.Windows.Forms.TextBox();
            this.tBSigStrn = new System.Windows.Forms.TextBox();
            this.tBDiskspace = new System.Windows.Forms.TextBox();
            this.l_Diskspace = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.tBModel = new System.Windows.Forms.TextBox();
            this.lBModel = new System.Windows.Forms.Label();
            this.tBSerial = new System.Windows.Forms.TextBox();
            this.lBSerial = new System.Windows.Forms.Label();
            this.tBSysBoot = new System.Windows.Forms.TextBox();
            this.lBSysBoot = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_PCName
            // 
            this.lb_PCName.AutoSize = true;
            this.lb_PCName.Location = new System.Drawing.Point(13, 13);
            this.lb_PCName.Name = "lb_PCName";
            this.lb_PCName.Size = new System.Drawing.Size(55, 13);
            this.lb_PCName.TabIndex = 0;
            this.lb_PCName.Text = "PC Name:";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(13, 38);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(58, 13);
            this.lbUsername.TabIndex = 1;
            this.lbUsername.Text = "Username:";
            // 
            // lbWifi
            // 
            this.lbWifi.AutoSize = true;
            this.lbWifi.Location = new System.Drawing.Point(13, 116);
            this.lbWifi.Name = "lbWifi";
            this.lbWifi.Size = new System.Drawing.Size(62, 13);
            this.lbWifi.TabIndex = 2;
            this.lbWifi.Text = "WiFi Name:";
            // 
            // lbSigStrn
            // 
            this.lbSigStrn.AutoSize = true;
            this.lbSigStrn.Location = new System.Drawing.Point(13, 145);
            this.lbSigStrn.Name = "lbSigStrn";
            this.lbSigStrn.Size = new System.Drawing.Size(82, 13);
            this.lbSigStrn.TabIndex = 3;
            this.lbSigStrn.Text = "Signal Strength:";
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Location = new System.Drawing.Point(12, 230);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(72, 13);
            this.lbIP.TabIndex = 4;
            this.lbIP.Text = "IP Addresses:";
            // 
            // lvIP
            // 
            this.lvIP.HideSelection = false;
            this.lvIP.Location = new System.Drawing.Point(15, 246);
            this.lvIP.Name = "lvIP";
            this.lvIP.Size = new System.Drawing.Size(315, 97);
            this.lvIP.TabIndex = 5;
            this.lvIP.UseCompatibleStateImageBehavior = false;
            // 
            // bCopy
            // 
            this.bCopy.Location = new System.Drawing.Point(11, 349);
            this.bCopy.Name = "bCopy";
            this.bCopy.Size = new System.Drawing.Size(103, 23);
            this.bCopy.TabIndex = 6;
            this.bCopy.Text = "Copy to Clipboard";
            this.bCopy.UseVisualStyleBackColor = true;
            this.bCopy.Click += new System.EventHandler(this.bCopy_Click);
            // 
            // b_refresh
            // 
            this.b_refresh.Location = new System.Drawing.Point(255, 349);
            this.b_refresh.Name = "b_refresh";
            this.b_refresh.Size = new System.Drawing.Size(75, 23);
            this.b_refresh.TabIndex = 7;
            this.b_refresh.Text = "Refresh";
            this.b_refresh.UseVisualStyleBackColor = true;
            this.b_refresh.Click += new System.EventHandler(this.b_refresh_Click_1);
            // 
            // tBPCName
            // 
            this.tBPCName.Location = new System.Drawing.Point(100, 12);
            this.tBPCName.Name = "tBPCName";
            this.tBPCName.Size = new System.Drawing.Size(230, 20);
            this.tBPCName.TabIndex = 8;
            // 
            // tBUsername
            // 
            this.tBUsername.Location = new System.Drawing.Point(100, 38);
            this.tBUsername.Name = "tBUsername";
            this.tBUsername.Size = new System.Drawing.Size(230, 20);
            this.tBUsername.TabIndex = 9;
            // 
            // tBwifi
            // 
            this.tBwifi.Location = new System.Drawing.Point(99, 116);
            this.tBwifi.Name = "tBwifi";
            this.tBwifi.Size = new System.Drawing.Size(232, 20);
            this.tBwifi.TabIndex = 10;
            // 
            // tBSigStrn
            // 
            this.tBSigStrn.Location = new System.Drawing.Point(100, 142);
            this.tBSigStrn.Name = "tBSigStrn";
            this.tBSigStrn.Size = new System.Drawing.Size(231, 20);
            this.tBSigStrn.TabIndex = 11;
            // 
            // tBDiskspace
            // 
            this.tBDiskspace.Location = new System.Drawing.Point(131, 194);
            this.tBDiskspace.Name = "tBDiskspace";
            this.tBDiskspace.Size = new System.Drawing.Size(200, 20);
            this.tBDiskspace.TabIndex = 13;
            // 
            // l_Diskspace
            // 
            this.l_Diskspace.AutoSize = true;
            this.l_Diskspace.Location = new System.Drawing.Point(13, 197);
            this.l_Diskspace.Name = "l_Diskspace";
            this.l_Diskspace.Size = new System.Drawing.Size(112, 13);
            this.l_Diskspace.TabIndex = 12;
            this.l_Diskspace.Text = "Free Disk Space (Gb):";
            this.l_Diskspace.Click += new System.EventHandler(this.l_Diskspace_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(13, 376);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(113, 13);
            this.lblVersion.TabIndex = 14;
            this.lblVersion.Text = "Version: {0}.{1}.{2}.{3}";
            // 
            // tBModel
            // 
            this.tBModel.Location = new System.Drawing.Point(100, 64);
            this.tBModel.Name = "tBModel";
            this.tBModel.Size = new System.Drawing.Size(230, 20);
            this.tBModel.TabIndex = 16;
            // 
            // lBModel
            // 
            this.lBModel.AutoSize = true;
            this.lBModel.Location = new System.Drawing.Point(12, 67);
            this.lBModel.Name = "lBModel";
            this.lBModel.Size = new System.Drawing.Size(76, 13);
            this.lBModel.TabIndex = 15;
            this.lBModel.Text = "Device Model:";
            // 
            // tBSerial
            // 
            this.tBSerial.Location = new System.Drawing.Point(100, 90);
            this.tBSerial.Name = "tBSerial";
            this.tBSerial.Size = new System.Drawing.Size(230, 20);
            this.tBSerial.TabIndex = 18;
            // 
            // lBSerial
            // 
            this.lBSerial.AutoSize = true;
            this.lBSerial.Location = new System.Drawing.Point(12, 93);
            this.lBSerial.Name = "lBSerial";
            this.lBSerial.Size = new System.Drawing.Size(73, 13);
            this.lBSerial.TabIndex = 17;
            this.lBSerial.Text = "Device Serial:";
            // 
            // tBSysBoot
            // 
            this.tBSysBoot.Location = new System.Drawing.Point(131, 168);
            this.tBSysBoot.Name = "tBSysBoot";
            this.tBSysBoot.Size = new System.Drawing.Size(200, 20);
            this.tBSysBoot.TabIndex = 20;
            // 
            // lBSysBoot
            // 
            this.lBSysBoot.AutoSize = true;
            this.lBSysBoot.Location = new System.Drawing.Point(13, 171);
            this.lBSysBoot.Name = "lBSysBoot";
            this.lBSysBoot.Size = new System.Drawing.Size(92, 13);
            this.lBSysBoot.TabIndex = 19;
            this.lBSysBoot.Text = "Last System Boot:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 395);
            this.Controls.Add(this.tBSysBoot);
            this.Controls.Add(this.lBSysBoot);
            this.Controls.Add(this.tBSerial);
            this.Controls.Add(this.lBSerial);
            this.Controls.Add(this.tBModel);
            this.Controls.Add(this.lBModel);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.tBDiskspace);
            this.Controls.Add(this.l_Diskspace);
            this.Controls.Add(this.tBSigStrn);
            this.Controls.Add(this.tBwifi);
            this.Controls.Add(this.tBUsername);
            this.Controls.Add(this.tBPCName);
            this.Controls.Add(this.b_refresh);
            this.Controls.Add(this.bCopy);
            this.Controls.Add(this.lvIP);
            this.Controls.Add(this.lbIP);
            this.Controls.Add(this.lbSigStrn);
            this.Controls.Add(this.lbWifi);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lb_PCName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PC Name";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_PCName;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbWifi;
        private System.Windows.Forms.Label lbSigStrn;
        private System.Windows.Forms.Label lbIP;
        private System.Windows.Forms.ListView lvIP;
        private System.Windows.Forms.Button bCopy;
        private System.Windows.Forms.Button b_refresh;
        private System.Windows.Forms.TextBox tBPCName;
        private System.Windows.Forms.TextBox tBUsername;
        private System.Windows.Forms.TextBox tBwifi;
        private System.Windows.Forms.TextBox tBSigStrn;
        private System.Windows.Forms.TextBox tBDiskspace;
        private System.Windows.Forms.Label l_Diskspace;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TextBox tBModel;
        private System.Windows.Forms.Label lBModel;
        private System.Windows.Forms.TextBox tBSerial;
        private System.Windows.Forms.Label lBSerial;
        private System.Windows.Forms.TextBox tBSysBoot;
        private System.Windows.Forms.Label lBSysBoot;
    }
}

