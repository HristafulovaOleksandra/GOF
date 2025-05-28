using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Behavioral.ObserverExample
{
    public class PhoneDisplay : IObserver //спостерігач
    {
        public void Update(float temperature)
        {
            Console.WriteLine($"Phone Display: Temperature is now {temperature}°C");
        }
    }
}
