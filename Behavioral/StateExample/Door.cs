using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Behavioral.StateExample
{
    public class Door
    {
        private IDoorState state;

        public Door(IDoorState initialState) //starter state
        {
            state = initialState;
        }

        public void SetState(IDoorState newState)
        {
            state = newState;
        }

        public void Open()
        {
            state.Open(this);
        }

        public void Close()
        {
            state.Close(this);
        }

        public void Lock()
        {
            state.Lock(this);
        }
    }

}
