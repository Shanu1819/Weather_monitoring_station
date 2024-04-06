using System;
using WeatherMonitoringSystem.Interfaces;

namespace WeatherMonitoringSystem.Factory
{
    public class WeatherStation
    {
        private readonly IWeatherData weatherData;

        public WeatherStation(IWeatherData weatherData)
        {
            this.weatherData = weatherData;
        }

        public IDisplay CreateDisplay(string displayType)
        {
            switch (displayType.ToLower())
            {
                case "currentconditions":
                    return new CurrentConditionsDisplay(weatherData);
                case "statistics":
                    return new StatisticsDisplay(weatherData);
                case "forecast":
                    return new ForecastDisplay(weatherData);
                default:
                    throw new ArgumentException("Invalid display type");
            }
        }
    }
}
