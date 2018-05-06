using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugo.EMarcaProducto marca = Producto.EMarcaProducto.Naranjú;
            Jugo.ESaborJugo sabor = Jugo.ESaborJugo.Pasable;
            float precio = 2f;
            int codigoBarra = 3490;
            Jugo jugo = new Jugo(codigoBarra,precio, marca, sabor);
            Console.WriteLine("{0}", jugo.ToString());
            Console.ReadKey();

        }
    }
}
