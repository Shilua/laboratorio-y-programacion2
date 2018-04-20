using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace lt_clase8_ex34
{
   class Program 
    {
        static void Main(string[] args)
        {
            Camion c = new Camion(8,2,Lib.Colores.Gris,4);
            Automovil a = new Automovil(4, 4, Lib.Colores.Rojo, 6);
            Moto m = new Moto(2,0,Lib.Colores.Negro,5);


            Console.WriteLine("CAMION");
            Console.WriteLine("Cantidad de Ruedas: {0}" ,c.cantidadDeRuedas);
            Console.WriteLine("Cantidad de Puertas: {0}" ,c.cantidadDePuertas);
            Console.WriteLine("Color: {0}", c.color);
            Console.WriteLine("Cantidad de Marchas: {0} ",c.cantidadDeMarchas);
            Console.WriteLine("Peso de Carga {0}" ,c.pesoCarga);
            Console.WriteLine("\n---------------\n");
            Console.WriteLine("AUTOMOVIL");
            Console.WriteLine("Cantidad de Ruedas: {0}" ,a.cantidadDeRuedas);
            Console.WriteLine("Cantidad de Puertas: {0}" ,a.cantidadDePuertas);
            Console.WriteLine("Color: {0}", a.color);
            Console.WriteLine("Cantidad de Marchas: {0} ",a.cantidadDeMarchas);
            Console.WriteLine("Cantidad de Pasajeros {0}" ,a.cantidadPasajeros);
            Console.WriteLine("\n---------------\n");
            Console.WriteLine("MOTO");
            Console.WriteLine("Cantidad de Ruedas: {0}" ,m.cantidadDeRuedas);
            Console.WriteLine("Cantidad de Puertas: {0}" ,m.cantidadDePuertas);
            Console.WriteLine("Color: {0}", m.color);
            Console.WriteLine("Cilindradas:  {0}" ,m.cilindradas);

            Console.ReadKey();
        }
    }
}
