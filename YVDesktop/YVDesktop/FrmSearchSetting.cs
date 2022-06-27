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
    public partial class FrmSearchSetting : Form
    {
        public DataTable Table { get; set; }

        public FrmSearchSetting()
        {
            InitializeComponent();
        }

        private void FrmSearchSetting_Load(object sender, EventArgs e)
        {
            ReloadGrid();
        }

        public void ReloadGrid(bool hasButton = false)
        {
            Table = new DataTable();
            Table.Columns.Add("Search", typeof(string));

            var file_url_list = "search.txt";
            if (File.Exists(file_url_list))
            {
                // Read a text file line by line.  
                string[] lines = File.ReadAllLines(file_url_list);
                foreach (string line in lines)
                {
                    if (line.Trim() != "")
                    {
                        var real_line = line.Split(" :::: ")[0];
                        Table.Rows.Add(real_line);
                    }
                    
                }
            }

            dgvSearchList.DataSource = Table;

            if (!hasButton)
            {
                var deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "dataGridViewDeleteButton";
                deleteButton.HeaderText = "Action";
                //deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;
                this.dgvSearchList.Columns.Add(deleteButton);
            }

            dgvSearchList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fileName = @"search.txt";
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
                    int counter = 1;
                    foreach (DataRow row in Table.Rows)
                    {
                        sw.WriteLine($"{row[0]} :::: exact video title {counter}");
                        ++counter;
                    }
                }

            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
            this.Close();
        }

        private void dgvSearchList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == dgvSearchList.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == dgvSearchList.Columns["dataGridViewDeleteButton"].Index)
            {
                var image = Properties.Resources.DeleteImage; //An image
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var x = e.CellBounds.Left + (e.CellBounds.Width - image.Width) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - image.Height) / 2;
                e.Graphics.DrawImage(image, new Point(x, y));

                e.Handled = true;
            }
        }

        private void dgvSearchList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == dgvSearchList.NewRowIndex || e.RowIndex < 0)
                return;

            //Check if click is on specific column 
            if (e.ColumnIndex == dgvSearchList.Columns["dataGridViewDeleteButton"].Index)
            {
                dgvSearchList.Rows.RemoveAt(e.RowIndex);
                //Put some logic here, for example to remove row from your binding list.
                //yourBindingList.RemoveAt(e.RowIndex);

                // Or
                // var data = (Product)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                // do something 
            }
        }

        private void btnAddSearch_Click(object sender, EventArgs e)
        {
            var frm_add_search = new FrmAddSearch(this);
            frm_add_search.ShowDialog();
        }
    }
}
