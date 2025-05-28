using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Behavioral.VisitorExample
{
    public class Tourist : IVisitor
    {
        public void Visit(Painting painting)
        {
            Console.WriteLine($"Tourist is looking at the painting: {painting.Title}");
        }

        public void Visit(Sculpture sculpture)
        {
            Console.WriteLine($"Tourist is taking a photo of {sculpture.Material} sculpture");
        }
    }

}
