using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciobool
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringAux;
            int menuInt;
            int intAux;
            double numero;
            string cadena;
            do
            {
                
                Console.WriteLine("1 - Convertir de Binario a Entero");
                Console.WriteLine("2 - Convertir de Entero a Binario");
                Console.WriteLine("3 - salir");
                stringAux = Console.ReadLine();
                int.TryParse(stringAux,out menuInt);

                switch(menuInt)
                {
                    case 1:
                            Console.WriteLine("Ingrese el numero entero a convertir");
                            stringAux = Console.ReadLine();
                            int.TryParse(stringAux, out intAux);
                            cadena = Clase1.EnteroBinario(intAux);
                            Console.WriteLine("La conversion del numero decimal {0} a binario es : {1}", intAux, cadena);
                        break;
                    case 2:
                            Console.WriteLine("Ingrese el numero binario a convertir");
                            stringAux = Console.ReadLine();
                            numero = Clase1.BinarioDecimal(stringAux);
                            Console.WriteLine("La conversion del numero binario {0} a decimal es : {1}",stringAux, numero);
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Ingrese un numero del 1 al 3");
                        break;
                }
            } while (menuInt != 3);
            Console.WriteLine("salio");
            Console.ReadKey();
        }
    }
}
