using System;
using _01_ObserverDesignpattern._01_Step;

namespace _01_ObserverDesignpattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var WeatherData = new WeatherData();

            MobileWeather mobileWeather = new MobileWeather(WeatherData);
            LaptopWeather laptopWeather = new LaptopWeather(WeatherData);
            WeatherData.setMesurment("12", "34");
        }
    }
}
