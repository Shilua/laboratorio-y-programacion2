using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            string leer;
            int numaux;
            int i, j, k;
            Console.Write("Ingrese un numero positivo: ");
            leer = Console.ReadLine();
            if (int.TryParse(leer, out numaux))
            {
                for (i = 0; i < numaux*2; i+=2)
                {
                    
                    for(j = i; j < i+1; j++)
                    {
                        for (k = i; k<numaux-1 ; k--)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
