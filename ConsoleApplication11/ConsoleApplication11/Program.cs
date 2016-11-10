using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            Kwadrat k1 = new Kwadrat(3);
            k1.ObliczPole();
            Trojkat t1 = new Trojkat(3, 4);
            t1.ObliczPole();

            Console.ReadKey();

            List<Figura> figury = new List<Figura>();
            figury.Add(new Kwadrat(5));
            figury.Add(new Trojkat(5,3));
            figury.Add(new Kwadrat(7));
            figury.Add(new Trojkat(1, 12));

            foreach(var element in figury)
            {
                element.ObliczPole();
            }

            Console.ReadKey();

        }
    }
}
