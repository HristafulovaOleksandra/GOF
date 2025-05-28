using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Behavioral.StateExample
{
    public class ClosedState : IDoorState
    {
        public void Open(Door door)
        {
            Console.WriteLine("Opening the door...");
            door.SetState(new OpenState());
        }

        public void Close(Door door)
        {
            Console.WriteLine("The door is alredy closed.");
        }

        public void Lock(Door door)
        {
            Console.WriteLine("Locking the door...");
            door.SetState(new LockedState());
        }
    }

}
