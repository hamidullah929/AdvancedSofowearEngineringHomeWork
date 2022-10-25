using ChainOfResponsibilityOSILayer.Handalars;
using System;

namespace ChainOfResponsibilityOSILayer
{
    class Program
    {
        static void Main(string[] args)
        {
            var osilyaer = new OsiLayers
            {
                Application = "Data",
                Presentation = "AH Data",
                Session = "PH AH Data",
                Transport = "SH PH AH Data",
                Network = "TH SH PH AH Data",
                DataLink = "NH TH SH PH AH Data",
                Physical = "DH NH TH SH PH AH Data",
            };

            var request = new Request
            {
                Data = osilyaer,
            };

            ApplicationLayerHandalar applicationLayerHandalar = new();
            PresentationLayerHandalare presentationLayerHandalare = new();
            SessionLayerHandaler sessionLayerHandaler = new();
            TransportLayerhandaler transportLayerhandaler = new();
            NetworkLayerhandaler networkLayerhandaler = new();
            DatalinkLayerHandaler datalinkLayerHandaler = new();
            PhysicalLayerHandaler physicalLayerHandaler = new();

            applicationLayerHandalar.SetNextHandalar(presentationLayerHandalare);
            presentationLayerHandalare.SetNextHandalar(sessionLayerHandaler);
            sessionLayerHandaler.SetNextHandalar(transportLayerhandaler);
            transportLayerhandaler.SetNextHandalar(networkLayerhandaler);
            networkLayerhandaler.SetNextHandalar(datalinkLayerHandaler);
            datalinkLayerHandaler.SetNextHandalar(physicalLayerHandaler);

            applicationLayerHandalar.Process(request);

            foreach (var item in request.Message)
            {
                Console.WriteLine(item);
            }


        }
    }
}
