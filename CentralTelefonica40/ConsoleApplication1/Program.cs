using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "2";
            string b = "2";

            if (object.Equals(a, b))
                Console.WriteLine("entro");
            else
                Console.WriteLine("no entro");
            Console.ReadKey();
        }
    }
}
