using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20Library
{
    public class Pesos
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        private Pesos()
        {

        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, float cotizacion) 
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

        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p.GetCantidad() * Dolar.GetCotizacion());
        }
        public static explicit operator Euro(Pesos p)
        {
            return new Euro(p.GetCantidad() * Euro.GetCotizacion());
        }
        
    }
}
