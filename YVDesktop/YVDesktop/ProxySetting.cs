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
    public partial class ProxySetting : Form
    {
        private Form _frm;
        public ProxySetting(Form1 frm)
        {
            _frm = frm;
            InitializeComponent();
        }

        private void ProxySetting_FormClosed(object sender, FormClosedEventArgs e)
        {
            _frm.Enabled = true;
        }

        private void ProxySetting_Load(object sender, EventArgs e)
        {
            ReloadGrid();
        }

        private void btnAddProxy_Click(object sender, EventArgs e)
        {
            var frmAddProxy = new FrmAddProxy(this);
            this.Enabled = false;
            frmAddProxy.Show();
        }

        public void ReloadGrid()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Ip Address", typeof(string));
            table.Columns.Add("Port", typeof(int));
            table.Columns.Add("Protocol", typeof(string));

            var file_proxy_list = "GoodProxy.txt";
            if (File.Exists(file_proxy_list))
            {
                // Read a text file line by line.  
                string[] lines = File.ReadAllLines(file_proxy_list);
                foreach (string line in lines)
                {
                    if (line.Trim() != "")
                    {
                        var s1 = line.Split(":");
                        var s2 = s1[1].Split("|");
                        var ip_address = s1[0];
                        var port = s2[0];
                        var protocol = s2[1];

                        table.Rows.Add(ip_address, Convert.ToInt32(port), protocol);
                    }
                }
            }

            dgvProxyList.DataSource = table;
        }
    }
}
