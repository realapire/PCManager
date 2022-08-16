namespace PCSpecs
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.registerPanel = new System.Windows.Forms.Panel();
            this.signupTitle = new MaterialSkin.Controls.MaterialLabel();
            this.r_usernameTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.signupButton = new MaterialSkin.Controls.MaterialButton();
            this.backButton = new MaterialSkin.Controls.MaterialButton();
            this.r_confirmpasswordTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.r_passwordTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.loginTitle = new MaterialSkin.Controls.MaterialLabel();
            this.usernameTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.forgetpasswordLabel = new MaterialSkin.Controls.MaterialLabel();
            this.guestButton = new MaterialSkin.Controls.MaterialButton();
            this.passwordTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.registerButton = new MaterialSkin.Controls.MaterialButton();
            this.loginButton = new MaterialSkin.Controls.MaterialButton();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.registerPanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerPanel
            // 
            this.registerPanel.Controls.Add(this.signupTitle);
            this.registerPanel.Controls.Add(this.r_usernameTextBox);
            this.registerPanel.Controls.Add(this.signupButton);
            this.registerPanel.Controls.Add(this.backButton);
            this.registerPanel.Controls.Add(this.r_confirmpasswordTextBox);
            this.registerPanel.Controls.Add(this.r_passwordTextBox);
            this.registerPanel.Controls.Add(this.webBrowser2);
            this.registerPanel.Location = new System.Drawing.Point(324, 72);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(308, 347);
            this.registerPanel.TabIndex = 38;
            // 
            // signupTitle
            // 
            this.signupTitle.AutoSize = true;
            this.signupTitle.Depth = 0;
            this.signupTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.signupTitle.Location = new System.Drawing.Point(14, 16);
            this.signupTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.signupTitle.Name = "signupTitle";
            this.signupTitle.Size = new System.Drawing.Size(215, 19);
            this.signupTitle.TabIndex = 34;
            this.signupTitle.Text = "Join our awesome community";
            // 
            // r_usernameTextBox
            // 
            this.r_usernameTextBox.AnimateReadOnly = false;
            this.r_usernameTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.r_usernameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.r_usernameTextBox.Depth = 0;
            this.r_usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.r_usernameTextBox.HideSelection = true;
            this.r_usernameTextBox.Hint = "Username";
            this.r_usernameTextBox.LeadingIcon = null;
            this.r_usernameTextBox.LeaveOnEnterKey = true;
            this.r_usernameTextBox.Location = new System.Drawing.Point(11, 61);
            this.r_usernameTextBox.MaxLength = 50;
            this.r_usernameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.r_usernameTextBox.Name = "r_usernameTextBox";
            this.r_usernameTextBox.PasswordChar = '\0';
            this.r_usernameTextBox.PrefixSuffixText = null;
            this.r_usernameTextBox.ReadOnly = false;
            this.r_usernameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.r_usernameTextBox.SelectedText = "";
            this.r_usernameTextBox.SelectionLength = 0;
            this.r_usernameTextBox.SelectionStart = 0;
            this.r_usernameTextBox.ShortcutsEnabled = true;
            this.r_usernameTextBox.Size = new System.Drawing.Size(285, 48);
            this.r_usernameTextBox.TabIndex = 27;
            this.r_usernameTextBox.TabStop = false;
            this.r_usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.r_usernameTextBox.TrailingIcon = null;
            this.r_usernameTextBox.UseSystemPasswordChar = false;
            // 
            // signupButton
            // 
            this.signupButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signupButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.signupButton.Depth = 0;
            this.signupButton.HighEmphasis = true;
            this.signupButton.Icon = null;
            this.signupButton.Location = new System.Drawing.Point(217, 300);
            this.signupButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.signupButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.signupButton.Name = "signupButton";
            this.signupButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.signupButton.Size = new System.Drawing.Size(77, 36);
            this.signupButton.TabIndex = 29;
            this.signupButton.Text = "SIGN UP";
            this.signupButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.signupButton.UseAccentColor = false;
            this.signupButton.UseVisualStyleBackColor = true;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // backButton
            // 
            this.backButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.backButton.Depth = 0;
            this.backButton.HighEmphasis = true;
            this.backButton.Icon = null;
            this.backButton.Location = new System.Drawing.Point(11, 300);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.backButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.backButton.Name = "backButton";
            this.backButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.backButton.Size = new System.Drawing.Size(64, 36);
            this.backButton.TabIndex = 30;
            this.backButton.Text = "LOGIN";
            this.backButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.backButton.UseAccentColor = true;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // r_confirmpasswordTextBox
            // 
            this.r_confirmpasswordTextBox.AnimateReadOnly = false;
            this.r_confirmpasswordTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.r_confirmpasswordTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.r_confirmpasswordTextBox.Depth = 0;
            this.r_confirmpasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.r_confirmpasswordTextBox.HideSelection = true;
            this.r_confirmpasswordTextBox.Hint = "Confirm Password";
            this.r_confirmpasswordTextBox.LeadingIcon = null;
            this.r_confirmpasswordTextBox.LeaveOnEnterKey = true;
            this.r_confirmpasswordTextBox.Location = new System.Drawing.Point(11, 183);
            this.r_confirmpasswordTextBox.MaxLength = 50;
            this.r_confirmpasswordTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.r_confirmpasswordTextBox.Name = "r_confirmpasswordTextBox";
            this.r_confirmpasswordTextBox.PasswordChar = '*';
            this.r_confirmpasswordTextBox.PrefixSuffixText = null;
            this.r_confirmpasswordTextBox.ReadOnly = false;
            this.r_confirmpasswordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.r_confirmpasswordTextBox.SelectedText = "";
            this.r_confirmpasswordTextBox.SelectionLength = 0;
            this.r_confirmpasswordTextBox.SelectionStart = 0;
            this.r_confirmpasswordTextBox.ShortcutsEnabled = false;
            this.r_confirmpasswordTextBox.Size = new System.Drawing.Size(285, 48);
            this.r_confirmpasswordTextBox.TabIndex = 31;
            this.r_confirmpasswordTextBox.TabStop = false;
            this.r_confirmpasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.r_confirmpasswordTextBox.TrailingIcon = null;
            this.r_confirmpasswordTextBox.UseSystemPasswordChar = false;
            // 
            // r_passwordTextBox
            // 
            this.r_passwordTextBox.AnimateReadOnly = false;
            this.r_passwordTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.r_passwordTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.r_passwordTextBox.Depth = 0;
            this.r_passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.r_passwordTextBox.HideSelection = true;
            this.r_passwordTextBox.Hint = "Password";
            this.r_passwordTextBox.LeadingIcon = null;
            this.r_passwordTextBox.LeaveOnEnterKey = true;
            this.r_passwordTextBox.Location = new System.Drawing.Point(11, 129);
            this.r_passwordTextBox.MaxLength = 50;
            this.r_passwordTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.r_passwordTextBox.Name = "r_passwordTextBox";
            this.r_passwordTextBox.PasswordChar = '*';
            this.r_passwordTextBox.PrefixSuffixText = null;
            this.r_passwordTextBox.ReadOnly = false;
            this.r_passwordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.r_passwordTextBox.SelectedText = "";
            this.r_passwordTextBox.SelectionLength = 0;
            this.r_passwordTextBox.SelectionStart = 0;
            this.r_passwordTextBox.ShortcutsEnabled = true;
            this.r_passwordTextBox.Size = new System.Drawing.Size(285, 48);
            this.r_passwordTextBox.TabIndex = 28;
            this.r_passwordTextBox.TabStop = false;
            this.r_passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.r_passwordTextBox.TrailingIcon = null;
            this.r_passwordTextBox.UseSystemPasswordChar = false;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(264, 300);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.ScrollBarsEnabled = false;
            this.webBrowser2.Size = new System.Drawing.Size(20, 20);
            this.webBrowser2.TabIndex = 32;
            this.webBrowser2.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser2_DocumentCompleted);
            // 
            // loginTitle
            // 
            this.loginTitle.AutoSize = true;
            this.loginTitle.Depth = 0;
            this.loginTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.loginTitle.Location = new System.Drawing.Point(12, 26);
            this.loginTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginTitle.Name = "loginTitle";
            this.loginTitle.Size = new System.Drawing.Size(217, 19);
            this.loginTitle.TabIndex = 33;
            this.loginTitle.Text = "Login with an existing account";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.AnimateReadOnly = false;
            this.usernameTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.usernameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.usernameTextBox.Depth = 0;
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.usernameTextBox.HideSelection = true;
            this.usernameTextBox.Hint = "Username";
            this.usernameTextBox.LeadingIcon = null;
            this.usernameTextBox.Location = new System.Drawing.Point(11, 61);
            this.usernameTextBox.MaxLength = 50;
            this.usernameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PasswordChar = '\0';
            this.usernameTextBox.PrefixSuffixText = null;
            this.usernameTextBox.ReadOnly = false;
            this.usernameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usernameTextBox.SelectedText = "";
            this.usernameTextBox.SelectionLength = 0;
            this.usernameTextBox.SelectionStart = 0;
            this.usernameTextBox.ShortcutsEnabled = true;
            this.usernameTextBox.Size = new System.Drawing.Size(285, 48);
            this.usernameTextBox.TabIndex = 19;
            this.usernameTextBox.TabStop = false;
            this.usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usernameTextBox.TrailingIcon = null;
            this.usernameTextBox.UseSystemPasswordChar = false;
            // 
            // forgetpasswordLabel
            // 
            this.forgetpasswordLabel.AutoSize = true;
            this.forgetpasswordLabel.Depth = 0;
            this.forgetpasswordLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.forgetpasswordLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.forgetpasswordLabel.HighEmphasis = true;
            this.forgetpasswordLabel.Location = new System.Drawing.Point(12, 180);
            this.forgetpasswordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.forgetpasswordLabel.Name = "forgetpasswordLabel";
            this.forgetpasswordLabel.Size = new System.Drawing.Size(99, 14);
            this.forgetpasswordLabel.TabIndex = 24;
            this.forgetpasswordLabel.Text = "Forgot password?";
            // 
            // guestButton
            // 
            this.guestButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guestButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.guestButton.Depth = 0;
            this.guestButton.HighEmphasis = true;
            this.guestButton.Icon = null;
            this.guestButton.Location = new System.Drawing.Point(11, 259);
            this.guestButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.guestButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.guestButton.Name = "guestButton";
            this.guestButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.guestButton.Size = new System.Drawing.Size(120, 36);
            this.guestButton.TabIndex = 22;
            this.guestButton.Text = "TRY AS GUEST";
            this.guestButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.guestButton.UseAccentColor = true;
            this.guestButton.UseVisualStyleBackColor = true;
            this.guestButton.Click += new System.EventHandler(this.guestButton_Click_1);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.AnimateReadOnly = false;
            this.passwordTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.passwordTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passwordTextBox.Depth = 0;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordTextBox.HideSelection = true;
            this.passwordTextBox.Hint = "Password";
            this.passwordTextBox.LeadingIcon = null;
            this.passwordTextBox.Location = new System.Drawing.Point(11, 129);
            this.passwordTextBox.MaxLength = 50;
            this.passwordTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.PrefixSuffixText = null;
            this.passwordTextBox.ReadOnly = false;
            this.passwordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.SelectionLength = 0;
            this.passwordTextBox.SelectionStart = 0;
            this.passwordTextBox.ShortcutsEnabled = true;
            this.passwordTextBox.Size = new System.Drawing.Size(285, 48);
            this.passwordTextBox.TabIndex = 20;
            this.passwordTextBox.TabStop = false;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTextBox.TrailingIcon = null;
            this.passwordTextBox.UseSystemPasswordChar = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(31, 269);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(20, 20);
            this.webBrowser1.TabIndex = 26;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(234, 312);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScrollBarsEnabled = false;
            this.webBrowser.Size = new System.Drawing.Size(20, 20);
            this.webBrowser.TabIndex = 25;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // registerButton
            // 
            this.registerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registerButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.registerButton.Depth = 0;
            this.registerButton.HighEmphasis = true;
            this.registerButton.Icon = null;
            this.registerButton.Location = new System.Drawing.Point(11, 300);
            this.registerButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.registerButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.registerButton.Name = "registerButton";
            this.registerButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.registerButton.Size = new System.Drawing.Size(77, 36);
            this.registerButton.TabIndex = 23;
            this.registerButton.Text = "SIGN UP";
            this.registerButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.registerButton.UseAccentColor = false;
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.loginButton.Depth = 0;
            this.loginButton.HighEmphasis = true;
            this.loginButton.Icon = null;
            this.loginButton.Location = new System.Drawing.Point(231, 300);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginButton.Name = "loginButton";
            this.loginButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.loginButton.Size = new System.Drawing.Size(64, 36);
            this.loginButton.TabIndex = 21;
            this.loginButton.Text = "LOGIN";
            this.loginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.loginButton.UseAccentColor = false;
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.loginTitle);
            this.loginPanel.Controls.Add(this.usernameTextBox);
            this.loginPanel.Controls.Add(this.passwordTextBox);
            this.loginPanel.Controls.Add(this.forgetpasswordLabel);
            this.loginPanel.Controls.Add(this.guestButton);
            this.loginPanel.Controls.Add(this.webBrowser1);
            this.loginPanel.Controls.Add(this.registerButton);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Controls.Add(this.webBrowser);
            this.loginPanel.Location = new System.Drawing.Point(6, 72);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(308, 347);
            this.loginPanel.TabIndex = 37;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 420);
            this.Controls.Add(this.registerPanel);
            this.Controls.Add(this.loginPanel);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 420);
            this.MinimumSize = new System.Drawing.Size(320, 420);
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(3, 72, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.registerPanel.ResumeLayout(false);
            this.registerPanel.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel registerPanel;
        private MaterialSkin.Controls.MaterialLabel signupTitle;
        private MaterialSkin.Controls.MaterialTextBox2 r_usernameTextBox;
        private MaterialSkin.Controls.MaterialButton signupButton;
        private MaterialSkin.Controls.MaterialButton backButton;
        private MaterialSkin.Controls.MaterialTextBox2 r_confirmpasswordTextBox;
        private MaterialSkin.Controls.MaterialTextBox2 r_passwordTextBox;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private MaterialSkin.Controls.MaterialLabel loginTitle;
        private MaterialSkin.Controls.MaterialTextBox2 usernameTextBox;
        private MaterialSkin.Controls.MaterialLabel forgetpasswordLabel;
        private MaterialSkin.Controls.MaterialButton guestButton;
        private MaterialSkin.Controls.MaterialTextBox2 passwordTextBox;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser webBrowser;
        private MaterialSkin.Controls.MaterialButton registerButton;
        private MaterialSkin.Controls.MaterialButton loginButton;
        private System.Windows.Forms.Panel loginPanel;
    }
}