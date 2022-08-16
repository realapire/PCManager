using LibreHardwareMonitor.Hardware;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.VisualBasic.Devices;
using System;
using System.Drawing;
using System.Management;
using System.Windows.Forms;
using System.Threading;

namespace PCSpecs
{
    public partial class MainForm : MaterialForm
    {

        public MainForm()
        {

            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);

            if (Properties.Settings.Default.themeIndex == 1)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                cpuUsageBar.InnerColor = Color.White;
                cpuTempBar.InnerColor = Color.White;
                gpuTempBar.InnerColor = Color.White;
                gpuTempBar.InnerColor = Color.White;
            }
            if (Properties.Settings.Default.themeIndex == 2)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                cpuUsageBar.InnerColor = Color.DimGray;
                cpuTempBar.InnerColor = Color.DimGray;
                gpuTempBar.InnerColor = Color.DimGray;
                gpuUsageBar.InnerColor = Color.DimGray;
            }
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey600, Primary.Grey700, Primary.Grey500, Accent.LightBlue700, TextShade.WHITE);

            if (Properties.Settings.Default.isUser)
            {
                profileCard.Visible = true;
                guestCard.Visible = false;
                profileCard.Location = new Point(607, 21);
                guestCard.Location = new Point(1000, 21);
            }

            if (!Properties.Settings.Default.isUser)
            {
                guestCard.Visible = true;
                profileCard.Visible = false;
                guestCard.Location = new Point(607, 21);
                profileCard.Location = new Point(1000, 21);
            }

            t.Abort();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InsertInfo("Win32_Processor", ref cpuListView, Convert.ToBoolean(Properties.Settings.Default.filterIndex));

            InsertInfo("Win32_VideoController", ref graphicsListView, Convert.ToBoolean(Properties.Settings.Default.filterIndex));

            InsertInfo("Win32_PhysicalMemory", ref ramListView, Convert.ToBoolean(Properties.Settings.Default.filterIndex));

            InsertInfo("Win32_BaseBoard", ref motherboardListView, Convert.ToBoolean(Properties.Settings.Default.filterIndex));

            InsertInfo("CIM_DiskDrive", ref storageListView, Convert.ToBoolean(Properties.Settings.Default.filterIndex));

            InsertInfo("Win32_OperatingSystem", ref operatingsystemListView, Convert.ToBoolean(Properties.Settings.Default.filterIndex));

            InsertInfo("Win32_Keyboard", ref keyboardListView, Convert.ToBoolean(Properties.Settings.Default.filterIndex));
            InsertInfo("Win32_PointingDevice", ref mouseListView, Convert.ToBoolean(Properties.Settings.Default.filterIndex));
            InsertInfo("Win32_Printer", ref printerListView, Convert.ToBoolean(Properties.Settings.Default.filterIndex));

            InsertInfo("Win32_SoundDevice", ref audioListView, Convert.ToBoolean(Properties.Settings.Default.filterIndex));

            InsertInfo("Win32_NetworkAdapter", ref networkadapterListView, Convert.ToBoolean(Properties.Settings.Default.filterIndex));
            InsertInfo("Win32_NetworkClient", ref networkclientListView, Convert.ToBoolean(Properties.Settings.Default.filterIndex));
            InsertInfo("Win32_NetworkProtocol", ref networkprotocolListView, Convert.ToBoolean(Properties.Settings.Default.filterIndex));

            welcomeLabel.Text = "Logged on as " + Properties.Settings.Default.username;

            LoadProfileList();

            GetCPUInformation();
            GetGPUInformation();
        }

        public void StartForm()
        {
            Application.Run(new Splashscreen());
        }
        
        void LoadProfileList()
        {
            classWin32List.Items.Clear();
            webBrowser.Navigate("https://pcmanager.rf.gd/app.getuserclass.php?username=" + Properties.Settings.Default.username);
        }
        
        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            var response = webBrowser.Document.GetElementsByTagName("p");
            foreach (HtmlElement reply in response)
            {
                if (reply.GetAttribute("className") == "result")
                {
                    classWin32List.Items.Add(reply.InnerHtml);
                }
            }
        }

        
        
        public void GetCPUInformation()
        {
            LibreHardwareMonitor.Hardware.Computer cpuReader = new LibreHardwareMonitor.Hardware.Computer
            {
                IsCpuEnabled = true,
            };

            cpuReader.Open();

            foreach (IHardware hardware in cpuReader.Hardware)
            {
                if (hardware.HardwareType == HardwareType.Cpu)
                {
                    hardware.Update();
                    foreach (ISensor sensor in hardware.Sensors)
                    {
                        if(sensor.SensorType == SensorType.Temperature && sensor.Name == "Core Average")
                        {

                            cpuTempBar.Invoke((MethodInvoker)delegate
                            {
                                cpuTempBar.Value = Convert.ToInt16(sensor.Value.GetValueOrDefault());
                                cpuTempBar.Text = sensor.Value.GetValueOrDefault().ToString("N0") + "°C";
                            });
                        }
                        if(sensor.SensorType == SensorType.Load)
                        {

                            cpuUsageBar.Invoke((MethodInvoker)delegate
                            {
                                cpuUsageBar.Value = Convert.ToInt16(sensor.Value.GetValueOrDefault());
                                cpuUsageBar.Text = sensor.Value.GetValueOrDefault().ToString("N0") + "%";
                            });
                        }
                    }
                }
            }

            cpuReader.Close();
        }
        

        public void GetGPUInformation()
        {

            LibreHardwareMonitor.Hardware.Computer gpuReader = new LibreHardwareMonitor.Hardware.Computer
            {
                IsGpuEnabled = true
            };

            gpuReader.Open();

            foreach (IHardware hardware in gpuReader.Hardware)
            {
                //NVIDIA GPU
                if (hardware.HardwareType == HardwareType.GpuNvidia)
                {
                    hardware.Update();
                    foreach (ISensor sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature && sensor.Name == "GPU Core")
                        {

                            gpuTempBar.Invoke((MethodInvoker)delegate
                            {
                                gpuTempBar.Value = Convert.ToInt16(sensor.Value.GetValueOrDefault());
                                gpuTempBar.Text = sensor.Value.GetValueOrDefault().ToString("N0") + "°C";
                            });
                        }
                        if(sensor.SensorType == SensorType.Load && sensor.Name == "GPU Core")
                        {

                            gpuUsageBar.Invoke((MethodInvoker)delegate
                            {
                                gpuUsageBar.Value = Convert.ToInt16(sensor.Value.GetValueOrDefault());
                                gpuUsageBar.Text = sensor.Value.GetValueOrDefault().ToString("N0") + "%";
                            });
                        }
                    }
                }

                //AMD GPU
                if (hardware.HardwareType == HardwareType.GpuAmd)
                {
                    hardware.Update();
                    foreach (ISensor sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature && sensor.Name == "GPU Core")
                        {
                            gpuTempBar.Invoke((MethodInvoker)delegate
                            {
                                gpuTempBar.Value = Convert.ToInt16(sensor.Value.GetValueOrDefault());
                                gpuTempBar.Text = sensor.Value.GetValueOrDefault().ToString("N0") + "°C";
                            });
                        }
                        if (sensor.SensorType == SensorType.Load && sensor.Name == "GPU Core")
                        {
                            gpuUsageBar.Invoke((MethodInvoker)delegate
                            {
                                gpuUsageBar.Value = Convert.ToInt16(sensor.Value.GetValueOrDefault());
                                gpuUsageBar.Text = sensor.Value.GetValueOrDefault().ToString("N0") + "%";
                            });
                        }
                    }
                }
            }

            gpuReader.Close();

        }
        
        public string getAvailableRAM()
        {
            string txt = string.Empty;

            ComputerInfo CI = new ComputerInfo();
            ulong mem = ulong.Parse(CI.TotalPhysicalMemory.ToString());
            txt = (mem / (1024 * 1024) + " MB").ToString();
            return txt;
        }


        private void InsertInfo(string Key, ref MaterialListView lst, bool DontInsertNull)
        {
            lst.Items.Clear();

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM " + Key);
            
            try
            {
                foreach (ManagementObject share in searcher.Get())
                {

                    ListViewGroup grp;
                    try
                    {
                        grp = lst.Groups.Add(share["Name"].ToString(), share["Name"].ToString());
                    }
                    catch
                    {
                        grp = lst.Groups.Add(share.ToString(), share.ToString());
                    }

                    if (share.Properties.Count <= 0)
                    {
                        MessageBox.Show("No available information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    foreach (PropertyData PC in share.Properties)
                    {

                        ListViewItem item = new ListViewItem(grp);
                        if (lst.Items.Count % 2 != 0)
                            item.BackColor = Color.White;
                        else
                            item.BackColor = Color.WhiteSmoke;

                        item.Text = PC.Name;

                        if (PC.Value != null && PC.Value.ToString() != "")
                        {
                            switch (PC.Value.GetType().ToString())
                            {
                                case "System.String[]":
                                    string[] str = (string[])PC.Value;

                                    string str2 = "";
                                    foreach (string st in str)
                                        str2 += st + " ";

                                    item.SubItems.Add(str2);

                                    break;
                                case "System.UInt16[]":
                                    ushort[] shortData = (ushort[])PC.Value;


                                    string tstr2 = "";
                                    foreach (ushort st in shortData)
                                        tstr2 += st.ToString() + " ";

                                    item.SubItems.Add(tstr2);

                                    break;

                                default:
                                    item.SubItems.Add(PC.Value.ToString());
                                    break;
                            }
                        }
                        else
                        {
                            if (!DontInsertNull)
                                item.SubItems.Add("No available information");
                            else
                                continue;
                        }
                        lst.Items.Add(item);
                    }
                }
            }


            catch (Exception exp)
            {
                MessageBox.Show("Given error: \n" + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        
        private void cpuRedirectButton_Click(object sender, EventArgs e)
        {
            specificationsMenu.SelectedIndex = 1;
        }

        private void gpuRedirectButton_Click(object sender, EventArgs e)
        {
            specificationsMenu.SelectedIndex = 2;
        }

        private void updateOverview_Tick(object sender, EventArgs e)
        {

            GetCPUInformation();
            GetGPUInformation();
            LoadProfileList();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void customclassButton_Click(object sender, EventArgs e)
        {
            CustomClass customclassForm = new CustomClass();
            customclassForm.Show();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://pcmanager.rf.gd/");
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void cpuDetails_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.graphIndex = 1;
            Graph graphForm = new Graph();
            graphForm.ShowDialog();
        }

        private void gpuDetails_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.graphIndex = 2;
            Graph graphForm = new Graph();
            graphForm.ShowDialog();
        }

        private void updateUI_Tick(object sender, EventArgs e)
        {

            cpuUsageBar.Font = new Font("Microsoft Sans Serif", 36f, FontStyle.Bold);
            cpuTempBar.Font = new Font("Microsoft Sans Serif", 32f, FontStyle.Bold);

            gpuUsageBar.Font = new Font("Microsoft Sans Serif", 36f, FontStyle.Bold);
            gpuTempBar.Font = new Font("Microsoft Sans Serif", 32f, FontStyle.Bold);

        }

        private void classWin32List_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.redirectedClass = classWin32List.SelectedItem.ToString();
                CustomClass customClass = new CustomClass();
                customClass.ShowDialog();
            }
            catch (Exception ex) { }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Minimized)
            {
                menuStrip.Visible = true;
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void overviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            specificationsMenu.SelectedIndex = 0;
        }

        private void settingstoolStripMenu_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void restarttoolStripMenu_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        
    }

}

