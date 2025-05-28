using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Behavioral.VisitorExample
{
    public class Restorer : IVisitor
    {
        public void Visit(Painting painting)
        {
            Console.WriteLine($"Restorer is checking the painting's state : {painting.Title}");
        }

        public void Visit(Sculpture sculpture)
        {
            Console.WriteLine($"Restorer is cleaning the {sculpture.Material} sculpture");
        }
    }

}
