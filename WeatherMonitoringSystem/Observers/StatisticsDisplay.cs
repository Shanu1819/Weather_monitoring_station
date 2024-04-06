using System;
using WeatherMonitoringSystem.Interfaces;

namespace WeatherMonitoringSystem.Observers
{
    public class StatisticsDisplay : IDisplay
    {
         private readonly IWeatherData weatherData;
        private List<float> temperatures = new List<float>();

        public StatisticsDisplay(IWeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            float maxTemp = GetMaxTemperature();
            float minTemp = GetMinTemperature();
            float avgTemp = GetAverageTemperature();

            Console.WriteLine("Weather statistics:");
            Console.WriteLine($"Maximum Temperature: {maxTemp}F");
            Console.WriteLine($"Minimum Temperature: {minTemp}F");
            Console.WriteLine($"Average Temperature: {avgTemp}F");
        }

        private float GetMaxTemperature()
        {
            if (temperatures.Count == 0)
                return 0;

            float max = temperatures[0];
            foreach (float temp in temperatures)
            {
                if (temp > max)
                    max = temp;
            }
            return max;
        }

        private float GetMinTemperature()
        {
            if (temperatures.Count == 0)
                return 0;

            float min = temperatures[0];
            foreach (float temp in temperatures)
            {
                if (temp < min)
                    min = temp;
            }
            return min;
        }

        private float GetAverageTemperature()
        {
            if (temperatures.Count == 0)
                return 0;

            float sum = 0;
            foreach (float temp in temperatures)
            {
                sum += temp;
            }
            return sum / temperatures.Count;
        }

        public void Update(float temperature)
        {
            temperatures.Add(temperature);
        }
    }

    }
}
