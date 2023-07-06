using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32; 

namespace autostart
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            bool success = true; 
            try
            {
                string applicationPath = textBoxAppPath.Text;
                string registryEntryName = textBoxRegistryName.Text;

                if (!File.Exists(applicationPath))
                {
                    statusLabel.Visible = true;
                    statusLabel.Text = $"The path {applicationPath} does not exist.";
                    statusLabel.BackColor = Color.Red;
                    statusLabel.AutoSize = false;
                    statusLabel.MaximumSize = new Size(1000, 0);
                    statusLabel.AutoSize = true;

                    success = false;
                }

                using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
                {
                    if (key.GetValue(registryEntryName) != null)
                    {
                        statusLabel.Visible = true;
                        statusLabel.Text = $"The registry entry {registryEntryName} already exists.";
                        statusLabel.BackColor = Color.Red;
                        statusLabel.AutoSize = false;
                        statusLabel.MaximumSize = new Size(1000, 0);
                        statusLabel.AutoSize = true;

                        success = false;
                    }
                    if (success == true)
                    {
                        key.SetValue(registryEntryName, applicationPath);
                        statusLabel.Visible = true;
                        statusLabel.Text = "Success!";
                        statusLabel.BackColor = Color.Green;
                        statusLabel.AutoSize = false;
                        statusLabel.MaximumSize = new Size(1000, 0);
                        statusLabel.AutoSize = true;

                    }

                }
            }
            catch (Exception i)
            {
                statusLabel.Visible = true;
                statusLabel.Text = $"Failed to add to startup \n Exception : {i}";
                statusLabel.BackColor = Color.Red;
            }
            finally
            {
                textBoxAppPath.Text = string.Empty;
                textBoxRegistryName.Text = string.Empty;
            }
        }
    }
}
