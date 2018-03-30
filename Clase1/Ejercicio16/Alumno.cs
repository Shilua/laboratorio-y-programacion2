using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    public class Alumno
    {
            private byte _nota1;
            private byte _nota2;
            private float _notaFinal;
            public string apellido;
            public int legajo;
            public string nombre;
        
        public Alumno()
        {

        }
      
        public void CalcularFinal()
        {

            if (_nota1 >= 4 && _nota2 >= 4)
            {
                Random r = new Random(DateTime.Now.Millisecond);
                r.Next(0, 10);
            }
            else
            {
                this._notaFinal = -1;
            }
        }
        public void Estudiar(byte notaUno, byte notaDos)
        {
            _nota1 = notaUno;
            _nota2 = notaDos;
        }
        public string Mostrar()
        {
            string returnAux;

            StringBuilder sb = new StringBuilder();

           sb.AppendFormat(

            //Console.WriteLine("Nombre: {0}", nombre);
            //Console.WriteLine("Apellido: {0}", apellido);
            //Console.WriteLine("Nota: {0}", legajo);

            //if (_notaFinal != -1)
            //{
            //    Console.WriteLine("Nota final: {0}", _notaFinal);
            //}
            //else
            //{
            //    Console.WriteLine("Alumno desaprobado");
            //}
            return returnAux;
        }
    }
}
