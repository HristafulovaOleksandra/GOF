using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Behavioral.VisitorExample
{
    public class Painting : IExhibit
    {
        public string Title { get; set; }

        public Painting(string title)
        {
            Title = title;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

}
