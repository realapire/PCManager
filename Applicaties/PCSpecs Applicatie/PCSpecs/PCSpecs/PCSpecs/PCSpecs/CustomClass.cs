using MaterialSkin.Controls;
using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.Management;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PCSpecs
{
    public partial class CustomClass : MaterialForm
    {
        
        public CustomClass()
        {
            InitializeComponent();
        }

        private void CustomClass_Load(object sender, EventArgs e)
        {
            try
            {
                if(!string.IsNullOrEmpty(Properties.Settings.Default.redirectedClass))
                    InsertInfo(Properties.Settings.Default.redirectedClass, ref customclassListView, true, false);
            }
            catch (Exception ex) { }
        }

        private void InsertInfo(string Key, ref MaterialListView lst, bool DontInsertNull, bool sendQuery)
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
                webBrowser.Navigate("https://pcmanager.rf.gd/app.adduserclass.php?username=" + Properties.Settings.Default.username + "&class=" + Key);
            }


            catch (Exception exp)
            {
                MessageBox.Show("Given error: " + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void customclassButton_Click(object sender, EventArgs e)
        {
            string customclass = Interaction.InputBox("Enter any of the available classes in the input box down bellow. You can find the Win32 classes in the Microsoft Documentation.", "Custom Class", "Win32_", 500, 300);
            try
            {
                InsertInfo(customclass, ref customclassListView, true, true);
            } catch (Exception ex) { }
        }

    }
}
