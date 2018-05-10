using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre1 = "juan";
            string apellido1 = "perez";
            string nombre2 = "pedro";
            string apellido2 = "lopez";

            Jugador jugador1 = new Jugador(nombre1, apellido1, true, 22);
            Jugador jugador2 = new Jugador(nombre2, apellido2, false, 10);
            DirectorTecnico dt = new DirectorTecnico("pedro", "martinez");
            Equipo equipo = new Equipo("los mejores", dt, Equipo.Deportes.Futbol);
            equipo += jugador1;
            equipo += jugador2;

            Console.WriteLine((string)equipo);

            equipo -= jugador2;

            Console.WriteLine((string)equipo);
            Console.ReadKey();
        }
    }
}
