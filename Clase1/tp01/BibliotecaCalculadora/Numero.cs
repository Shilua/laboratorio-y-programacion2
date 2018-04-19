using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCalculadora
{
    public class Numero
    {
        private double numero;

        private string SetNumero
        {
            set
            {
                this.numero = double.Parse(value);
            }
        }

        private Numero()
        {

        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor que inicializa el numero.
        /// </summary>
        /// <param name="strNumero">un string con un numero</param>
        public Numero(string strNumero)
        {
            SetNumero = strNumero;
        }

        /// <summary>
        /// Convierte un numero binario a decimal
        /// </summary>
        /// <param name="binario">Recibe un numero binario escrito en string</param>
        /// <returns>retorna un string con el numero decimal</returns>
        public static string BinarioDecimal(string binario)
        {
            int entero = 0;
            string returnAux = "Valor Invalido";
            for (int i = 1; i <= binario.Length; i++)
            {
                entero += int.Parse(binario[i - 1].ToString()) * (int)Math.Pow(2, binario.Length - i);
            }

            return returnAux;
        }


        /// <summary>
        /// Convierte un numero entero en un numero binario
        /// </summary>
        /// <param name="entero">Recibe un numero entero en formato double</param>
        /// <returns>retorna un string con el numero binario</returns>
        public static string EnteroBinario(double entero)
        {
            string binario = "Valor Invalido";
            while (entero >=2)
            {
                binario = (entero % 2).ToString() + binario;
                entero = (int)entero / 2;
            }
            return binario;
        }

        public static double operator -(Numero n1, Numero n2)
        {
            double retorno = 0;
            retorno = n1.numero - n2.numero;
            return retorno;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            double retorno = 0;
            retorno = n1.numero * n2.numero;
            return retorno;
        }

        public static double operator /(Numero n1, Numero n2)
        {
            double retorno = 0;
            retorno = n1.numero / n2.numero;
            return retorno;
        }

        public static double operator +(Numero n1, Numero n2)
        {
            double retorno = 0;
            retorno = n1.numero + n2.numero;
            return retorno;
        }


        private static double ValidarNumero(string strNumero)
        {
            double returnDouble = 0;
            double auxDouble;

            if(double.TryParse(strNumero,out auxDouble))
            {
                returnDouble = auxDouble;
            }

            return returnDouble;
        }
    }
}
