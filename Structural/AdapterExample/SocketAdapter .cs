using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Structural.AdapterExample
{
    public class SocketAdapter : IAmericanSocket
    {
        private EuropeanPlug europeanPlug;

        public SocketAdapter(EuropeanPlug europeanPlug)
        {
            this.europeanPlug = europeanPlug;
        }

        public void PlugInAmerican()
        {
            Console.WriteLine("Adapter is using...");
            europeanPlug.PlugInEuropean();
        }
    }
}
