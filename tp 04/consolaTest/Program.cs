using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace consolaTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Paquete p = new Paquete("direccion", "id");
            //Correo c = new Correo();
            //c+= p;
            PaqueteDAO.Insertar(p);
            //try { c += p; }
            //catch(TrackingIdRepetidoException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            
            //Console.WriteLine(c.MostrarDatos(c.Paquetes));
            //c.FinEntregas();
            Console.ReadKey();

        }
    }
}
