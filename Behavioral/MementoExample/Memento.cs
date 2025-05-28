using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Behavioral.MementoExample
{
    public class Memento
    {
        public string Text { get; }

        public Memento(string text)
        {
            Text = text;
        }
    }

}
