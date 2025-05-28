using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Behavioral.CommandExample
{
    public class RemoteControl //initiator
    {
        private ICommand command;

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void PressButton()
        {
            command.Execute();
        }
    }
}
