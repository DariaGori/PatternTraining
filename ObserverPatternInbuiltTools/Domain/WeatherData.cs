namespace ObserverPatternInbuiltTools.Domain
{
    public struct WeatherData
    {
        public WeatherData(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
        }
        
        private float Temperature { get; set; }
        private float Humidity { get; set; }
        private float Pressure { get; set; }
    }
}