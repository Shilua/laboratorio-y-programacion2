using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Archivos57
{
    class Program
    {
        static void Main(string[] args)
        {

                Persona p1 = new Persona("juan", "perez");
                Persona.Guardar(p1);
                //Persona p2 = Persona.Cargar();
                //Console.WriteLine(p2.ToString());
                Console.ReadKey();
        }
    }
}
