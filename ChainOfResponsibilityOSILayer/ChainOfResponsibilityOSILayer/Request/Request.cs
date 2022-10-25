using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityOSILayer
{
   sealed class Request
    {
        public Object Data { get; set; }

        public List<string> Message { get; set; }

        public Request()
        {
            Message  = new();
        }
    }
}
