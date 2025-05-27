using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Lab2.Creational.AbstractFactoryExample
{
    public class VictorianFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new VictorianChair();
        }

        public ITable CreateTable()
        {
            return new VictorianTable();
        }
    }
}
