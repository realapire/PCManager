namespace PCSpecs
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.applyButton = new MaterialSkin.Controls.MaterialButton();
            this.themeComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.filterCheckBox = new MaterialSkin.Controls.MaterialCheckbox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // applyButton
            // 
            this.applyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.applyButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.applyButton.Depth = 0;
            this.applyButton.HighEmphasis = true;
            this.applyButton.Icon = null;
            this.applyButton.Location = new System.Drawing.Point(255, 164);
            this.applyButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.applyButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.applyButton.Name = "applyButton";
            this.applyButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.applyButton.Size = new System.Drawing.Size(67, 36);
            this.applyButton.TabIndex = 0;
            this.applyButton.Text = "APPLY";
            this.applyButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.applyButton.UseAccentColor = false;
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
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
            this.themeComboBox.Location = new System.Drawing.Point(23, 89);
            this.themeComboBox.MaxDropDownItems = 4;
            this.themeComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.themeComboBox.Name = "themeComboBox";
            this.themeComboBox.Size = new System.Drawing.Size(282, 49);
            this.themeComboBox.StartIndex = 0;
            this.themeComboBox.TabIndex = 1;
            this.themeComboBox.SelectedIndexChanged += new System.EventHandler(this.themeComboBox_SelectedIndexChanged);
            // 
            // filterCheckBox
            // 
            this.filterCheckBox.AutoSize = true;
            this.filterCheckBox.Depth = 0;
            this.filterCheckBox.Location = new System.Drawing.Point(14, 153);
            this.filterCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.filterCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.filterCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.filterCheckBox.Name = "filterCheckBox";
            this.filterCheckBox.ReadOnly = false;
            this.filterCheckBox.Ripple = true;
            this.filterCheckBox.Size = new System.Drawing.Size(172, 37);
            this.filterCheckBox.TabIndex = 2;
            this.filterCheckBox.Text = "Remove null values";
            this.filterCheckBox.UseVisualStyleBackColor = true;
            this.filterCheckBox.CheckedChanged += new System.EventHandler(this.filterCheckBox_CheckedChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(302, 170);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(20, 20);
            this.webBrowser1.TabIndex = 4;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 209);
            this.Controls.Add(this.filterCheckBox);
            this.Controls.Add(this.themeComboBox);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.webBrowser1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Sizable = false;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton applyButton;
        private MaterialSkin.Controls.MaterialComboBox themeComboBox;
        private MaterialSkin.Controls.MaterialCheckbox filterCheckBox;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}