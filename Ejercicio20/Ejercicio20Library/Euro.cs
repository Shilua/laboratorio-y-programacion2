using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20Library
{
    public class Euro
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        private Euro()
        {

        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, float cotizacion) 
            :this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static float GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.GetCantidad() * Dolar.GetCotizacion());
        }
        public static explicit operator Pesos(Euro e)
        {
            return new Pesos(e.GetCantidad() * Pesos.GetCotizacion());
        }
    }
}
