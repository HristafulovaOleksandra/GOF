using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Lab2.Creational.BuilderExample
{
    public class Burger
    {
        private List<string> ingredients = new List<string>();

        public void AddIngredient(string ingredient)
        {
            ingredients.Add(ingredient);
        }

        public void Show()
        {
            Console.WriteLine("Burger contains: " + string.Join(", ", ingredients));
        }
    }

}
