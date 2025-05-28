using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Behavioral.VisitorExample
{
    public class Sculpture : IExhibit
    {
        public string Material { get; set; }

        public Sculpture(string material)
        {
            Material = material;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

}
