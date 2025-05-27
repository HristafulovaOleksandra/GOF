using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Lab2.Creational.FactoryExample
{
    public class FactorySalty : Food
    {
        public override string checkFood()
        {
            return "Salty";
        }

    }
}
