using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace PCManager
{
    public partial class MainApp : MaterialForm
    {


        public MainApp()
        {
            try
            {
                Thread t = new Thread(new ThreadStart(StartForm));
                t.Start();
                Thread.Sleep(5000);
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
                t.Abort();
            }
            catch { }

            ip4Label.Invoke((MethodInvoker) delegate
            {
               ip4Label.Text = "IPv4: " + GetIP4();    
            });


            ip6Label.Invoke((MethodInvoker) delegate
            {
                ip6Label.Text = "IPv6: " + GetIP6();
            });

        }

        void StartForm()
        {
            Application.Run(new Splashscreen());
        }

        enum RecycleFlags : int
        {
            SHRB_NOCONFIRMATION = 0x00000001,
            SHRB_NOPROGRESSUI = 0x00000001,
            SHRB_NOSOUND = 0x00000004
        }

        [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
        static extern uint SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlags dwFlags);

        private void cleanerButton_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker.IsBusy)
            {
                inputParameter.Delay = 1;
                inputParameter.Process = 1;
                backgroundWorker.RunWorkerAsync(inputParameter);
            }
        }

        private void MainApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        struct DataParameter
        {
            public int Process;
            public int Delay;
        }

        private DataParameter inputParameter;

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            progressBar.Update();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int process = ((DataParameter)e.Argument).Process;
            int delay = ((DataParameter)e.Argument).Delay;
            int index = 1;

            try
            {
                for(int i = 0; i < process; i++)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress(index++ * 100 / process);
                        Thread.Sleep(delay);
                        CleanPrefetch();
                        CleanTempFolder();
                        EmptyRecycleBin();
                    }
                }
            } 
            catch (Exception ex) 
            {
                backgroundWorker.CancelAsync();
                MessageBox.Show("Error: " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Computer has been cleaned!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (Properties.Settings.Default.isUser)
            {
                webBrowser.Navigate("https://pcmanager.rf.gd/app.setusertimestamp.php?username=" + Properties.Settings.Default.username + "&event=" + 1 + "&timestamp=" + DateTime.Now.ToLongDateString() + " at " + DateTime.Now.ToString("HH:mm"));
            }
            progressBar.Value = 0;
        }

        void CleanPrefetch()
        {
            string tempFolder = Path.GetTempPath();

            Process p = new Process();

            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;

            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c del /s /q %systemdrive%\\Windows\\Prefetch\\*.*";
            p.StartInfo.Verb = "runas";
            p.Start();
            p.WaitForExit();

        }

        void CleanTempFolder()
        {
            string tempFolder = Path.GetTempPath();

            Process p = new Process();

            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;

            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c del /s /q %systemdrive%\\Windows\\Temp\\*.*";
            p.StartInfo.Verb = "runas";
            p.Start();
            p.WaitForExit();

        }


        void EmptyRecycleBin()
        {
            try
            {
                uint IsSuccess = SHEmptyRecycleBin(IntPtr.Zero, null, RecycleFlags.SHRB_NOCONFIRMATION);
            }
            catch(Exception ex)
            {
                MessageBox.Show("The recycle bin could not be recycled" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static string GetIP4()
        {
            try
            {
                string IP4 = string.Empty;

                IP4 = new WebClient().DownloadString("https://ipv4.icanhazip.com/");

                return IP4;
            }
            catch
            {
                return "Error, check provider";
            }
        }

        static string GetIP6()
        {
            try
            {
                string IP6 = string.Empty;

                IP6 = new WebClient().DownloadString("https://ipv6.icanhazip.com/");

                return IP6;
            } catch
            {
                return "Error, check provider";
            }
        }

        private void MainApp_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon.Visible = true;
            }
        }

        private void renewipButton_Click(object sender, EventArgs e)
        {

            Process p = new Process();

            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;

            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c ipconfig /renew";

            p.Start();

            MessageBox.Show("IPConfig renewed succesfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            p.WaitForExit();

            if (Properties.Settings.Default.isUser)
            {
                webBrowser.Navigate("https://pcmanager.rf.gd/app.setusertimestamp.php?username=" + Properties.Settings.Default.username + "&event=" + 4 + "&timestamp=" + DateTime.Now.ToLongDateString() + " at " + DateTime.Now.ToString("HH:mm"));
            }
        }

        private void releaseipButton_Click(object sender, EventArgs e)
        {

            Process p = new Process();

            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;

            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c ipconfig /release & ipconfig /renew";

            try
            {
                p.Start();

                MessageBox.Show("IPConfig released and renewed succesfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                p.WaitForExit();
            } catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            if (Properties.Settings.Default.isUser)
            {
                webBrowser.Navigate("https://pcmanager.rf.gd/app.setusertimestamp.php?username=" + Properties.Settings.Default.username + "&event=" + 3 + "&timestamp=" + "&timestamp=" + DateTime.Now.ToLongDateString() + " at " + DateTime.Now.ToString("HH:mm"));
            }
        }

        private void flushdnsButton_Click(object sender, EventArgs e)
        {
            Process p = new Process();

            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;

            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c ipconfig /flushdns ";

            try
            {
                p.Start();

                MessageBox.Show("DNS flushed succesfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                p.WaitForExit();
            } catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

            if (Properties.Settings.Default.isUser)
            {
                webBrowser.Navigate("https://pcmanager.rf.gd/app.setusertimestamp.php?username=" + Properties.Settings.Default.username + "&event=" + 4 + "&timestamp=" + DateTime.Now.ToLongDateString() + " at " + DateTime.Now.ToString("HH:mm")); 
            }

        }


        private void getspeedButton_Click(object sender, EventArgs e)
        {
           
            Thread thread = null;
            Process process = null;
            string output = string.Empty;

            thread = new Thread(new ThreadStart(() =>
            {
                try
                {

                    getspeedButton.Invoke((MethodInvoker)delegate
                    {
                        getspeedButton.Text = "ANALYZING INTERNET";
                        getspeedButton.Enabled = false;
                    });

                    process = new Process();


                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.CreateNoWindow = true;
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.StartInfo.FileName = "speedtest.exe";
                    process.StartInfo.Arguments = "/c YES & YES";
                    process.StartInfo.Verb = "runas";
                    process.Start();
                    output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();
                    if (string.IsNullOrWhiteSpace(output))
                    {
                        MessageBox.Show("There has been an error.\nPlease confirm the license by going to the application directory and running speedtest.exe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(output, "Speedtest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    getspeedButton.Invoke((MethodInvoker)delegate
                    {
                        getspeedButton.Enabled = true;
                        getspeedButton.Text = "ANALYZE INTERNET";
                    });


                }
                catch (Exception ex)
                {
                    if (thread != null)
                        thread.Abort();
                }
                finally
                {
                    if (process != null)
                    {
                        process.Close();
                        process.Dispose();
                    }
                }
            }
            ));
            thread.Start();

        }

        private void restarttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void quittoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSettings();
        }

        private void cleanerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            materialTabControl.SelectedIndex = 0;
        }

        private void networkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            materialTabControl.SelectedIndex = 1;
        }

        private void settingsButton1_Click(object sender, EventArgs e)
        {
            OpenSettings();
        }

        void OpenSettings()
        {
            Settings settingsForm = new Settings();
            settingsForm.ShowDialog();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            OpenSettings();
        }
    }
}
