namespace PCManager
{
    partial class MainApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.cleanerButton = new MaterialSkin.Controls.MaterialButton();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.materialTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.cleanerTab = new System.Windows.Forms.TabPage();
            this.settingsButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.infoLabel = new MaterialSkin.Controls.MaterialLabel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.networkTab = new System.Windows.Forms.TabPage();
            this.settingsButton = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.getspeedButton = new MaterialSkin.Controls.MaterialButton();
            this.flushdnsButton = new MaterialSkin.Controls.MaterialButton();
            this.releaseipButton = new MaterialSkin.Controls.MaterialButton();
            this.renewipButton = new MaterialSkin.Controls.MaterialButton();
            this.networkinfoCard = new MaterialSkin.Controls.MaterialCard();
            this.ip6Label = new MaterialSkin.Controls.MaterialLabel();
            this.ip4Label = new MaterialSkin.Controls.MaterialLabel();
            this.menuImages = new System.Windows.Forms.ImageList(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.networkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.restarttoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quittoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialTabControl.SuspendLayout();
            this.cleanerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.networkTab.SuspendLayout();
            this.networkinfoCard.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // cleanerButton
            // 
            this.cleanerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cleanerButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cleanerButton.Depth = 0;
            this.cleanerButton.HighEmphasis = true;
            this.cleanerButton.Icon = null;
            this.cleanerButton.Location = new System.Drawing.Point(242, 426);
            this.cleanerButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cleanerButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.cleanerButton.Name = "cleanerButton";
            this.cleanerButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cleanerButton.Size = new System.Drawing.Size(128, 36);
            this.cleanerButton.TabIndex = 0;
            this.cleanerButton.Text = "CLEAN SYSTEM";
            this.cleanerButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cleanerButton.UseAccentColor = true;
            this.cleanerButton.UseVisualStyleBackColor = true;
            this.cleanerButton.Click += new System.EventHandler(this.cleanerButton_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // materialTabControl
            // 
            this.materialTabControl.Controls.Add(this.cleanerTab);
            this.materialTabControl.Controls.Add(this.networkTab);
            this.materialTabControl.Depth = 0;
            this.materialTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl.ImageList = this.menuImages;
            this.materialTabControl.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl.Multiline = true;
            this.materialTabControl.Name = "materialTabControl";
            this.materialTabControl.SelectedIndex = 0;
            this.materialTabControl.Size = new System.Drawing.Size(674, 533);
            this.materialTabControl.TabIndex = 4;
            // 
            // cleanerTab
            // 
            this.cleanerTab.Controls.Add(this.settingsButton1);
            this.cleanerTab.Controls.Add(this.infoLabel);
            this.cleanerTab.Controls.Add(this.progressBar);
            this.cleanerTab.Controls.Add(this.pictureBox1);
            this.cleanerTab.Controls.Add(this.cleanerButton);
            this.cleanerTab.Controls.Add(this.webBrowser);
            this.cleanerTab.ImageKey = "bin (1).png";
            this.cleanerTab.Location = new System.Drawing.Point(4, 39);
            this.cleanerTab.Name = "cleanerTab";
            this.cleanerTab.Padding = new System.Windows.Forms.Padding(3);
            this.cleanerTab.Size = new System.Drawing.Size(666, 490);
            this.cleanerTab.TabIndex = 0;
            this.cleanerTab.Text = "Cleaner";
            this.cleanerTab.UseVisualStyleBackColor = true;
            // 
            // settingsButton1
            // 
            this.settingsButton1.Depth = 0;
            this.settingsButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.settingsButton1.Icon = global::PCManager.Properties.Resources.settings__1_;
            this.settingsButton1.Location = new System.Drawing.Point(623, 3);
            this.settingsButton1.Mini = true;
            this.settingsButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.settingsButton1.Name = "settingsButton1";
            this.settingsButton1.Size = new System.Drawing.Size(40, 470);
            this.settingsButton1.TabIndex = 8;
            this.settingsButton1.UseVisualStyleBackColor = true;
            this.settingsButton1.Click += new System.EventHandler(this.settingsButton1_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Depth = 0;
            this.infoLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.infoLabel.HighEmphasis = true;
            this.infoLabel.Location = new System.Drawing.Point(189, 316);
            this.infoLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(235, 19);
            this.infoLabel.TabIndex = 6;
            this.infoLabel.Text = "Boost your PC with just one click!";
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(3, 473);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(660, 14);
            this.progressBar.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PCManager.Properties.Resources.health;
            this.pictureBox1.Location = new System.Drawing.Point(182, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(252, 139);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScrollBarsEnabled = false;
            this.webBrowser.Size = new System.Drawing.Size(20, 20);
            this.webBrowser.TabIndex = 7;
            this.webBrowser.Visible = false;
            // 
            // networkTab
            // 
            this.networkTab.Controls.Add(this.settingsButton);
            this.networkTab.Controls.Add(this.getspeedButton);
            this.networkTab.Controls.Add(this.flushdnsButton);
            this.networkTab.Controls.Add(this.releaseipButton);
            this.networkTab.Controls.Add(this.renewipButton);
            this.networkTab.Controls.Add(this.networkinfoCard);
            this.networkTab.ImageKey = "network (1).png";
            this.networkTab.Location = new System.Drawing.Point(4, 39);
            this.networkTab.Name = "networkTab";
            this.networkTab.Padding = new System.Windows.Forms.Padding(3);
            this.networkTab.Size = new System.Drawing.Size(666, 490);
            this.networkTab.TabIndex = 1;
            this.networkTab.Text = "Network";
            this.networkTab.UseVisualStyleBackColor = true;
            // 
            // settingsButton
            // 
            this.settingsButton.Depth = 0;
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.settingsButton.Icon = global::PCManager.Properties.Resources.settings__1_;
            this.settingsButton.Location = new System.Drawing.Point(623, 3);
            this.settingsButton.Mini = true;
            this.settingsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(40, 484);
            this.settingsButton.TabIndex = 6;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // getspeedButton
            // 
            this.getspeedButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.getspeedButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.getspeedButton.Depth = 0;
            this.getspeedButton.HighEmphasis = true;
            this.getspeedButton.Icon = null;
            this.getspeedButton.Location = new System.Drawing.Point(225, 242);
            this.getspeedButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.getspeedButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.getspeedButton.Name = "getspeedButton";
            this.getspeedButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.getspeedButton.Size = new System.Drawing.Size(158, 36);
            this.getspeedButton.TabIndex = 5;
            this.getspeedButton.Text = "ANALYZE INTERNET";
            this.getspeedButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.getspeedButton.UseAccentColor = false;
            this.getspeedButton.UseVisualStyleBackColor = true;
            this.getspeedButton.Click += new System.EventHandler(this.getspeedButton_Click);
            // 
            // flushdnsButton
            // 
            this.flushdnsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flushdnsButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.flushdnsButton.Depth = 0;
            this.flushdnsButton.HighEmphasis = true;
            this.flushdnsButton.Icon = null;
            this.flushdnsButton.Location = new System.Drawing.Point(194, 482);
            this.flushdnsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.flushdnsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.flushdnsButton.Name = "flushdnsButton";
            this.flushdnsButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.flushdnsButton.Size = new System.Drawing.Size(226, 36);
            this.flushdnsButton.TabIndex = 4;
            this.flushdnsButton.Text = "Flush DNS resolver cache";
            this.flushdnsButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.flushdnsButton.UseAccentColor = true;
            this.flushdnsButton.UseVisualStyleBackColor = true;
            this.flushdnsButton.Click += new System.EventHandler(this.flushdnsButton_Click);
            // 
            // releaseipButton
            // 
            this.releaseipButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.releaseipButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.releaseipButton.Depth = 0;
            this.releaseipButton.HighEmphasis = true;
            this.releaseipButton.Icon = null;
            this.releaseipButton.Location = new System.Drawing.Point(156, 386);
            this.releaseipButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.releaseipButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.releaseipButton.Name = "releaseipButton";
            this.releaseipButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.releaseipButton.Size = new System.Drawing.Size(302, 36);
            this.releaseipButton.TabIndex = 3;
            this.releaseipButton.Text = "Release all IP address connections";
            this.releaseipButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.releaseipButton.UseAccentColor = true;
            this.releaseipButton.UseVisualStyleBackColor = true;
            this.releaseipButton.Click += new System.EventHandler(this.releaseipButton_Click);
            // 
            // renewipButton
            // 
            this.renewipButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.renewipButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.renewipButton.Depth = 0;
            this.renewipButton.HighEmphasis = true;
            this.renewipButton.Icon = null;
            this.renewipButton.Location = new System.Drawing.Point(162, 434);
            this.renewipButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.renewipButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.renewipButton.Name = "renewipButton";
            this.renewipButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.renewipButton.Size = new System.Drawing.Size(291, 36);
            this.renewipButton.TabIndex = 1;
            this.renewipButton.Text = "Renew all IP Address Connections";
            this.renewipButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.renewipButton.UseAccentColor = true;
            this.renewipButton.UseVisualStyleBackColor = true;
            this.renewipButton.Click += new System.EventHandler(this.renewipButton_Click);
            // 
            // networkinfoCard
            // 
            this.networkinfoCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.networkinfoCard.Controls.Add(this.ip6Label);
            this.networkinfoCard.Controls.Add(this.ip4Label);
            this.networkinfoCard.Depth = 0;
            this.networkinfoCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.networkinfoCard.Location = new System.Drawing.Point(107, 40);
            this.networkinfoCard.Margin = new System.Windows.Forms.Padding(14);
            this.networkinfoCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.networkinfoCard.Name = "networkinfoCard";
            this.networkinfoCard.Padding = new System.Windows.Forms.Padding(14);
            this.networkinfoCard.Size = new System.Drawing.Size(400, 100);
            this.networkinfoCard.TabIndex = 0;
            // 
            // ip6Label
            // 
            this.ip6Label.AutoSize = true;
            this.ip6Label.Depth = 0;
            this.ip6Label.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ip6Label.Location = new System.Drawing.Point(18, 59);
            this.ip6Label.MouseState = MaterialSkin.MouseState.HOVER;
            this.ip6Label.Name = "ip6Label";
            this.ip6Label.Size = new System.Drawing.Size(107, 19);
            this.ip6Label.TabIndex = 1;
            this.ip6Label.Text = "materialLabel2";
            // 
            // ip4Label
            // 
            this.ip4Label.AutoSize = true;
            this.ip4Label.Depth = 0;
            this.ip4Label.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ip4Label.Location = new System.Drawing.Point(18, 19);
            this.ip4Label.MouseState = MaterialSkin.MouseState.HOVER;
            this.ip4Label.Name = "ip4Label";
            this.ip4Label.Size = new System.Drawing.Size(107, 19);
            this.ip4Label.TabIndex = 0;
            this.ip4Label.Text = "materialLabel1";
            // 
            // menuImages
            // 
            this.menuImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("menuImages.ImageStream")));
            this.menuImages.TransparentColor = System.Drawing.Color.Transparent;
            this.menuImages.Images.SetKeyName(0, "bin (1).png");
            this.menuImages.Images.SetKeyName(1, "network (1).png");
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "PCManager";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.restarttoolStripMenuItem,
            this.quittoolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(117, 98);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cleanerToolStripMenuItem,
            this.networkToolStripMenuItem});
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.showToolStripMenuItem.Text = "Show";
            // 
            // cleanerToolStripMenuItem
            // 
            this.cleanerToolStripMenuItem.Name = "cleanerToolStripMenuItem";
            this.cleanerToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.cleanerToolStripMenuItem.Text = "Cleaner";
            this.cleanerToolStripMenuItem.Click += new System.EventHandler(this.cleanerToolStripMenuItem_Click);
            // 
            // networkToolStripMenuItem
            // 
            this.networkToolStripMenuItem.Name = "networkToolStripMenuItem";
            this.networkToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.networkToolStripMenuItem.Text = "Network";
            this.networkToolStripMenuItem.Click += new System.EventHandler(this.networkToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // restarttoolStripMenuItem
            // 
            this.restarttoolStripMenuItem.Name = "restarttoolStripMenuItem";
            this.restarttoolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.restarttoolStripMenuItem.Text = "Restart";
            this.restarttoolStripMenuItem.Click += new System.EventHandler(this.restarttoolStripMenuItem_Click);
            // 
            // quittoolStripMenuItem
            // 
            this.quittoolStripMenuItem.Name = "quittoolStripMenuItem";
            this.quittoolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.quittoolStripMenuItem.Text = "Quit";
            this.quittoolStripMenuItem.Click += new System.EventHandler(this.quittoolStripMenuItem_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 600);
            this.Controls.Add(this.materialTabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(680, 600);
            this.MinimumSize = new System.Drawing.Size(680, 600);
            this.Name = "MainApp";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainApp_FormClosing);
            this.Resize += new System.EventHandler(this.MainApp_Resize);
            this.materialTabControl.ResumeLayout(false);
            this.cleanerTab.ResumeLayout(false);
            this.cleanerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.networkTab.ResumeLayout(false);
            this.networkTab.PerformLayout();
            this.networkinfoCard.ResumeLayout(false);
            this.networkinfoCard.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton cleanerButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl;
        private System.Windows.Forms.TabPage cleanerTab;
        private System.Windows.Forms.TabPage networkTab;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar;
        private MaterialSkin.Controls.MaterialLabel infoLabel;
        private MaterialSkin.Controls.MaterialButton flushdnsButton;
        private MaterialSkin.Controls.MaterialButton releaseipButton;
        private MaterialSkin.Controls.MaterialButton renewipButton;
        private MaterialSkin.Controls.MaterialCard networkinfoCard;
        private MaterialSkin.Controls.MaterialLabel ip6Label;
        private MaterialSkin.Controls.MaterialLabel ip4Label;
        private System.Windows.Forms.ImageList menuImages;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quittoolStripMenuItem;
        private System.Windows.Forms.WebBrowser webBrowser;
        private MaterialSkin.Controls.MaterialButton getspeedButton;
        private System.Windows.Forms.ToolStripMenuItem restarttoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cleanerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem networkToolStripMenuItem;
        private MaterialSkin.Controls.MaterialFloatingActionButton settingsButton;
        private MaterialSkin.Controls.MaterialFloatingActionButton settingsButton1;
    }
}