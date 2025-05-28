using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Structural.BridgeExample
{
    public class SMSSender : IMessageSender //accurate sms realization
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Sending SMS: " + message);
        }
    }
}
