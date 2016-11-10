using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Kwadrat : Figura
    {
        public Kwadrat(double a)
        {
            this.a = a;
        }

        override public void ObliczPole()
        {
            Console.WriteLine("Pole kwadratu {0}", a * a);
        }
    }
}
