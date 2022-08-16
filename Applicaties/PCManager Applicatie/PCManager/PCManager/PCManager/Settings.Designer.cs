namespace PCManager
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.themeComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.applyButton = new MaterialSkin.Controls.MaterialButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // themeComboBox
            // 
            this.themeComboBox.AutoResize = false;
            this.themeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.themeComboBox.Depth = 0;
            this.themeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.themeComboBox.DropDownHeight = 174;
            this.themeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.themeComboBox.DropDownWidth = 121;
            this.themeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.themeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.themeComboBox.FormattingEnabled = true;
            this.themeComboBox.Hint = "Theme";
            this.themeComboBox.IntegralHeight = false;
            this.themeComboBox.ItemHeight = 43;
            this.themeComboBox.Items.AddRange(new object[] {
            "LIGHT",
            "DARK"});
            this.themeComboBox.Location = new System.Drawing.Point(23, 84);
            this.themeComboBox.MaxDropDownItems = 4;
            this.themeComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.themeComboBox.Name = "themeComboBox";
            this.themeComboBox.Size = new System.Drawing.Size(282, 49);
            this.themeComboBox.StartIndex = 0;
            this.themeComboBox.TabIndex = 6;
            this.themeComboBox.SelectedIndexChanged += new System.EventHandler(this.themeComboBox_SelectedIndexChanged);
            // 
            // applyButton
            // 
            this.applyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.applyButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.applyButton.Depth = 0;
            this.applyButton.HighEmphasis = true;
            this.applyButton.Icon = null;
            this.applyButton.Location = new System.Drawing.Point(238, 151);
            this.applyButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.applyButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.applyButton.Name = "applyButton";
            this.applyButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.applyButton.Size = new System.Drawing.Size(67, 36);
            this.applyButton.TabIndex = 5;
            this.applyButton.Text = "APPLY";
            this.applyButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.applyButton.UseAccentColor = false;
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(285, 167);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(20, 20);
            this.webBrowser1.TabIndex = 9;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 203);
            this.Controls.Add(this.themeComboBox);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.webBrowser1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(440, 240);
            this.Name = "Settings";
            this.Sizable = false;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialComboBox themeComboBox;
        private MaterialSkin.Controls.MaterialButton applyButton;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}