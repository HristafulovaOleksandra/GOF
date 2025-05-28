using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Behavioral.CommandExample
{
    public class TurnOnCommand : ICommand
    {
        private Light light;

        public TurnOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.TurnOn();
        }
    }
}
