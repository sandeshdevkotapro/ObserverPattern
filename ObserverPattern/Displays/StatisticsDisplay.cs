using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    /// <summary>
    /// Generating the maxTemp,minTemp and for average calculation totalSum/numofTimes is done.
    /// </summary>
    internal class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float maxTemp = 0.0f;
        private float minTemp = 1000;
        private float totalSum = 0.0f;
        private int numOfReadings = 0;
        private float humidity;
        private float pressure;
        private ISubject weatherData;

        public StatisticsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine("Avg/Max/M temperature = {0}/{1}/{2}",totalSum/numOfReadings, minTemp,maxTemp);
        }


        public void Update(float temp, float humidity, float pressure)
        {
            totalSum = totalSum + temp;
            numOfReadings++;
            if (temp > maxTemp)
            {
                maxTemp = temp;
            }
            if (temp < minTemp)
            {
                minTemp = temp;
            }
            Display();
        }
    }

}
