using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
namespace ObserverPattern.Displays
{
    internal class ForecastDisplay : IObserver, IDisplayElement
    {
        /// <summary>
        /// Current pressure is used here used for swapping values and lastPressure is updated  by the CurrentPressure.
        /// </summary>
        private float temperature;
        private float humidity;
        private ISubject weatherData;
        private float currentPressure = 29.92f;
        private float lastPressure;
        public ForecastDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);

        }
        public void Display()
        {

            if(currentPressure > lastPressure)
            {
                Console.WriteLine("Forecast: Improving weather on the way!");
            }
            else if(currentPressure == lastPressure)
            {
                Console.WriteLine("Forecast: More of the same");
            }else if(currentPressure < lastPressure)
            {
                Console.WriteLine("Forecast: Watch out for cooler, rainy weather");
            }
             
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            lastPressure = currentPressure;
            currentPressure = pressure;
            Display();
        }
    }
}
