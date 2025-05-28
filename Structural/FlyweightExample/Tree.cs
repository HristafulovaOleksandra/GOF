using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Structural.FlyweightExample
{
    public class Tree
    {
        private int _x, _y;
        private TreeType _type;

        public Tree(int x, int y, TreeType type)
        {
            _x = x;
            _y = y;
            _type = type;
        }

        public void Draw()
        {
            _type.Draw(_x, _y);
        }
    }

}
