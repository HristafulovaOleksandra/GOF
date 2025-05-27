using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Lab2.Creational.PrototypeExample
{
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle() { }
        public Rectangle(Rectangle source) : base(source)
        {
            Width = source.Width;
            Height = source.Height;
        }
        public override Shape Clone()
        {
            return new Rectangle(this);
        }
        public void Show()
        {
            Console.WriteLine($"Rectangle: X={X}, Y={Y}, Color={Color}, Width={Width}, Height={Height}");
        }
    }
    }
