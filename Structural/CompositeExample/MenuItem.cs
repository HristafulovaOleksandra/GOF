using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Structural.ComponentExample
{
    public class MenuItem : IMenuComponent //leaf
    {
        private string name;

        public MenuItem(string name)
        {
            this.name = name;
        }

        public void Display()
        {
            Console.WriteLine("Meal: " + name);
        }
    }
}
