using System;
using WeatherMonitoringSystem.Interfaces;

namespace WeatherMonitoringSystem.Observers
{
    public class ForecastDisplay : IDisplay
    {
        private readonly IWeatherData weatherData;
        private float currentPressure = 29.92f;
        private float lastPressure;

        public ForecastDisplay(IWeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Weather forecast:");
            if (currentPressure > lastPressure)
            {
                Console.WriteLine("Improving weather on the way!");
            }
            else if (currentPressure == lastPressure)
            {
                Console.WriteLine("More of the same");
            }
            else
            {
                Console.WriteLine("Watch out for cooler, rainy weather");
            }
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            lastPressure = currentPressure;
            currentPressure = pressure;
        }
    }
    }
}
