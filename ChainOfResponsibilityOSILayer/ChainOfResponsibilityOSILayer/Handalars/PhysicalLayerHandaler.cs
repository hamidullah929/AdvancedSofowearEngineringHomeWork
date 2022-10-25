using ChainOfResponsibilityOSILayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityOSILayer.Handalars
{
    class PhysicalLayerHandaler: BaseHandalar
    {
        public override void Process(Request request)
        {
            if (request.Data is OsiLayers layers)
            {
                if (layers is not null && layers.Physical is not null)
                {
                    if (layers.Physical.Contains("NH TH SH PH AH Data"))
                    {
                        request.Message.Add("Transfer");
                    }
                    else { request.Message.Add("Application layer faild"); }

                    if (_handalar is not null)
                    {
                        _handalar.Process(request);
                    }
                }
            }
            else
            {
                throw new Exception("Object is Null");
            }
        }
    }
}
