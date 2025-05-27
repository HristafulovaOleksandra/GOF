using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Lab2.Creational.AbstractFactoryExample
{
    public class ModernChair : IChair
    {
        public void SitOn()
        {
            Console.WriteLine("You sit on a modern chair.");
        }
    }
}
