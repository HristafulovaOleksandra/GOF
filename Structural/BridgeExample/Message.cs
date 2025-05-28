using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Structural.BridgeExample
{
    public abstract class Message
    {
        protected IMessageSender sender; //bridge

        public Message(IMessageSender sender)
        {
            this.sender = sender;
        }

        public abstract void Send(string text);
    }
}
