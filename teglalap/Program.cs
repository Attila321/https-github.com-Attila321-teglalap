using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teglalap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg a téglalap oldalainak hosszát: ");
            Console.WriteLine("Adja meg A oldalát");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg B oldalát");
            int b = Convert.ToInt32(Console.ReadLine());
            int probalkozasokszama = 0;

            do
            {
                if (probalkozasokszama > 0) ;
                {
                    Console.WriteLine("Eltévesztetted! Add meg az igazit");
                }

            } while (!int.TryParse(Console.ReadLine(), out a));

            Console.WriteLine("terület {0} cm2", a * b); //Terület  
            Console.WriteLine("Kerület {0} cm", 2 * (a + b)); //Kerület

            Console.ReadKey();
        }
    }
}
