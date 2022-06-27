namespace YVDesktop
{
    partial class FrmConfiguration
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxMaxThreads = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxBandwidth = new System.Windows.Forms.ComboBox();
            this.cbxPlaybackSpeed = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxBackground = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxMinThreads = new System.Windows.Forms.TextBox();
            this.tbxMinimum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbxMaximum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxViews = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxDatabase = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxFilename = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxFreePort = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxHost = new System.Windows.Forms.TextBox();
            this.cbxEnableHttp = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxCategoryProxy = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbxRefresh = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbxAuthentication = new System.Windows.Forms.ComboBox();
            this.cbxProxyType = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbxProxyApi = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxMaxThreads);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbxBandwidth);
            this.groupBox1.Controls.Add(this.cbxPlaybackSpeed);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbxBackground);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbxMinThreads);
            this.groupBox1.Controls.Add(this.tbxMinimum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.tbxMaximum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxViews);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxDatabase);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // tbxMaxThreads
            // 
            this.tbxMaxThreads.Location = new System.Drawing.Point(540, 171);
            this.tbxMaxThreads.Name = "tbxMaxThreads";
            this.tbxMaxThreads.Size = new System.Drawing.Size(230, 27);
            this.tbxMaxThreads.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(397, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Maximum Threads";
            // 
            // cbxBandwidth
            // 
            this.cbxBandwidth.FormattingEnabled = true;
            this.cbxBandwidth.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbxBandwidth.Location = new System.Drawing.Point(540, 121);
            this.cbxBandwidth.Name = "cbxBandwidth";
            this.cbxBandwidth.Size = new System.Drawing.Size(230, 28);
            this.cbxBandwidth.TabIndex = 11;
            // 
            // cbxPlaybackSpeed
            // 
            this.cbxPlaybackSpeed.FormattingEnabled = true;
            this.cbxPlaybackSpeed.Items.AddRange(new object[] {
            "Normal(1x)",
            "Slow(random .25x, .5x, .75x)",
            "Fast(random 1.25x, 1.5x, 1.75x)"});
            this.cbxPlaybackSpeed.Location = new System.Drawing.Point(156, 168);
            this.cbxPlaybackSpeed.Name = "cbxPlaybackSpeed";
            this.cbxPlaybackSpeed.Size = new System.Drawing.Size(224, 28);
            this.cbxPlaybackSpeed.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(397, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Save Bandwidth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Playback Speed";
            // 
            // cbxBackground
            // 
            this.cbxBackground.FormattingEnabled = true;
            this.cbxBackground.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbxBackground.Location = new System.Drawing.Point(156, 121);
            this.cbxBackground.Name = "cbxBackground";
            this.cbxBackground.Size = new System.Drawing.Size(224, 28);
            this.cbxBackground.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Background Mode";
            // 
            // tbxMinThreads
            // 
            this.tbxMinThreads.Location = new System.Drawing.Point(156, 212);
            this.tbxMinThreads.Name = "tbxMinThreads";
            this.tbxMinThreads.Size = new System.Drawing.Size(224, 27);
            this.tbxMinThreads.TabIndex = 7;
            // 
            // tbxMinimum
            // 
            this.tbxMinimum.Location = new System.Drawing.Point(156, 72);
            this.tbxMinimum.Name = "tbxMinimum";
            this.tbxMinimum.Size = new System.Drawing.Size(224, 27);
            this.tbxMinimum.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Max Duration Watch";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 215);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(128, 20);
            this.label18.TabIndex = 4;
            this.label18.Text = "Minimum Threads";
            // 
            // tbxMaximum
            // 
            this.tbxMaximum.Location = new System.Drawing.Point(540, 72);
            this.tbxMaximum.Name = "tbxMaximum";
            this.tbxMaximum.Size = new System.Drawing.Size(230, 27);
            this.tbxMaximum.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Min Duration Watch";
            // 
            // tbxViews
            // 
            this.tbxViews.Location = new System.Drawing.Point(540, 23);
            this.tbxViews.Name = "tbxViews";
            this.tbxViews.Size = new System.Drawing.Size(230, 27);
            this.tbxViews.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount of views";
            // 
            // cbxDatabase
            // 
            this.cbxDatabase.FormattingEnabled = true;
            this.cbxDatabase.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbxDatabase.Location = new System.Drawing.Point(156, 22);
            this.cbxDatabase.Name = "cbxDatabase";
            this.cbxDatabase.Size = new System.Drawing.Size(224, 28);
            this.cbxDatabase.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Store to Database";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Filename";
            // 
            // tbxFilename
            // 
            this.tbxFilename.Location = new System.Drawing.Point(156, 75);
            this.tbxFilename.Name = "tbxFilename";
            this.tbxFilename.Size = new System.Drawing.Size(224, 27);
            this.tbxFilename.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxFreePort);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tbxHost);
            this.groupBox2.Controls.Add(this.cbxEnableHttp);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(12, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 125);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HTTP API";
            // 
            // tbxFreePort
            // 
            this.tbxFreePort.Location = new System.Drawing.Point(540, 26);
            this.tbxFreePort.Name = "tbxFreePort";
            this.tbxFreePort.Size = new System.Drawing.Size(230, 27);
            this.tbxFreePort.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(397, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Free Port";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Host";
            // 
            // tbxHost
            // 
            this.tbxHost.Location = new System.Drawing.Point(156, 71);
            this.tbxHost.Name = "tbxHost";
            this.tbxHost.Size = new System.Drawing.Size(224, 27);
            this.tbxHost.TabIndex = 7;
            // 
            // cbxEnableHttp
            // 
            this.cbxEnableHttp.FormattingEnabled = true;
            this.cbxEnableHttp.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbxEnableHttp.Location = new System.Drawing.Point(156, 21);
            this.cbxEnableHttp.Name = "cbxEnableHttp";
            this.cbxEnableHttp.Size = new System.Drawing.Size(224, 28);
            this.cbxEnableHttp.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 20);
            this.label14.TabIndex = 8;
            this.label14.Text = "Enable";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Category";
            // 
            // cbxCategoryProxy
            // 
            this.cbxCategoryProxy.FormattingEnabled = true;
            this.cbxCategoryProxy.Items.AddRange(new object[] {
            "Free",
            "Premium",
            "Rotating proxy"});
            this.cbxCategoryProxy.Location = new System.Drawing.Point(156, 26);
            this.cbxCategoryProxy.Name = "cbxCategoryProxy";
            this.cbxCategoryProxy.Size = new System.Drawing.Size(224, 28);
            this.cbxCategoryProxy.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbxRefresh);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.cbxCategoryProxy);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cbxAuthentication);
            this.groupBox3.Controls.Add(this.cbxProxyType);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.cbxProxyApi);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tbxFilename);
            this.groupBox3.Location = new System.Drawing.Point(12, 406);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 161);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Proxy";
            // 
            // tbxRefresh
            // 
            this.tbxRefresh.Location = new System.Drawing.Point(540, 121);
            this.tbxRefresh.Name = "tbxRefresh";
            this.tbxRefresh.Size = new System.Drawing.Size(230, 27);
            this.tbxRefresh.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(397, 124);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 20);
            this.label17.TabIndex = 10;
            this.label17.Text = "Refresh";
            // 
            // cbxAuthentication
            // 
            this.cbxAuthentication.FormattingEnabled = true;
            this.cbxAuthentication.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbxAuthentication.Location = new System.Drawing.Point(540, 74);
            this.cbxAuthentication.Name = "cbxAuthentication";
            this.cbxAuthentication.Size = new System.Drawing.Size(230, 28);
            this.cbxAuthentication.TabIndex = 11;
            // 
            // cbxProxyType
            // 
            this.cbxProxyType.FormattingEnabled = true;
            this.cbxProxyType.Items.AddRange(new object[] {
            "HTTP",
            "SOCKS4",
            "SOCKS5",
            "ALL"});
            this.cbxProxyType.Location = new System.Drawing.Point(540, 26);
            this.cbxProxyType.Name = "cbxProxyType";
            this.cbxProxyType.Size = new System.Drawing.Size(230, 28);
            this.cbxProxyType.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(397, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 20);
            this.label15.TabIndex = 10;
            this.label15.Text = "Authentication";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(397, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "Proxy Type";
            // 
            // cbxProxyApi
            // 
            this.cbxProxyApi.FormattingEnabled = true;
            this.cbxProxyApi.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbxProxyApi.Location = new System.Drawing.Point(156, 121);
            this.cbxProxyApi.Name = "cbxProxyApi";
            this.cbxProxyApi.Size = new System.Drawing.Size(224, 28);
            this.cbxProxyApi.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 124);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 20);
            this.label16.TabIndex = 8;
            this.label16.Text = "Proxy API";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(694, 573);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(594, 573);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConfiguration";
            this.Text = "FrmConfiguration";
            this.Load += new System.EventHandler(this.FrmConfiguration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cbxDatabase;
        private Label label1;
        private Label label2;
        private TextBox tbxViews;
        private TextBox tbxMaximum;
        private Label label3;
        private Label label4;
        private TextBox tbxMinimum;
        private Label label5;
        private ComboBox cbxBackground;
        private Label label6;
        private ComboBox cbxBandwidth;
        private Label label8;
        private ComboBox cbxPlaybackSpeed;
        private Label label9;
        private Label label7;
        private TextBox tbxMaxThreads;
        private TextBox tbxFilename;
        private GroupBox groupBox2;
        private ComboBox cbxCategoryProxy;
        private Label label10;
        private TextBox tbxFreePort;
        private Label label11;
        private Label label12;
        private TextBox tbxHost;
        private GroupBox groupBox3;
        private ComboBox cbxProxyType;
        private Label label13;
        private Button btnClose;
        private Button btnSave;
        private ComboBox cbxEnableHttp;
        private Label label14;
        private ComboBox cbxAuthentication;
        private Label label15;
        private ComboBox cbxProxyApi;
        private Label label16;
        private TextBox tbxRefresh;
        private Label label17;
        private TextBox tbxMinThreads;
        private Label label18;
    }
}