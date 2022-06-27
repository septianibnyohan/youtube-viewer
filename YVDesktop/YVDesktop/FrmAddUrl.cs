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
    public partial class FrmAddUrl : Form
    {
        UrlSetting frm;
        public FrmAddUrl(UrlSetting _frm)
        {
            this.frm = _frm;
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //var row = (DataGridViewRow)frm.dgvUrlList.Rows[0].Clone();
            //row.Cells[0].Value = tbxUrlAddress.Text;
            //frm.dgvUrlList.Rows.Add(row);

            DataRow newRow = frm.Table.NewRow();
            newRow[0] = tbxUrlAddress.Text; ;

            // Add the row to the rows collection.
            frm.Table.Rows.Add(newRow);
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
