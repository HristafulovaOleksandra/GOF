using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Behavioral.StateExample
{
    public interface IDoorState
    {
        void Open(Door door);
        void Close(Door door);
        void Lock(Door door);
    }

}
