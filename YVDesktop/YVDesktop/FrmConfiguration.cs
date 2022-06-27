using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YVDesktop.Model;

namespace YVDesktop
{
    public partial class FrmConfiguration : Form
    {
        public FrmConfiguration()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConfiguration_Load(object sender, EventArgs e)
        {
            var config_json = File.ReadAllText("config.json");
            var config = JsonConvert.DeserializeObject<config_json>(config_json);

            cbxDatabase.SelectedIndex = config!.database ? 0 : 1;
            tbxViews.Text = config.views.ToString();
            tbxMinimum.Text = config.minimum.ToString();
            tbxMaximum.Text = config.maximum.ToString();
            cbxBackground.SelectedIndex = config!.background ? 0 : 1;
            cbxBandwidth.SelectedIndex = config!.bandwidth ? 0 : 1;
            cbxPlaybackSpeed.SelectedIndex = config.playback_speed - 1;
            tbxMaxThreads.Text = config.max_threads.ToString();
            tbxMinThreads.Text = config.min_threads.ToString();

            cbxEnableHttp.SelectedIndex = config.http_api!.enabled ? 0 : 1;
            tbxHost.Text = config.http_api.host;
            tbxFreePort.Text = config.http_api.port.ToString();

            cbxCategoryProxy.SelectedIndex = config.proxy!.category == "f" ? 0 :
                config.proxy!.category == "p" ? 1 : 2;
            cbxProxyType.SelectedIndex = config.proxy!.proxy_type.ToString() == "http" ? 0 :
                config.proxy!.proxy_type.ToString() == "socks4" ? 1 :
                config.proxy!.proxy_type.ToString() == "socks5" ? 2 : 3;
            tbxFilename.Text = config.proxy.filename;
            cbxAuthentication.SelectedIndex = config.proxy.authentication ? 0 : 1;
            cbxProxyApi.SelectedIndex = config.proxy.proxy_api ? 0 : 1;
            tbxRefresh.Text = config.proxy.refresh.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var cf = new config_json();
            cf.database = cbxDatabase.SelectedIndex == 0;
            cf.views = Convert.ToInt32(tbxViews.Text);
            cf.minimum = Convert.ToDecimal(tbxMinimum.Text);
            cf.maximum = Convert.ToDecimal(tbxMaximum.Text);
            cf.background = cbxBackground.SelectedIndex == 0;
            cf.bandwidth = cbxBandwidth.SelectedIndex == 0;
            cf.playback_speed = cbxPlaybackSpeed.SelectedIndex + 1;
            cf.max_threads = Convert.ToInt32(tbxMaxThreads.Text);
            cf.min_threads = Convert.ToInt32(tbxMinThreads.Text);

            var ha = new http_api_json();
            ha.enabled = cbxEnableHttp.SelectedIndex == 0;
            ha.host = tbxHost.Text;
            ha.port = Convert.ToInt32(tbxFreePort.Text);
            cf.http_api = ha;

            var p = new proxy_json();
            p.category = cbxCategoryProxy.SelectedIndex == 0 ? "f" :
                cbxCategoryProxy.SelectedIndex == 1 ? "p" : "r";
            p.proxy_type = cbxProxyType.SelectedIndex == 0 ? "http" :
                cbxProxyType.SelectedIndex == 1 ? "socks4" :
                cbxProxyType.SelectedIndex == 2 ? "socks5" : false;
            p.filename = tbxFilename.Text;
            p.authentication = cbxAuthentication.SelectedIndex == 0;
            p.proxy_api = cbxProxyApi.SelectedIndex == 0;
            p.refresh = Convert.ToDecimal(tbxRefresh.Text);
            cf.proxy = p;

            string fileName = @"config.json";
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
                    var json = JsonConvert.SerializeObject(cf);
                    sw.WriteLine(json);
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
