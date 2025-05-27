using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Lab2.Creational.BuilderExample
{
    public class Cook
    {
        public void MakeBurger(IBurgerBuilder builder)
        {
            builder.AddBun();
            builder.AddPatty();
            builder.AddSauce();
            builder.AddVegetables();
        }
    }
}
