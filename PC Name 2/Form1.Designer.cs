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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.lb_PCName = new System.Windows.Forms.Label();
            this.tBPCName = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.tBUsername = new System.Windows.Forms.TextBox();
            this.lBModel = new System.Windows.Forms.Label();
            this.tBModel = new System.Windows.Forms.TextBox();
            this.lBSerial = new System.Windows.Forms.Label();
            this.tBSerial = new System.Windows.Forms.TextBox();
            this.lbWifi = new System.Windows.Forms.Label();
            this.tBwifi = new System.Windows.Forms.TextBox();
            this.lbSigStrn = new System.Windows.Forms.Label();
            this.tBSigStrn = new System.Windows.Forms.TextBox();
            this.lBSysBoot = new System.Windows.Forms.Label();
            this.tBSysBoot = new System.Windows.Forms.TextBox();
            this.l_Diskspace = new System.Windows.Forms.Label();
            this.tBDiskspace = new System.Windows.Forms.TextBox();
            this.lbIP = new System.Windows.Forms.Label();
            this.lvIP = new System.Windows.Forms.ListView();
            this.bCopy = new System.Windows.Forms.Button();
            this.b_refresh = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlHeader
            //
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(34, 113, 184);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(380, 56);
            this.pnlHeader.TabIndex = 0;
            //
            // lblTitle
            //
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(16, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(130, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PC Information";
            //
            // pnlFooter
            //
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(246, 247, 249);
            this.pnlFooter.Controls.Add(this.bCopy);
            this.pnlFooter.Controls.Add(this.b_refresh);
            this.pnlFooter.Controls.Add(this.lblVersion);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 476);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(380, 84);
            this.pnlFooter.TabIndex = 2;
            //
            // tlpMain
            //
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.lb_PCName, 0, 0);
            this.tlpMain.Controls.Add(this.tBPCName, 1, 0);
            this.tlpMain.Controls.Add(this.lbUsername, 0, 1);
            this.tlpMain.Controls.Add(this.tBUsername, 1, 1);
            this.tlpMain.Controls.Add(this.lBModel, 0, 2);
            this.tlpMain.Controls.Add(this.tBModel, 1, 2);
            this.tlpMain.Controls.Add(this.lBSerial, 0, 3);
            this.tlpMain.Controls.Add(this.tBSerial, 1, 3);
            this.tlpMain.Controls.Add(this.lbWifi, 0, 4);
            this.tlpMain.Controls.Add(this.tBwifi, 1, 4);
            this.tlpMain.Controls.Add(this.lbSigStrn, 0, 5);
            this.tlpMain.Controls.Add(this.tBSigStrn, 1, 5);
            this.tlpMain.Controls.Add(this.lBSysBoot, 0, 6);
            this.tlpMain.Controls.Add(this.tBSysBoot, 1, 6);
            this.tlpMain.Controls.Add(this.l_Diskspace, 0, 7);
            this.tlpMain.Controls.Add(this.tBDiskspace, 1, 7);
            this.tlpMain.Controls.Add(this.lbIP, 0, 8);
            this.tlpMain.Controls.Add(this.lvIP, 1, 8);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 56);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.Padding = new System.Windows.Forms.Padding(16, 12, 16, 8);
            this.tlpMain.RowCount = 9;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(380, 420);
            this.tlpMain.TabIndex = 1;
            //
            // lb_PCName
            //
            this.lb_PCName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_PCName.AutoSize = true;
            this.lb_PCName.ForeColor = System.Drawing.Color.FromArgb(90, 100, 115);
            this.lb_PCName.Location = new System.Drawing.Point(19, 21);
            this.lb_PCName.Name = "lb_PCName";
            this.lb_PCName.Size = new System.Drawing.Size(61, 15);
            this.lb_PCName.TabIndex = 0;
            this.lb_PCName.Text = "PC Name:";
            //
            // tBPCName
            //
            this.tBPCName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBPCName.BackColor = System.Drawing.Color.FromArgb(243, 245, 248);
            this.tBPCName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBPCName.Location = new System.Drawing.Point(149, 19);
            this.tBPCName.Name = "tBPCName";
            this.tBPCName.ReadOnly = true;
            this.tBPCName.Size = new System.Drawing.Size(212, 23);
            this.tBPCName.TabIndex = 1;
            //
            // lbUsername
            //
            this.lbUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbUsername.AutoSize = true;
            this.lbUsername.ForeColor = System.Drawing.Color.FromArgb(90, 100, 115);
            this.lbUsername.Location = new System.Drawing.Point(19, 57);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(64, 15);
            this.lbUsername.TabIndex = 2;
            this.lbUsername.Text = "Username:";
            //
            // tBUsername
            //
            this.tBUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBUsername.BackColor = System.Drawing.Color.FromArgb(243, 245, 248);
            this.tBUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBUsername.Location = new System.Drawing.Point(149, 55);
            this.tBUsername.Name = "tBUsername";
            this.tBUsername.ReadOnly = true;
            this.tBUsername.Size = new System.Drawing.Size(212, 23);
            this.tBUsername.TabIndex = 3;
            //
            // lBModel
            //
            this.lBModel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lBModel.AutoSize = true;
            this.lBModel.ForeColor = System.Drawing.Color.FromArgb(90, 100, 115);
            this.lBModel.Location = new System.Drawing.Point(19, 93);
            this.lBModel.Name = "lBModel";
            this.lBModel.Size = new System.Drawing.Size(83, 15);
            this.lBModel.TabIndex = 4;
            this.lBModel.Text = "Device Model:";
            //
            // tBModel
            //
            this.tBModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBModel.BackColor = System.Drawing.Color.FromArgb(243, 245, 248);
            this.tBModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBModel.Location = new System.Drawing.Point(149, 91);
            this.tBModel.Name = "tBModel";
            this.tBModel.ReadOnly = true;
            this.tBModel.Size = new System.Drawing.Size(212, 23);
            this.tBModel.TabIndex = 5;
            //
            // lBSerial
            //
            this.lBSerial.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lBSerial.AutoSize = true;
            this.lBSerial.ForeColor = System.Drawing.Color.FromArgb(90, 100, 115);
            this.lBSerial.Location = new System.Drawing.Point(19, 129);
            this.lBSerial.Name = "lBSerial";
            this.lBSerial.Size = new System.Drawing.Size(79, 15);
            this.lBSerial.TabIndex = 6;
            this.lBSerial.Text = "Device Serial:";
            //
            // tBSerial
            //
            this.tBSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBSerial.BackColor = System.Drawing.Color.FromArgb(243, 245, 248);
            this.tBSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBSerial.Location = new System.Drawing.Point(149, 127);
            this.tBSerial.Name = "tBSerial";
            this.tBSerial.ReadOnly = true;
            this.tBSerial.Size = new System.Drawing.Size(212, 23);
            this.tBSerial.TabIndex = 7;
            //
            // lbWifi
            //
            this.lbWifi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbWifi.AutoSize = true;
            this.lbWifi.ForeColor = System.Drawing.Color.FromArgb(90, 100, 115);
            this.lbWifi.Location = new System.Drawing.Point(19, 165);
            this.lbWifi.Name = "lbWifi";
            this.lbWifi.Size = new System.Drawing.Size(68, 15);
            this.lbWifi.TabIndex = 8;
            this.lbWifi.Text = "WiFi Name:";
            //
            // tBwifi
            //
            this.tBwifi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBwifi.BackColor = System.Drawing.Color.FromArgb(243, 245, 248);
            this.tBwifi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBwifi.Location = new System.Drawing.Point(149, 163);
            this.tBwifi.Name = "tBwifi";
            this.tBwifi.ReadOnly = true;
            this.tBwifi.Size = new System.Drawing.Size(212, 23);
            this.tBwifi.TabIndex = 9;
            //
            // lbSigStrn
            //
            this.lbSigStrn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbSigStrn.AutoSize = true;
            this.lbSigStrn.ForeColor = System.Drawing.Color.FromArgb(90, 100, 115);
            this.lbSigStrn.Location = new System.Drawing.Point(19, 201);
            this.lbSigStrn.Name = "lbSigStrn";
            this.lbSigStrn.Size = new System.Drawing.Size(92, 15);
            this.lbSigStrn.TabIndex = 10;
            this.lbSigStrn.Text = "Signal Strength:";
            //
            // tBSigStrn
            //
            this.tBSigStrn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBSigStrn.BackColor = System.Drawing.Color.FromArgb(243, 245, 248);
            this.tBSigStrn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBSigStrn.Location = new System.Drawing.Point(149, 199);
            this.tBSigStrn.Name = "tBSigStrn";
            this.tBSigStrn.ReadOnly = true;
            this.tBSigStrn.Size = new System.Drawing.Size(212, 23);
            this.tBSigStrn.TabIndex = 11;
            //
            // lBSysBoot
            //
            this.lBSysBoot.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lBSysBoot.AutoSize = true;
            this.lBSysBoot.ForeColor = System.Drawing.Color.FromArgb(90, 100, 115);
            this.lBSysBoot.Location = new System.Drawing.Point(19, 237);
            this.lBSysBoot.Name = "lBSysBoot";
            this.lBSysBoot.Size = new System.Drawing.Size(103, 15);
            this.lBSysBoot.TabIndex = 12;
            this.lBSysBoot.Text = "Last System Boot:";
            //
            // tBSysBoot
            //
            this.tBSysBoot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBSysBoot.BackColor = System.Drawing.Color.FromArgb(243, 245, 248);
            this.tBSysBoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBSysBoot.Location = new System.Drawing.Point(149, 235);
            this.tBSysBoot.Name = "tBSysBoot";
            this.tBSysBoot.ReadOnly = true;
            this.tBSysBoot.Size = new System.Drawing.Size(212, 23);
            this.tBSysBoot.TabIndex = 13;
            //
            // l_Diskspace
            //
            this.l_Diskspace.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_Diskspace.AutoSize = true;
            this.l_Diskspace.ForeColor = System.Drawing.Color.FromArgb(90, 100, 115);
            this.l_Diskspace.Location = new System.Drawing.Point(19, 273);
            this.l_Diskspace.Name = "l_Diskspace";
            this.l_Diskspace.Size = new System.Drawing.Size(120, 15);
            this.l_Diskspace.TabIndex = 14;
            this.l_Diskspace.Text = "Free Disk Space (Gb):";
            //
            // tBDiskspace
            //
            this.tBDiskspace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBDiskspace.BackColor = System.Drawing.Color.FromArgb(243, 245, 248);
            this.tBDiskspace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBDiskspace.Location = new System.Drawing.Point(149, 271);
            this.tBDiskspace.Name = "tBDiskspace";
            this.tBDiskspace.ReadOnly = true;
            this.tBDiskspace.Size = new System.Drawing.Size(212, 23);
            this.tBDiskspace.TabIndex = 15;
            //
            // lbIP
            //
            this.lbIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.lbIP.AutoSize = true;
            this.lbIP.ForeColor = System.Drawing.Color.FromArgb(90, 100, 115);
            this.lbIP.Location = new System.Drawing.Point(19, 313);
            this.lbIP.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(77, 15);
            this.lbIP.TabIndex = 16;
            this.lbIP.Text = "IP Addresses:";
            //
            // lvIP
            //
            this.lvIP.BackColor = System.Drawing.Color.FromArgb(243, 245, 248);
            this.lvIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvIP.HideSelection = false;
            this.lvIP.Location = new System.Drawing.Point(149, 309);
            this.lvIP.Name = "lvIP";
            this.lvIP.Size = new System.Drawing.Size(212, 100);
            this.lvIP.TabIndex = 17;
            this.lvIP.UseCompatibleStateImageBehavior = false;
            //
            // bCopy
            //
            this.bCopy.BackColor = System.Drawing.Color.FromArgb(34, 113, 184);
            this.bCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCopy.FlatAppearance.BorderSize = 0;
            this.bCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(22, 82, 138);
            this.bCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(28, 96, 160);
            this.bCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCopy.ForeColor = System.Drawing.Color.White;
            this.bCopy.Location = new System.Drawing.Point(16, 12);
            this.bCopy.Name = "bCopy";
            this.bCopy.Size = new System.Drawing.Size(160, 34);
            this.bCopy.TabIndex = 0;
            this.bCopy.Text = "Copy to Clipboard";
            this.bCopy.UseVisualStyleBackColor = false;
            this.bCopy.Click += new System.EventHandler(this.bCopy_Click);
            //
            // b_refresh
            //
            this.b_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_refresh.BackColor = System.Drawing.Color.White;
            this.b_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_refresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(34, 113, 184);
            this.b_refresh.FlatAppearance.BorderSize = 1;
            this.b_refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(214, 228, 242);
            this.b_refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(232, 240, 249);
            this.b_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_refresh.ForeColor = System.Drawing.Color.FromArgb(34, 113, 184);
            this.b_refresh.Location = new System.Drawing.Point(264, 12);
            this.b_refresh.Name = "b_refresh";
            this.b_refresh.Size = new System.Drawing.Size(100, 34);
            this.b_refresh.TabIndex = 1;
            this.b_refresh.Text = "Refresh";
            this.b_refresh.UseVisualStyleBackColor = false;
            this.b_refresh.Click += new System.EventHandler(this.b_refresh_Click_1);
            //
            // lblVersion
            //
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(130, 138, 150);
            this.lblVersion.Location = new System.Drawing.Point(16, 58);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(103, 13);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Version: {0}.{1}.{2}.{3}";
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 560);
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlFooter);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(380, 540);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PC Name";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
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

