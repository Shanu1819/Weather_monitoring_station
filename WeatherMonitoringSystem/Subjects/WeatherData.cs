using System;
using System.Collections.Generic;
using WeatherMonitoringSystem.Interfaces;

namespace WeatherMonitoringSystem.ConcreteSubjects
{
    public class WeatherData : IWeatherData
    {
       private static WeatherData instance;
        private List<IDisplay> observers = new List<IDisplay>();
        private float temperature;
        private float humidity;
        private float pressure;
        private readonly Random random = new Random();

        // Private constructor to prevent direct instantiation
        private WeatherData() { }

        // Singleton instance accessor
        public static WeatherData GetInstance()
        {
            if (instance == null)
            {
                instance = new WeatherData();
            }
            return instance;
        }
    }
}
