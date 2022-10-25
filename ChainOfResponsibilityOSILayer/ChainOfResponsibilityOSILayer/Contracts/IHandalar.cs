using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityOSILayer.Contracts
{
    interface IHandalar
    {
        public void Process(Request request);

        public void SetNextHandalar(IHandalar handalar);
    }
}
