using ChainOfResponsibilityOSILayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityOSILayer.Handalars
{
    class ApplicationLayerHandalar: BaseHandalar
    {
        public override void Process(Request request)
        {
           if(request.Data is OsiLayers layers)
            {
                if(layers is not null && layers.Application is not null)
                {
                    if(layers.Application.Contains("Data"))
                    {
                        request.Message.Add("Encripted");
                    }
                    else { request.Message.Add("Application layer faild"); }
                    
                    if(_handalar is not null)
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
