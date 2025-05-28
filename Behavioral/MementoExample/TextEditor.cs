using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Behavioral.MementoExample
{
    public class TextEditor //creates and restores snapshots
    {
        private string _text;

        public void Write(string text)
        {
            _text = text;
            Console.WriteLine("Current text: " + _text);
        }

        public Memento Save()
        {
            return new Memento(_text);
        }

        public void Restore(Memento memento)
        {
            _text = memento.Text;
            Console.WriteLine("Restore text: " + _text);
        }
    }

}
