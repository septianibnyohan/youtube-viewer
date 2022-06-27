namespace YVDesktop
{
    partial class FrmSearchSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddSearch = new System.Windows.Forms.Button();
            this.dgvSearchList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(673, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 29);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddSearch
            // 
            this.btnAddSearch.Location = new System.Drawing.Point(552, 13);
            this.btnAddSearch.Name = "btnAddSearch";
            this.btnAddSearch.Size = new System.Drawing.Size(115, 29);
            this.btnAddSearch.TabIndex = 5;
            this.btnAddSearch.Text = "Add Search";
            this.btnAddSearch.UseVisualStyleBackColor = true;
            this.btnAddSearch.Click += new System.EventHandler(this.btnAddSearch_Click);
            // 
            // dgvSearchList
            // 
            this.dgvSearchList.AllowUserToAddRows = false;
            this.dgvSearchList.AllowUserToDeleteRows = false;
            this.dgvSearchList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchList.Location = new System.Drawing.Point(12, 48);
            this.dgvSearchList.Name = "dgvSearchList";
            this.dgvSearchList.ReadOnly = true;
            this.dgvSearchList.RowHeadersWidth = 51;
            this.dgvSearchList.RowTemplate.Height = 29;
            this.dgvSearchList.Size = new System.Drawing.Size(776, 390);
            this.dgvSearchList.TabIndex = 4;
            this.dgvSearchList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchList_CellClick);
            this.dgvSearchList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvSearchList_CellPainting);
            // 
            // FrmSearchSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddSearch);
            this.Controls.Add(this.dgvSearchList);
            this.Name = "FrmSearchSetting";
            this.Text = "Search Setting";
            this.Load += new System.EventHandler(this.FrmSearchSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSave;
        private Button btnAddSearch;
        public DataGridView dgvSearchList;
    }
}