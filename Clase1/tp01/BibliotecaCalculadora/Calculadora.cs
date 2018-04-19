using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCalculadora
{
    public class Calculadora
    {
        private static string ValidarOperador(string operador)
        {
            string str = "+";
            if (!Object.ReferenceEquals(operador, null))
            {
                
                if (operador == "-")
                {
                    str = operador;
                }
                else if (operador == "*")
                {
                    str = operador;
                }
                else if (operador == "/")
                {
                    str = operador;
                }
            }
            return str;
        }

        public static double operar(Numero n1, Numero n2, string operador)
        {
            double retorno = 0;
            string str;
            
           if(!Object.ReferenceEquals(n1,null)&& !Object.ReferenceEquals(n2,null)&& !Object.ReferenceEquals(operador, null))
           {
                str = ValidarOperador(operador);
                if(str == "+")
                {
                    retorno = n1 + n2;
                }
                else if (str == "-")
                {
                    retorno = n1 - n2;
                }
                else if (str == "*")
                {
                    retorno = n1 * n2;
                }
                else if (str == "/")
                {
                    retorno = n1 / n2;
                }

            }


            return retorno;
        }
    }
}
