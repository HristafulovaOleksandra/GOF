using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Behavioral.StateExample
{
    public class OpenState : IDoorState
    {
        public void Open(Door door)
        {
            Console.WriteLine("Door is already opened");
        }

        public void Close(Door door)
        {
            Console.WriteLine("Closing the door...");
            door.SetState(new ClosedState());
        }

        public void Lock(Door door)
        {
            Console.WriteLine("You can't lock the opened door");
        }
    }

}
