namespace YVDesktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbProxySetting = new System.Windows.Forms.ToolStripButton();
            this.tsbUrl = new System.Windows.Forms.ToolStripButton();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tbConfig = new System.Windows.Forms.ToolStripButton();
            this.btnRun = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbProxySetting,
            this.tsbUrl,
            this.tsbSearch,
            this.tbConfig});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 47);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbProxySetting
            // 
            this.tsbProxySetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbProxySetting.Image = ((System.Drawing.Image)(resources.GetObject("tsbProxySetting.Image")));
            this.tsbProxySetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProxySetting.Name = "tsbProxySetting";
            this.tsbProxySetting.Size = new System.Drawing.Size(44, 44);
            this.tsbProxySetting.Text = "Proxy Setting";
            this.tsbProxySetting.Click += new System.EventHandler(this.tsbProxySetting_Click);
            // 
            // tsbUrl
            // 
            this.tsbUrl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUrl.Image = ((System.Drawing.Image)(resources.GetObject("tsbUrl.Image")));
            this.tsbUrl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUrl.Name = "tsbUrl";
            this.tsbUrl.Size = new System.Drawing.Size(44, 44);
            this.tsbUrl.Text = "Url Setting";
            this.tsbUrl.Click += new System.EventHandler(this.tsbUrl_Click);
            // 
            // tsbSearch
            // 
            this.tsbSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearch.Image")));
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(44, 44);
            this.tsbSearch.Text = "Search Setting";
            this.tsbSearch.Click += new System.EventHandler(this.tsbSearch_Click);
            // 
            // tbConfig
            // 
            this.tbConfig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbConfig.Image = ((System.Drawing.Image)(resources.GetObject("tbConfig.Image")));
            this.tbConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbConfig.Name = "tbConfig";
            this.tbConfig.Size = new System.Drawing.Size(44, 44);
            this.tbConfig.Text = "Configuration";
            this.tbConfig.Click += new System.EventHandler(this.tbConfig_Click);
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Image = ((System.Drawing.Image)(resources.GetObject("btnRun.Image")));
            this.btnRun.Location = new System.Drawing.Point(304, 130);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(170, 170);
            this.btnRun.TabIndex = 1;
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Youtube Viewer";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbProxySetting;
        private ToolStripButton tsbUrl;
        private ToolStripButton tsbSearch;
        private ToolStripButton tbConfig;
        private Button btnRun;
    }
}