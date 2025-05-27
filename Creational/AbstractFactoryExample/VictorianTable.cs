using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Lab2.Creational.AbstractFactoryExample
{
    public class VictorianTable : ITable
    {
        public void PutOn()
        {
            Console.WriteLine("You put something on a Victorian table.");
        }
    }
}
