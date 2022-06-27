using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YVDesktop.Model
{
    internal class config_json
    {
        public http_api_json? http_api { get; set; }
        public proxy_json? proxy { get; set; }
        public bool database { get; set; }
        public int views { get; set; }
        public decimal minimum { get; set; }
        public decimal maximum { get; set; }
        public bool background { get; set; }
        public bool bandwidth { get; set; }
        public int playback_speed { get; set; }
        public int max_threads { get; set; }
        public int min_threads { get; set; }
    }
}
