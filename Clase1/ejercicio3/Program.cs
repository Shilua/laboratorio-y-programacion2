using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int j;
            int i;
            string leer;
            Console.Write("Ingrese un numero: ");
            leer = Console.ReadLine();
            int.TryParse(leer, out num);
            for (i = 2; i <= num; i++)
            {
                
                   for ( j = 2; j < i; j++)
                    {
                        if (i%j == 0)
                        {   
                            break;
                        }
                   }
                    if(j == i)
                    Console.WriteLine("{0}",i);
            }
            Console.ReadKey();
        }
    }
}
