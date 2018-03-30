using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            const int cant = 3;
            Alumno[] alumnito = new Alumno[cant];
            int i;

            string leer;
            byte nota1;
            byte nota2;
            
            for(i = 0; i<cant ; i++)
            {
                alumnito[i] = new Alumno();
                // TOMA LOS DATOS DEL ALUMNO
                Console.Write("Ingrese el nombre del alumno: ");
                alumnito[i].nombre = Console.ReadLine();
                Console.Write("Ingrese el apellido del alumno: ");
                alumnito[i].apellido = Console.ReadLine();
                Console.Write("Ingrese el numero de legajo: ");
                leer = Console.ReadLine();
                int.TryParse(leer, out alumnito[i].legajo);
                Console.Write("Ingrese la primer nota: ");
                leer = Console.ReadLine();
                byte.TryParse(leer, out nota1);
                Console.Write("Ingrese la primer nota: ");
                leer = Console.ReadLine();
                byte.TryParse(leer, out nota2);
                alumnito[i].Estudiar(nota1, nota2);
            }
           
        }
    }
}
