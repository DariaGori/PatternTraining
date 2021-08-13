using System;

namespace ObserverPatternInbuiltTools.Exception
{
    public class WeatherDataUnknownException : System.Exception
    {
        public WeatherDataUnknownException()
        {
            Console.WriteLine("Weather data is not present!");
        }
    }
}