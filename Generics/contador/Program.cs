using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generics48;

namespace contador
{
    class Program
    {
        static void Main(string[] args)
        {
            Recibo res = new Recibo(20);
            Recibo res2 = new Recibo(30);
            Factura fac = new Factura(11);
            Factura fac2 = new Factura(27);

            Contabilidad<Factura,Recibo> contador = new Contabilidad<Factura,Recibo>();
            contador += res;
            contador += res2;
            contador += fac;
            contador += fac2;

            Console.WriteLine(contador.Mostrar());
            Console.ReadKey();
            
        }
    }
}
