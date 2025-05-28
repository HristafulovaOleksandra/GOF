using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Behavioral.MementoExample
{
    public class EditorHistory //save snapshots
    {
        private Stack<Memento> _history = new Stack<Memento>();

        public void Save(Memento memento)
        {
            _history.Push(memento);
        }

        public Memento Undo()
        {
            return _history.Pop();
        }
    }

}
