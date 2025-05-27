using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Lab2.Creational.AbstractFactoryExample
{
    public interface IFurnitureFactory
    {
        IChair CreateChair();
        ITable CreateTable();
    }
}
