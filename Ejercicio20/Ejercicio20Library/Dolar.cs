using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20Library
{
    public class Dolar
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        private Dolar()
        {

        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, float cotizacion) 
            :this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }



        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.GetCantidad()*Euro.GetCotizacion()); 
        }
        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(d.GetCantidad() * Pesos.GetCotizacion());
        }



        public double GetCantidad()
        {
            return this.cantidad; 
        }

        public static float GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            bool retorno = false;

            if (!Object.ReferenceEquals(d, null) && !Object.ReferenceEquals(e, null))
            {
                Dolar aux = new Dolar();
                aux = (Dolar)e;
                if (!Object.ReferenceEquals(aux.GetCantidad(), d.GetCantidad()))
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            bool retorno = false;

            if (!Object.ReferenceEquals(d, null) && !Object.ReferenceEquals(p, null))
            {
                Dolar aux = new Dolar();
                aux = (Dolar)p;
                if(!Object.Equals(aux.GetCantidad(),d.GetCantidad()))
                {
                    retorno = true;
                }
                
            }

            return retorno;
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            bool retorno = false;

            if (!Object.ReferenceEquals(d, null) && !Object.ReferenceEquals(e, null))
            {
                Dolar aux = new Dolar();
                aux = (Dolar)e;
                if (Object.ReferenceEquals(aux.GetCantidad(), d.GetCantidad()))
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            bool retorno = false;

            if (!Object.ReferenceEquals(d, null) && !Object.ReferenceEquals(p, null))
            {
                Dolar aux = new Dolar();
                aux = (Dolar)p;
                if (Object.ReferenceEquals(aux.GetCantidad(), d.GetCantidad()))
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar aux = new Dolar();
            double auxiliar = 0;
            aux = (Dolar)e;
            auxiliar = d.GetCantidad() - aux.GetCantidad();
            d = new Dolar(auxiliar);
            return d;
        }
        public static Dolar operator -(Dolar d, Pesos p)
        {
            Dolar aux = new Dolar();
            double auxiliar = 0;
            aux = (Dolar)p;
            auxiliar = d.GetCantidad() - aux.GetCantidad();
            d = new Dolar(auxiliar);
            return d;
            
        }
        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar aux = new Dolar();
            double auxiliar = 0;
            aux = (Dolar)e;
            auxiliar = d.GetCantidad() + aux.GetCantidad();
            d = new Dolar(auxiliar);
            return d;
        }
        public static Dolar operator +(Dolar d, Pesos p)
        {
            Dolar aux = new Dolar();
            double auxiliar = 0;
            aux = (Dolar)p;
            auxiliar = d.GetCantidad() + aux.GetCantidad();
            d = new Dolar(auxiliar);
            return d;
        }

    }
}
