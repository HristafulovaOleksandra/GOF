using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Behavioral.ObserverExample
{
    public class WindowDisplay : IObserver //спостерігач
    {
        public void Update(float temperature)
        {
            Console.WriteLine($"Window Display: Current temp is {temperature}°C");
        }
    }
}
