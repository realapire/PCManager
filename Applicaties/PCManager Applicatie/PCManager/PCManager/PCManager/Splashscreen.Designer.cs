namespace PCManager
{
    partial class Splashscreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splashscreen));
            this.titleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.userLabel = new MaterialSkin.Controls.MaterialLabel();
            this.loadingBar = new CircularProgressBar.CircularProgressBar();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.Depth = 0;
            this.titleLabel.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.titleLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.titleLabel.HighEmphasis = true;
            this.titleLabel.Location = new System.Drawing.Point(60, 30);
            this.titleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(180, 41);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "PCManager";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Depth = 0;
            this.userLabel.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.userLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline;
            this.userLabel.Location = new System.Drawing.Point(6, 384);
            this.userLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(113, 13);
            this.userLabel.TabIndex = 4;
            this.userLabel.Text = "Logged on as {username}";
            // 
            // loadingBar
            // 
            this.loadingBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.loadingBar.AnimationSpeed = 500;
            this.loadingBar.BackColor = System.Drawing.Color.Transparent;
            this.loadingBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loadingBar.InnerColor = System.Drawing.Color.Transparent;
            this.loadingBar.InnerMargin = 2;
            this.loadingBar.InnerWidth = -1;
            this.loadingBar.Location = new System.Drawing.Point(25, 120);
            this.loadingBar.MarqueeAnimationSpeed = 5000;
            this.loadingBar.Name = "loadingBar";
            this.loadingBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.loadingBar.OuterMargin = -25;
            this.loadingBar.OuterWidth = 26;
            this.loadingBar.ProgressColor = System.Drawing.SystemColors.Highlight;
            this.loadingBar.ProgressWidth = 10;
            this.loadingBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.loadingBar.Size = new System.Drawing.Size(250, 250);
            this.loadingBar.StartAngle = 270;
            this.loadingBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.loadingBar.SubscriptColor = System.Drawing.Color.Transparent;
            this.loadingBar.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.loadingBar.SubscriptText = "";
            this.loadingBar.SuperscriptColor = System.Drawing.Color.Transparent;
            this.loadingBar.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.loadingBar.SuperscriptText = "";
            this.loadingBar.TabIndex = 5;
            this.loadingBar.Text = "Loading";
            this.loadingBar.TextMargin = new System.Windows.Forms.Padding(0);
            this.loadingBar.Value = 68;
            // 
            // Splashscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.ControlBox = false;
            this.Controls.Add(this.loadingBar);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Splashscreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splashscreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel titleLabel;
        private MaterialSkin.Controls.MaterialLabel userLabel;
        private CircularProgressBar.CircularProgressBar loadingBar;
    }
}