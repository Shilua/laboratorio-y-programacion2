using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCalculadora
{
    public class Calculadora
    {
        /// <summary>
        /// Valida que el operador sea correcto
        /// </summary>
        /// <param name="operador">Recibe un string con un operador</param>
        /// <returns>Retorna el operador, en caso de fallar retorna +</returns>
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

        /// <summary>
        /// Realiza la operacion con los dos tipos de dato numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <param name="operador"></param>
        /// <returns>Retorna un double con el resultado</returns>
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
