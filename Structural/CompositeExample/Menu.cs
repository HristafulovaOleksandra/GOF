using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Structural.ComponentExample
{
    public class Menu : IMenuComponent
    {
        private string title;
        private List<IMenuComponent> children = new List<IMenuComponent>();

        public Menu(string title)
        {
            this.title = title;
        }

        public void Add(IMenuComponent component)
        {
            children.Add(component);
        }

        public void Display()
        {
            Console.WriteLine("\nMenu: " + title);
            foreach (var child in children)
            {
                child.Display();
            }
        }
    }
}
