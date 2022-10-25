using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityOSILayer.Contracts
{
    class BaseHandalar : IHandalar
    {
       protected IHandalar _handalar;

        public BaseHandalar()
        {
            _handalar = null;
        }
        public virtual void Process(Request request)
        {
            throw new NotImplementedException();
        }

        public void SetNextHandalar(IHandalar handalar)
        {
            _handalar = handalar;
        }
    }
}
