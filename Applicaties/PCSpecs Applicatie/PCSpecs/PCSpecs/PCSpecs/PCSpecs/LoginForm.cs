using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PCSpecs
{
    public partial class LoginForm : MaterialForm
    {



        public LoginForm()
        {
            InitializeComponent();

            
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey600, Primary.Grey700, Primary.Grey500, Accent.LightBlue700, TextShade.WHITE);
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void registerButton_Click(object sender, EventArgs e)
        {
            ShowRegister();
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
                MessageBox.Show("Please fill in all input fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void guestButton_Click_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.isUser = false;
            this.Hide();
            MainForm nextForm = new MainForm();
            nextForm.ShowDialog();
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
                    
                    webBrowser1.Navigate("https://pcmanager.rf.gd/app.getusersettings.php?username=" + Properties.Settings.Default.username);


                }
                else
                {
                    MessageBox.Show("Account was not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ShowLogin();
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
                    MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all input fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            var response = webBrowser1.Document.GetElementsByTagName("p");
            foreach (HtmlElement reply in response)
            {
                if (reply.GetAttribute("className") == "result1")
                {
                    Properties.Settings.Default.themeIndex = short.Parse(reply.InnerHtml);
                }
                if (reply.GetAttribute("className") == "result2")
                {
                    Properties.Settings.Default.filterIndex = short.Parse(reply.InnerHtml);
                }
            }

            this.Hide();
            MainForm app = new MainForm();
            app.ShowDialog();   

        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            var response = webBrowser2.Document.GetElementsByTagName("p");
            foreach (HtmlElement reply in response)
            {
                if (reply.GetAttribute("className") == "succesful")
                {
                    MessageBox.Show("Account was created succesfully", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
