using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Structural.DecoratorExample
{
    public abstract class ClothingDecorator : IClothing
    {
        protected IClothing clothing;

        public ClothingDecorator(IClothing clothing)
        {
            this.clothing = clothing;
        }

        public virtual void Wear()
        {
            clothing.Wear(); // delegates a method call to the base outfit
        }
    }
}
