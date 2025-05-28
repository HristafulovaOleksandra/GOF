using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Behavioral.CoRExample
{
    public class LowLevelHandler : Handler
    {
        public override void HandleRequest(int requestLevel)
        {
            if (requestLevel <= 1)
            {
                Console.WriteLine("LowLevelHandler processed the level request " + requestLevel);
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleRequest(requestLevel);
            }
        }
    }
}
