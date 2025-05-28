using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Behavioral.ObserverExample 
{
    public class WeatherStation : ISubject //спостережуваний
    {
        private List<IObserver> observers = new List<IObserver>();
        private float temperature;

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void SetTemperature(float newTemp)
        {
            Console.WriteLine($"Temperature changed to: {newTemp}°C");
            temperature = newTemp;
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature);
            }
        }
    }
}
