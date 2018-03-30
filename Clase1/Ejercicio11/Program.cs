using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            string leer;
            int i;
            int min = -100;
            int max = 100;
            int valorMax = 0;
            int valorMin= 0;
            float prom = 0;
            bool validar = true;

            for(i=0; i<10; i++)
            {               
                do
                {
                    if (validar)
                        Console.Write("Ingrese un numero entre el {0} y el {1}: ", min, max);
                    else
                    {
                        Console.Write("Numero ingresado no esta entre los maximos y minimos permitidos reingrese numero: ");
                    }
                    leer = Console.ReadLine();
                    int.TryParse(leer, out valor);
                    validar = Validacion.Validar(valor, min, max);
                } while (!validar);

                if (i == 0)
                {
                    valorMax = valor;
                    valorMin = valor;
                }
                else
                {
                    if (valor > valorMax)
                    {
                        valorMax = valor;
                        prom += valor;
                    }
                    else if (valor < valorMin)
                    {
                        valorMin = valor;
                        prom += valor;
                    }
                }
            }

            prom = prom / 10;
            Console.WriteLine("el numero maximo es {0}, el numero minimo es {1} y el promedio es {2}", valorMax, valorMin, prom);
            Console.ReadKey();

        }
    }
}
