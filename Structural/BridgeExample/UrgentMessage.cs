using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Structural.BridgeExample
{
    public class UrgentMessage : Message //abstract message type
    {
        public UrgentMessage(IMessageSender sender) : base(sender) { }

        public override void Send(string text)
        {
            sender.SendMessage("URGENT: " + text.ToUpper());
        }
    }
}
