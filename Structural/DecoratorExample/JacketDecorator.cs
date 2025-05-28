using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Structural.DecoratorExample
{
    public class JacketDecorator : ClothingDecorator
    {
        public JacketDecorator(IClothing clothing) : base(clothing) { }

        public override void Wear()
        {
            base.Wear();
            Console.WriteLine("Putting on a jacket");
        }
    }
}
