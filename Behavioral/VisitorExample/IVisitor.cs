﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Behavioral.VisitorExample
{
    public interface IVisitor
    {
        void Visit(Painting painting);
        void Visit(Sculpture sculpture);
    }

}
