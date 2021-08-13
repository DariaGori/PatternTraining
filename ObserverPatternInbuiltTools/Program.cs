using ObserverPatternInbuiltTools.Domain;

namespace ObserverPatternInbuiltTools
{
    class Program
    {
        static void Main(string[] args)
        {
            var tracker = new WeatherDataTracker();
            var display = new CurrentConditionsDisplay();
            
            display.Subscribe(tracker);
            
            tracker.TrackWeatherData(new WeatherData(23.4f, 78.4f, 84.2f));
            tracker.TrackWeatherData(null);
            
            tracker.EndTransmission();
        }
    }
}