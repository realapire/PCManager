using System;
using MaterialSkin.Controls;
using MaterialSkin;
using LibreHardwareMonitor.Hardware;
using System.Runtime.InteropServices;

namespace PCSpecs
{
    public partial class Graph : MaterialForm
    {
        int cpuTemp = 0;
        int cpuUsage = 0;

        int gpuTemp = 0;
        int gpuUsage = 0;

        int graphIndex = 0;

        public Graph()
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

            graphIndex = Properties.Settings.Default.graphIndex;

            GetCPUInformation();
            GetGPUInformation();

            switch (graphIndex)
            {
                case 1:
                    this.Text = "CPU Graph";
                    usageChart.Series["usage"].Points.AddY(cpuUsage);
                    tempChart.Series["temp"].Points.AddY(cpuTemp);
                    break;
                case 2:
                    this.Text = "GPU Graph";
                    usageChart.Series["usage"].Points.AddY(gpuUsage);
                    tempChart.Series["temp"].Points.AddY(gpuTemp);
                    break;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            GetCPUInformation();
            GetGPUInformation();

            switch (graphIndex)
            {
                case 1:
                    usageChart.Series["usage"].Points.AddY(cpuUsage);
                    tempChart.Series["temp"].Points.AddY(cpuTemp);
                    break;
                case 2:
                    usageChart.Series["usage"].Points.AddY(gpuUsage);
                    tempChart.Series["temp"].Points.AddY(gpuTemp);
                    break;
            }    
        }

        public void GetCPUInformation()
        {
            Computer cpuReader = new Computer
            {
                IsCpuEnabled = true
            };

            cpuReader.Open();

            foreach (IHardware hardware in cpuReader.Hardware)
            {
                if (hardware.HardwareType == HardwareType.Cpu)
                {
                    hardware.Update();
                    foreach (ISensor sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature)
                        {
                            cpuTemp = Convert.ToInt16(sensor.Value.GetValueOrDefault());
                        }
                        if (sensor.SensorType == SensorType.Load)
                        {
                            cpuUsage = Convert.ToInt16(sensor.Value.GetValueOrDefault());
                        }
                    }
                }
            }

            cpuReader.Close();
        }

        public void GetGPUInformation()
        {

            Computer gpuReader = new Computer
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
                            gpuTemp = Convert.ToInt16(sensor.Value.GetValueOrDefault());
                        }
                        if (sensor.SensorType == SensorType.Load && sensor.Name == "GPU Core")
                        {
                            gpuUsage = Convert.ToInt16(sensor.Value.GetValueOrDefault());
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
                            gpuTemp = Convert.ToInt16(sensor.Value.GetValueOrDefault());
                        }
                        if (sensor.SensorType == SensorType.Load && sensor.Name == "GPU Core")
                        {
                            gpuUsage = Convert.ToInt16(sensor.Value.GetValueOrDefault());
                        }
                    }
                }
            }

            gpuReader.Close();

        }
    }
}
