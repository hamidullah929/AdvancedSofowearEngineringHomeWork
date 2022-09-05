using _01_ObserverDesignpattern.contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ObserverDesignpattern._01_Step
{
    class LaptopWeather : Isubscriber
    {
        public string degree;
        public string pressure;

        private WeatherData weatherData;

        public LaptopWeather(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerSubscriber(this);
        }
        public void update(string degree, string pressure)
        {
            this.degree = degree;
            this.pressure = pressure;
            Console.WriteLine(degree + " " + pressure);
        }
    }
}
