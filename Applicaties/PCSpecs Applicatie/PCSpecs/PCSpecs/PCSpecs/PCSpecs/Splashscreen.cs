using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PCSpecs
{
    public partial class Splashscreen : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Splashscreen()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            if (Properties.Settings.Default.isUser)
            {
                userLabel.Text = "Logged on as " + Properties.Settings.Default.username;
            } 
            else
            {
                userLabel.Text = "Guest mode";
            }
        }
    }
}
