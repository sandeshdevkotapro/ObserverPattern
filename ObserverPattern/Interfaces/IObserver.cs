using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Interfaces
{
    internal interface IObserver
    {
        /// <summary>
        /// This is used to update all the registered Observers. 
        /// +
        /// </summary>
        /// <param name="temp"></param>
        /// <param name="humidity"></param>
        /// <param name="pressure"></param>
        void Update(float temp,float humidity,float pressure);
    }
}
