using MaterialSkin.Controls;
using System.Windows.Forms;
using MaterialSkin;
using System;

namespace PCSpecs
{
    public partial class SettingsForm : MaterialForm
    {
        int themeIndex = Properties.Settings.Default.themeIndex;
        int filterIndex = Properties.Settings.Default.filterIndex;


        public SettingsForm()
        {
            InitializeComponent();


            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);

            if (Properties.Settings.Default.themeIndex == 1)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }
            if (Properties.Settings.Default.themeIndex == 2)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            }

            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey600, Primary.Grey700, Primary.Grey500, Accent.LightBlue700, TextShade.WHITE);
        }

        private void themeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (themeComboBox.SelectedIndex)
            {
                case 0:
                    themeIndex = 1;
                    break;
                case 1:
                    themeIndex = 2;
                    break;
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.isUser)
            {
                webBrowser1.Navigate("https://pcmanager.rf.gd/app.setusersettings.php?username=" + Properties.Settings.Default.username + "&theme=" + themeIndex + "&filter=" + filterIndex);
                DialogResult restart = MessageBox.Show("You have to restart the application for changes to be applied, would you like to restart it now?", "Restart needed", MessageBoxButtons.YesNo);
                if(restart == DialogResult.Yes)
                {
                    Application.Restart();
                } 
                else
                {
                    this.Close();
                }
            } else
            {
                DialogResult loginRequired = MessageBox.Show("An account is required to change the settings, would you like to login?", "Account needed", MessageBoxButtons.YesNo);
                if(loginRequired == DialogResult.Yes)
                {
                    this.Hide();
                    LoginForm loginForm = new LoginForm();
                    loginForm.ShowDialog();
                } 
                else
                {
                    this.Close();
                }
            }
        }

        private void filterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (filterCheckBox.Checked)
            {
                filterIndex = 1;
            }
            if (!filterCheckBox.Checked)
            {
                filterIndex = 0;
            }
        }
    }
}
