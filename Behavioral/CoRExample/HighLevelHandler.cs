using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Behavioral.CoRExample
{
    public class HighLevelHandler : Handler
    {
        public override void HandleRequest(int requestLevel)
        {
            if (requestLevel >= 3)
            {
                Console.WriteLine("HighLevelHandler processed the level request " + requestLevel);
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleRequest(requestLevel);
            }
        }
    }
}
