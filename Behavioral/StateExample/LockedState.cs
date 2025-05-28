using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Behavioral.StateExample
{
    public class LockedState : IDoorState
    {
        public void Open(Door door)
        {
            Console.WriteLine("You can't open the door — door is locked!");
        }

        public void Close(Door door)
        {
            Console.WriteLine("The door is already closed and locked.");
        }

        public void Lock(Door door)
        {
            Console.WriteLine("The door is alredy locked.");
        }
    }

}
