using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityOSILayer
{
    class OsiLayers
    {
        public string Application { get; set; }
        public string Presentation { get; set; }
        public string Session { get; set; }

        public string Transport { get; set; }
        public string Network { get; set; }
        public string DataLink { get; set; }
        public string Physical { get; set; }
    }
}
