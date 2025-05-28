using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Behavioral.CoRExample
{
    public abstract class Handler//обробник
    {
        protected Handler nextHandler;

        public void SetNext(Handler handler)
        {
            nextHandler = handler;
        }

        public abstract void HandleRequest(int requestLevel);
    }
}
