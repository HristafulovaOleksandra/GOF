using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Lab2.Creational.BuilderExample
{
    public class VeggieBurgerBuilder : IBurgerBuilder
    {
        private Burger burger = new Burger();

        public void AddBun() => burger.AddIngredient("Whole Grain Bun");
        public void AddPatty() => burger.AddIngredient("Veggie Patty");
        public void AddSauce() => burger.AddIngredient("Vegan Mayo");
        public void AddVegetables() => burger.AddIngredient("Lettuce, Tomato, Cucumber");

        public Burger GetBurger() => burger;
    }
}
