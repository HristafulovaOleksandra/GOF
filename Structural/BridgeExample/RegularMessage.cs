using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Structural.BridgeExample
{
    public class RegularMessage : Message //abstract message type
    {
        public RegularMessage(IMessageSender sender) : base(sender) { }

        public override void Send(string text)
        {
            sender.SendMessage("Regular: " + text);
        }
    }
}
