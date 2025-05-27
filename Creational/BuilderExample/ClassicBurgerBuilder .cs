using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Lab2.Creational.BuilderExample
{
    public class ClassicBurgerBuilder : IBurgerBuilder
    {
        private Burger burger = new Burger();

        public void AddBun() => burger.AddIngredient("White Bun");
        public void AddPatty() => burger.AddIngredient("Beef Patty");
        public void AddSauce() => burger.AddIngredient("Ketchup");
        public void AddVegetables() => burger.AddIngredient("Lettuce & Tomato");

        public Burger GetBurger() => burger;
    }

}
