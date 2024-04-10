using System;




using Weather.Observer;
using Weather.Observer.Factory;
using Weather.Observer.Interfaces;
using Weather.Observer.Singleton;

namespace Weather.Observer.Observers
{
    /// <summary>
    /// Observer that displays weather statistics (like average, max, and min temperatures).
    /// </summary>
    public class StatisticsDisplay : IDisplay
    {
        private readonly WeatherData weatherData;
         private float maxTemperature;
        private float minTemperature;
        private float totalTemperature;
        private int numReadings;

        public StatisticsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        /// <summary>
        /// Update statistics based on the current weather data.
        /// </summary>
        public void UpdateStatistics()
        {
            float temperature = weatherData.GetTemperature();
            totalTemperature += temperature;
            numReadings++;

            if (temperature > maxTemperature)
            {
                maxTemperature = temperature;
            }

            if (temperature < minTemperature)
            {
                minTemperature = temperature;
            }
        }

        /// <summary>
        /// Display weather statistics.
        /// </summary>
        public void Display()
        {
            UpdateStatistics();
            float averageTemperature = totalTemperature / numReadings;
            Console.WriteLine("Weather Statistics:");
            Console.WriteLine($" *Average Temperature: {averageTemperature}°C");
            Console.WriteLine($" *Max Temperature: {maxTemperature}°C");
            Console.WriteLine($" *Min Temperature: {minTemperature}°C");
           
        }
    }
}
