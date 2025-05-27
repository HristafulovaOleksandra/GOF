using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Lab2.Creational
{
    public class Singletone
    {
        private static Singletone singletone = null;

        Singletone()
        { }

        public static Singletone getInstance()
        {
            if (singletone == null)
                singletone = new Singletone();
            return singletone;
        }

        public void catMeow()
        {
            System.Console.WriteLine("MEOW");
        }
    }
}
