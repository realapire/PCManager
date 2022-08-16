using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PCManager
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey600, Primary.Grey700, Primary.Grey500, Accent.LightBlue700, TextShade.WHITE);
        }

        private void guestButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.isUser = false;
            this.Hide();
            MainApp app = new MainApp();
            app.ShowDialog();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(usernameTextBox.Text) && !string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                {

                    string username = usernameTextBox.Text;
                    string password = passwordTextBox.Text;

                    string urlAddress = "https://pcmanager.rf.gd/app.login.php?username=" + username + "&password=" + password;
                    webBrowser.Navigate(urlAddress);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all input fields");
            }
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            var response = webBrowser.Document.GetElementsByTagName("p");
            foreach (HtmlElement reply in response)
            {
                if (reply.GetAttribute("className") == "found")
                {
                    Properties.Settings.Default.username = usernameTextBox.Text;
                    Properties.Settings.Default.isUser = true;

                    webBrowser1.Navigate("https://pcmanager.rf.gd/app.manager.getusersettings.php?username=" + Properties.Settings.Default.username);


                }
                else
                {
                    MessageBox.Show("Account was not found");
                }
            }
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(r_usernameTextBox.Text) && !string.IsNullOrWhiteSpace(r_passwordTextBox.Text) && !string.IsNullOrWhiteSpace(r_confirmpasswordTextBox.Text))
            {
                if (r_passwordTextBox.Text == r_confirmpasswordTextBox.Text)
                {
                    string username = r_usernameTextBox.Text;
                    string password = r_passwordTextBox.Text;

                    string urlAddress = "https://pcmanager.rf.gd/app.register.php?username=" + username + "&password=" + password;

                    webBrowser2.Navigate(urlAddress);
                }
                else
                {
                    MessageBox.Show("Passwords do not match");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all input fields");
            }
        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            var response = webBrowser2.Document.GetElementsByTagName("p");
            foreach (HtmlElement reply in response)
            {
                if (reply.GetAttribute("className") == "succesful")
                {
                    MessageBox.Show("Account was created succesfully.", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowLogin();
                }
                else if (reply.GetAttribute("className") == "taken")
                {
                    MessageBox.Show("Username is already taken, please choose another one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    r_usernameTextBox.Clear();
                    r_passwordTextBox.Clear();
                    r_confirmpasswordTextBox.Clear();
                }
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            var response = webBrowser1.Document.GetElementsByTagName("p");
            foreach (HtmlElement reply in response)
            {
                if (reply.GetAttribute("className") == "result")
                {
                    Properties.Settings.Default.themeIndex = short.Parse(reply.InnerHtml);

                    this.Hide();
                    MainApp app = new MainApp();
                    app.ShowDialog();
                }
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            ShowRegister();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ShowLogin();
        }

        void ShowLogin()
        {
            loginPanel.Visible = true;
            registerPanel.Location = new Point(324, 67);
            this.Text = "Login";
        }
        void ShowRegister()
        { 
            loginPanel.Visible = false;
            registerPanel.Location = new Point(6, 67);
            this.Text = "Register";
        }
    }
}
