using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCSpecs
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            if (!RunAsAdmin.hasAdminRights())
                if (RunAsAdmin.RunElevated())
                return;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (RunAsAdmin.hasAdminRights())
            {
                Application.Run(new LoginForm());
            }
            else
            {
                DialogResult noAdmin = MessageBox.Show("You have to run the application as an administrator", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (noAdmin == DialogResult.Retry)
                {
                    Application.Restart();
                } else
                {
                    Application.Exit();
                }
            }
        }
    }
    
    public static class RunAsAdmin
    {
        public static bool hasAdminRights()
        {
            WindowsPrincipal principal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        public static bool RunElevated()
        {
            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.Verb = "runas";
            processInfo.FileName = Application.ExecutablePath;
            try
            {
                Process.Start(processInfo);
            }
            catch (Win32Exception)
            {
                return false;
            }
            return true;
        }
    }
    
}


