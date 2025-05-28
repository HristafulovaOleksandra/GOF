using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Behavioral.CoRExample
{
    public class MediumLevelHandler : Handler
    {
        public override void HandleRequest(int requestLevel)
        {
            if (requestLevel == 2)
            {
                Console.WriteLine("MediumLevelHandler processed the level request " + requestLevel);
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleRequest(requestLevel);
            }
        }
    }
}
