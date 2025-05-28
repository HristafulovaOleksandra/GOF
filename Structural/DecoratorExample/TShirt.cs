using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Structural.DecoratorExample
{
    public class TShirt : IClothing
    {
        public void Wear()
        {
            Console.WriteLine("Wearing a T-Shirt");
        }
    }

}
