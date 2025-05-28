using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Lab2.Creational.PrototypeExample
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle() { }

        public Circle(Circle source) : base(source) // it first calls the copy constructor of its base class
        {
            Radius = source.Radius;
        }
        public override Shape Clone()
        {
            return new Circle(this);
        }
        public void Show()
        {
            Console.WriteLine($"Circle: X={X}, Y={Y}, Color={Color}, Radius={Radius}");
        }
    }
}
