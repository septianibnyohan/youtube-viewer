namespace YVDesktop
{
    partial class UrlSetting
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
            this.dgvUrlList = new System.Windows.Forms.DataGridView();
            this.btnAddProxy = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrlList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUrlList
            // 
            this.dgvUrlList.AllowUserToAddRows = false;
            this.dgvUrlList.AllowUserToDeleteRows = false;
            this.dgvUrlList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUrlList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrlList.Location = new System.Drawing.Point(12, 48);
            this.dgvUrlList.Name = "dgvUrlList";
            this.dgvUrlList.ReadOnly = true;
            this.dgvUrlList.RowHeadersWidth = 51;
            this.dgvUrlList.RowTemplate.Height = 29;
            this.dgvUrlList.Size = new System.Drawing.Size(776, 390);
            this.dgvUrlList.TabIndex = 1;
            this.dgvUrlList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrlList_CellClick);
            this.dgvUrlList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvUrlList_CellFormatting);
            this.dgvUrlList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvUrlList_CellPainting);
            // 
            // btnAddProxy
            // 
            this.btnAddProxy.Location = new System.Drawing.Point(552, 13);
            this.btnAddProxy.Name = "btnAddProxy";
            this.btnAddProxy.Size = new System.Drawing.Size(115, 29);
            this.btnAddProxy.TabIndex = 2;
            this.btnAddProxy.Text = "Add Url";
            this.btnAddProxy.UseVisualStyleBackColor = true;
            this.btnAddProxy.Click += new System.EventHandler(this.btnAddProxy_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(673, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 29);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // UrlSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddProxy);
            this.Controls.Add(this.dgvUrlList);
            this.Name = "UrlSetting";
            this.Text = "Url Setting";
            this.Load += new System.EventHandler(this.UrlSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrlList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DataGridView dgvUrlList;
        private Button btnAddProxy;
        private Button btnSave;
    }
}