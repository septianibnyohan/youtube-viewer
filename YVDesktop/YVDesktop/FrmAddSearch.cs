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
    public partial class FrmAddSearch : Form
    {
        FrmSearchSetting frm;
        public FrmAddSearch(FrmSearchSetting _frm)
        {
            this.frm = _frm;
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DataRow newRow = frm.Table.NewRow();
            newRow[0] = tbxSearch.Text; ;

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
