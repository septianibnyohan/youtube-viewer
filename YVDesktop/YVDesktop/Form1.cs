using System.Diagnostics;

namespace YVDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            RunStatus = false;
            InitializeComponent();
        }

        private bool RunStatus {get;set;}
        private System.Diagnostics.Process ProgramProcess { get; set; }

        private void tsbProxySetting_Click(object sender, EventArgs e)
        {
            var proxy_setting_form = new ProxySetting(this);
            this.Enabled = false;
            proxy_setting_form.Show();
        }

        private void tsbUrl_Click(object sender, EventArgs e)
        {
            var url_setting_form = new UrlSetting();
            url_setting_form.ShowDialog();
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            var search_setting_form = new FrmSearchSetting();
            search_setting_form.ShowDialog();
        }

        private void tbConfig_Click(object sender, EventArgs e)
        {
            var frm_config = new FrmConfiguration();
            frm_config.ShowDialog();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            RunStatus = !RunStatus;

            if (RunStatus)
            {
                ProgramProcess = System.Diagnostics.Process.Start("youtube_viewer.exe");
                //process.WaitForExit();
                btnRun.Image = YVDesktop.Properties.Resources.stop;
            }
            else
            {
                //var kill_process = System.Diagnostics.Process.Start("killdrive.bat");
                //kill_process.WaitForExit();
                //ProgramProcess.Kill();

                var kill_process1 = System.Diagnostics.Process.Start("taskkill", "/F /IM chrome.exe");
                kill_process1.WaitForExit();

                var kill_process2 = System.Diagnostics.Process.Start("taskkill", "/F /IM chromedriver.exe");
                kill_process2.WaitForExit();

                ProgramProcess.Kill();

                Process[] workers = Process.GetProcessesByName("youtube_viewer");
                foreach (Process worker in workers)
                {
                    worker.Kill();
                    worker.WaitForExit();
                    worker.Dispose();
                }

                btnRun.Image = YVDesktop.Properties.Resources.play;
            }
            

            //var process = System.Diagnostics.Process.Start("proxy_check.exe", "100 px.txt");
            //process.WaitForExit();
        }
    }
}