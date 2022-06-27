namespace YVDesktop
{
    partial class ProxySetting
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
            this.dgvProxyList = new System.Windows.Forms.DataGridView();
            this.btnAddProxy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProxyList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProxyList
            // 
            this.dgvProxyList.AllowUserToAddRows = false;
            this.dgvProxyList.AllowUserToDeleteRows = false;
            this.dgvProxyList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProxyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProxyList.Location = new System.Drawing.Point(12, 48);
            this.dgvProxyList.Name = "dgvProxyList";
            this.dgvProxyList.ReadOnly = true;
            this.dgvProxyList.RowHeadersWidth = 51;
            this.dgvProxyList.RowTemplate.Height = 29;
            this.dgvProxyList.Size = new System.Drawing.Size(776, 390);
            this.dgvProxyList.TabIndex = 0;
            // 
            // btnAddProxy
            // 
            this.btnAddProxy.Location = new System.Drawing.Point(673, 13);
            this.btnAddProxy.Name = "btnAddProxy";
            this.btnAddProxy.Size = new System.Drawing.Size(115, 29);
            this.btnAddProxy.TabIndex = 1;
            this.btnAddProxy.Text = "Modify Proxy";
            this.btnAddProxy.UseVisualStyleBackColor = true;
            this.btnAddProxy.Click += new System.EventHandler(this.btnAddProxy_Click);
            // 
            // ProxySetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddProxy);
            this.Controls.Add(this.dgvProxyList);
            this.Name = "ProxySetting";
            this.Text = "Proxy Setting";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProxySetting_FormClosed);
            this.Load += new System.EventHandler(this.ProxySetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProxyList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvProxyList;
        private Button btnAddProxy;
    }
}