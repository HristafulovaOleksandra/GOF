using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Structural.FlyweightExample
{
    public class TreeFactory
    {
        private static Dictionary<string, TreeType> _treeTypes = new Dictionary<string, TreeType>();

        public static TreeType GetTreeType(string name, string color) //one object TreeType for one pair
        {
            string key = name + "_" + color;
            if (!_treeTypes.ContainsKey(key))
            {
                _treeTypes[key] = new TreeType(name, color);
            }
            return _treeTypes[key];
        }
    }
}
