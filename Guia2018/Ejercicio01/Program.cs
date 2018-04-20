using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string auxString;
            int auxInt;
            int valorMax = int.MinValue;
            int valorMin = int.MaxValue;
            int acum = 0;
            float prom;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero");
                auxString = Console.ReadLine();
                int.TryParse(auxString, out auxInt);

                if (auxInt > valorMax)
                {
                    valorMax = auxInt;
                    acum += auxInt;
                }
                else if (auxInt < valorMin)
                {
                    valorMin = auxInt;
                    acum += auxInt;
                }

            }
            prom = (float)acum / 5;
            Console.WriteLine("el numero maximo es {0}", valorMax);
            Console.WriteLine("el numero minimo es {0}", valorMin);
            Console.WriteLine("el promedio es {0}", prom);
            Console.ReadKey();
        }
    }
}
