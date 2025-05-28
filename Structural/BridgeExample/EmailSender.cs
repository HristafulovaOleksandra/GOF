using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Structural.BridgeExample
{
    public class EmailSender : IMessageSender //accurate email realization
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Sending Email: " + message);
        }
    }

}
