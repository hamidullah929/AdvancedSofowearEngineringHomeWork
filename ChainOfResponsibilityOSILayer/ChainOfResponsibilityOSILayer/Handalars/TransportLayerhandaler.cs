using ChainOfResponsibilityOSILayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityOSILayer.Handalars
{
    class TransportLayerhandaler: BaseHandalar
    {
        public override void Process(Request request)
        {
            if (request.Data is OsiLayers layers)
            {
                if (layers is not null && layers.Transport is not null)
                {
                    if (layers.Transport.Contains("SH PH AH Data"))
                    {
                        request.Message.Add("TH SH PH AH Data");
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
