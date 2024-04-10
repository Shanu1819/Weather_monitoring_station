using System;
using Weather.Observer;

using Weather.Observer.Interfaces;
using Weather.Observer.Singleton;
using Weather.Observer.Observers;

namespace Weather.Observer.Factory
{
    /// <summary>
    /// Factory for creating different types of displays.
    /// </summary>
    public class WeatherStation
    {
        private readonly WeatherData weatherData;

        public WeatherStation(WeatherData weatherData)
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
                    throw new ArgumentException("Invalid display type.");
            }
        }
    }
}
