using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Trojkat : Figura
    {
        public Trojkat(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        override public void ObliczPole()
        {
            Console.WriteLine("Pole trojkata {0}", a * b / 2);
        }
    }
}
