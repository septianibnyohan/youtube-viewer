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
    public partial class UrlSetting : Form
    {
        public DataTable Table { get; set; }
        public UrlSetting()
        {
            InitializeComponent();
        }

        private void UrlSetting_Load(object sender, EventArgs e)
        {
            ReloadGrid();
        }

        public void ReloadGrid(bool hasButton = false)
        {
            Table = new DataTable();
            Table.Columns.Add("Url", typeof(string));

            var file_url_list = "urls.txt";
            if (File.Exists(file_url_list))
            {
                // Read a text file line by line.  
                string[] lines = File.ReadAllLines(file_url_list);
                foreach (string line in lines)
                {
                    Table.Rows.Add(line);
                }
            }

            dgvUrlList.DataSource = Table;

            if (!hasButton)
            {
                var deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "dataGridViewDeleteButton";
                deleteButton.HeaderText = "Action";
                //deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;
                this.dgvUrlList.Columns.Add(deleteButton);
            }

            dgvUrlList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dgvUrlList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == dgvUrlList.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == dgvUrlList.Columns["dataGridViewDeleteButton"].Index)
            {
                var image = Properties.Resources.DeleteImage; //An image
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var x = e.CellBounds.Left + (e.CellBounds.Width - image.Width) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - image.Height) / 2;
                e.Graphics.DrawImage(image, new Point(x, y));

                e.Handled = true;
            }
        }

        private void dgvUrlList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //If this is header row or new row, do nothing
            if (e.RowIndex < 0 || e.RowIndex == this.dgvUrlList.NewRowIndex)
                return;

            //If formatting your desired column, set the value
            //if (e.ColumnIndex == dgvUrlList.Columns["dataGridViewDeleteButton"].Index)
            //{
            //    e.Value = "Delete";
            //}
        }

        private void dgvUrlList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == dgvUrlList.NewRowIndex || e.RowIndex < 0)
                return;

            //Check if click is on specific column 
            if (e.ColumnIndex == dgvUrlList.Columns["dataGridViewDeleteButton"].Index)
            {
                dgvUrlList.Rows.RemoveAt(e.RowIndex);
                //Put some logic here, for example to remove row from your binding list.
                //yourBindingList.RemoveAt(e.RowIndex);

                // Or
                // var data = (Product)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                // do something 
            }
        }

        private void btnAddProxy_Click(object sender, EventArgs e)
        {
            var frm_add_url = new FrmAddUrl(this);
            frm_add_url.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fileName = @"urls.txt";
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
                    foreach(DataRow row in Table.Rows)
                    {
                        sw.WriteLine(row[0]);
                    }
                }

            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
            this.Close();
        }
    }
}
