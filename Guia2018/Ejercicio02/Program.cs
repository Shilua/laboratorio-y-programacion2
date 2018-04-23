using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            string leer;
            double num;
            double cuadrado;
            double cubo;
            Console.Write("Ingrese un numero: ");
            leer = Console.ReadLine();
            if (double.TryParse(leer, out num))
            {
                if (num != 0)
                {
                    cuadrado = Math.Pow(num, 2);
                    cubo = Math.Pow(num, 3);
                    Console.WriteLine("el cuadrado del numero {0} es {1}", num, cuadrado);
                    Console.WriteLine("el cubo del numero {0} es {1}", num, cubo);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Error al ingresar el numero");
                }
            }
        }
    }
}
