using System;
using Weather.Observer;
using Weather.Observer.Factory;
using Weather.Observer.Interfaces;
using Weather.Observer.Singleton;
using Weather.Observer.Observers;

namespace WeatherMonitoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create WeatherData singleton instance
            WeatherData weatherData = WeatherData.GetInstance();

            // Create WeatherStation factory instance
            WeatherStation weatherStation = new WeatherStation(weatherData);

            // Create different displays using the factory
            IDisplay currentConditionsDisplay = weatherStation.CreateDisplay("currentconditions");
            IDisplay statisticsDisplay = weatherStation.CreateDisplay("statistics");
            IDisplay forecastDisplay = weatherStation.CreateDisplay("forecast");

            // Simulate weather data change
                weatherData.SetMeasurements(GetRandomTemperature(), GetRandomHumidity(), GetRandomPressure());

                
            
        }

        // Helper method to get random temperature for simulation
        static float GetRandomTemperature()
        {
            Random random = new Random();
            return (float)(random.NextDouble() * (100 - 0) + 0); // Simulate temperature between 0 and 100 degrees Fahrenheit
        }

        // Helper method to get random humidity for simulation
        static float GetRandomHumidity()
        {
            Random rand = new Random();
            return (float)(rand.NextDouble() * (100 - 0) + 0); // Simulate humidity between 0% and 100%
        }

        // Helper method to get random pressure for simulation
        static float GetRandomPressure()
        {
            Random rand = new Random();
            return (float)(rand.NextDouble() * (1050 - 950) + 950); // Simulate pressure between 950 and 1050 hPa
        }
    }
}
