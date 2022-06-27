using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YVDesktop
{
    public partial class FrmAddProxy : Form
    {
        private ProxySetting _frm;
        public FrmAddProxy(ProxySetting frm)
        {
            _frm = frm;
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string fileName = @"px.txt";
            FileInfo fi = new FileInfo(fileName);

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (fi.Exists)
                {
                    fi.Delete();
                }

                // Create a new file     
                using (StreamWriter sw = fi.CreateText())
                {
                    for (int i = 0; i < tbxProxyList.Lines.Length; i++)
                    {
                        var line = tbxProxyList.Lines[i].Trim();
                        
                        if (line != "")
                        {
                            sw.WriteLine(line);
                        }
                        
                    }
                }

                var process = System.Diagnostics.Process.Start("proxy_check.exe", "100 px.txt");
                process.WaitForExit();

                MessageBox.Show("Add proxy finished...");

            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddProxy_FormClosed(object sender, FormClosedEventArgs e)
        {
            _frm.Enabled = true;
            _frm.ReloadGrid();
        }

       
    }
}
