using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Structural.DecoratorExample
{
    public class ScarfDecorator : ClothingDecorator
    {
        public ScarfDecorator(IClothing clothing) : base(clothing) { }

        public override void Wear()
        {
            base.Wear();
            Console.WriteLine("Adding a scarf");
        }
    }
}
