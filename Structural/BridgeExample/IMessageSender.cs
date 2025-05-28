using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Structural.BridgeExample
{
    public interface IMessageSender //realization , send channel
    {
        void SendMessage(string message);
    }
}
