using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Behavioral.TemplateMethodExample
{
    public abstract class Beverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();//заварювати
            PourInCup();
            AddCondiments();//дод приправи
        }

        protected void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        protected void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
        protected abstract void Brew();
        protected abstract void AddCondiments();
    }

}
