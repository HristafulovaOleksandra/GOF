using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Behavioral.ObserverExample
{
    public interface IObserver
    {
        void Update(float temperature);
    }
}
