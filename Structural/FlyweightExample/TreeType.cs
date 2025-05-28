using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Structural.FlyweightExample
{
    public class TreeType
    {
        public string Name { get; }
        public string Color { get; }

        public TreeType(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public void Draw(int x, int y)
        {
            Console.WriteLine($"Draw a tree '{Name}' color {Color} in ({x}, {y})");
        }
    }
}
