using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Lab2.Creational.BuilderExample
{
    public interface IBurgerBuilder
    {
        void AddBun();
        void AddPatty();
        void AddSauce();
        void AddVegetables();
        Burger GetBurger();
    }
}
