using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generics;

namespace Torneo
{
    class Torneos
    {
        static void Main(string[] args)
        {

            //Creo los equipos de futbol y torneo de futbol
            EquipoFutbol e1 = new EquipoFutbol("Independiente", new DateTime(1900,03,18));
            EquipoFutbol e2 = new EquipoFutbol("Racing", new DateTime(1890,06,25));
            EquipoFutbol e3 = new EquipoFutbol("Lanus", new DateTime(1875,09,30));
            Torneo<EquipoFutbol> torneoDeFutbol = new Torneo<EquipoFutbol>("copa chica");

            //creo los equiops de basquet y torneo de basquet
            EquipoBasquet eb1 = new EquipoBasquet("San Lorenzo", new DateTime(1970, 02, 05));
            EquipoBasquet eb2 = new EquipoBasquet("Boca", new DateTime(1982, 07, 15));
            EquipoBasquet eb3 = new EquipoBasquet("Temperley", new DateTime(1990, 01, 20));
            Torneo<EquipoBasquet> torneoDeBasquet = new Torneo<EquipoBasquet>("Torneo de Basquet");
            
            //agrego los equipos de futbol al torneo
            torneoDeFutbol += e1;
            torneoDeFutbol += e2;
            torneoDeFutbol += e3;

            //agrego los equipos de basquet al torneo
            torneoDeBasquet += eb1;
            torneoDeBasquet += eb2;
            torneoDeBasquet += eb3;

            //muestro el torneo de futbol y los partidos
            Console.WriteLine(torneoDeFutbol.Mostrar());
            Console.WriteLine(torneoDeFutbol.JugarPartido);
            Console.WriteLine(torneoDeFutbol.JugarPartido);
            Console.WriteLine(torneoDeFutbol.JugarPartido);
            Console.WriteLine();

            //muestro el torneo de basquet y los partidos
            Console.WriteLine(torneoDeBasquet.Mostrar());
            Console.WriteLine(torneoDeBasquet.JugarPartido);
            Console.WriteLine(torneoDeBasquet.JugarPartido);
            Console.WriteLine(torneoDeBasquet.JugarPartido);
            Console.ReadKey();
        }
    }
}
