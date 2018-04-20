using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCalculadora
{
    public class Numero
    {
        /// <summary>
        /// Campo numero
        /// </summary>
        private double numero;

        /// <summary>
        /// Propiedad que setea el numero
        /// </summary>
        private string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }

        private Numero()
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="numero">Recive un numero y lo asigna</param>
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
            int Numero = 0;
            for (int i = 1; i <= binario.Length; i++)
            {
                Numero += int.Parse(binario[i - 1].ToString()) * (int)Math.Pow(2, binario.Length - i);
            }

            return Numero.ToString();
        }


        /// <summary>
        /// Convierte un numero entero en un numero binario
        /// </summary>
        /// <param name="Numero">Recibe un numero entero en formato double</param>
        /// <returns>retorna un string con el numero binario</returns>
        public static string DecimalBinario(double Numero)
        {
            string binario="";
            while (Numero >=2)
            {
                binario = (Numero % 2).ToString() + binario;
                Numero = (int)Numero / 2;
            }
            return Numero.ToString()+binario;
        }

        /// <summary>
        /// Convierte un numero entero en numero binario
        /// </summary>
        /// <param name="strNumero">Recibe un string con el numero entero</param>
        /// <returns>Retorna un string con el numero binario</returns>
        public static string DecimalBinario(string strNumero)
        {
            double aux;
            string retorno = "Valor Invalido";
            if(double.TryParse(strNumero, out aux))
            {
            retorno = Numero.DecimalBinario(aux);
            }
            
            return retorno;
        }

        /// <summary>
        /// Sobrecarga del operador -
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>retorna un doble con el resultado</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            double retorno = 0;
            retorno = n1.numero - n2.numero;
            return retorno;
        }

        /// <summary>
        /// Sobrecarga del operador *
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>retorna un doble con el resultado</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            double retorno = 0;
            retorno = n1.numero * n2.numero;
            return retorno;
        }

        /// <summary>
        /// Sobrecarga del operador /
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>retorna un doble con el resultado</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            double retorno = 0;
            retorno = n1.numero / n2.numero;
            return retorno;
        }

        /// <summary>
        /// Sobrecarga del operador +
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>retorna un doble con el resultado</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            double retorno = 0;
            retorno = n1.numero + n2.numero;
            return retorno;
        }

        /// <summary>
        /// Valida que el dato recibido sea un numero
        /// </summary>
        /// <param name="strNumero">string con un numero</param>
        /// <returns>retorna un doble con el numero pasado</returns>
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
