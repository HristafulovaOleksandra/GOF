using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Behavioral.CommandExample
{
    public class TurnOffCommand : ICommand
    {
        private Light light;

        public TurnOffCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.TurnOff();
        }
    }
}
