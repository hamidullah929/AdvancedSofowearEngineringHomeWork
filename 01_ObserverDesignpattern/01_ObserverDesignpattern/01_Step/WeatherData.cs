using _01_ObserverDesignpattern.contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ObserverDesignpattern._01_Step
{
    class WeatherData : IPublisher
    {

        public string degree;
        public string pressure;
        public List<Isubscriber> subsribers;

        public WeatherData()
        {
            subsribers = new List<Isubscriber>();
        }
        public void notifySubScriber()
        {
            foreach(var item in subsribers)
            {
                item.update(degree,pressure);
            }
        }

        public void registerSubscriber(Isubscriber s)
        {
            subsribers.Add(s);
        }

        public void removeSbscriber(Isubscriber s)
        {
            subsribers.Remove(s);
        }

        public void WeatherMeasurChange()
        {
            notifySubScriber();
        }
        public void setMesurment(string degree, string pressure)
        {
            this.degree = degree;
            this.pressure = pressure;
            WeatherMeasurChange();
        }
    }
}
