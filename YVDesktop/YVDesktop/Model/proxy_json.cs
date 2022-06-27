using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YVDesktop.Model
{
    internal class proxy_json
    {
        public string? category { get; set; }
        public dynamic proxy_type { get; set; }
        public string? filename { get; set; }
        public bool authentication { get; set; }
        public bool proxy_api { get; set; }
        public decimal refresh { get; set; }
    }
}
