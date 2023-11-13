using ObserverPattern.Displays;
using System;

namespace ObserverPattern
{
    public class WeatherStationProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Weather Station ready!");
            Console.WriteLine();
;

            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);


            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);


        }
    }
}