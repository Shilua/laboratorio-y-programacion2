using System;
using System.Text;

namespace Entidades
{
    public abstract class Producto
    {
        #region Fields
        protected int codigoDeBarra;
        protected EMarcaProducto marca;
        protected float precio;
        #endregion

        #region Properties
        public abstract float CalcularCostoDeProduccion
        {get;}

        public EMarcaProducto Marca
        {
            get
            {
               return this.marca;
            }
        }

        public float Precio
        {
            get
            {
                return this.precio;
            }
        }
        #endregion

        #region Methods

        public Producto(int codigoBarra, EMarcaProducto marca, float precio)
        {
            this.codigoDeBarra = codigoBarra;
            this.marca = marca;
            this.precio = precio;
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Producto)
            {
                retorno = true;
            }
            return retorno;
        }

        public virtual string Consumir()
        {
            return "Parte de una mezcla";
        }

        private string MostrarProducto(Producto p)
        {
            string retorno= "";
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Marca: {0}", p.Marca);
            sb.AppendLine("");
            sb.AppendFormat("Marca: {0}", (int)p);
            sb.AppendLine("");
            sb.AppendFormat("Marca: {0}", p.Precio);
            sb.AppendLine("");
            retorno = sb.ToString();
            return retorno;
        }

        public static implicit operator int(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static explicit operator string(Producto p)
        {
            return p.MostrarProducto(p);
        }

        public static bool operator ==(Producto prodUno, Producto prodDos)
        {
            bool retorno = false;

            if(object.Equals(prodUno.Marca,prodDos.Marca)&&object.Equals(prodUno.codigoDeBarra,prodDos.codigoDeBarra))
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Producto prodUno, Producto prodDos)
        {
            bool retorno = false;

            if (!(prodUno==prodDos))
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator ==(Producto prodUno, EMarcaProducto Marca)
        {
            bool retorno = false;

            if (object.Equals(prodUno.Marca, Marca))
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Producto prodUno, EMarcaProducto Marca)
        {
            bool retorno = false;

            if (!(prodUno==Marca))
            {
                retorno = true;
            }

            return retorno;
        }

        #endregion

        #region NestedTypes
        public enum EMarcaProducto
        {
            Manaos,
            Naranjú, 
            Diversion,
            Swift,
            Favorita,
        }

        public enum ETipoProducto
        {
            Galletita,
            Gaseosa,
            Jugo,
            Harina,
            Todos
        }
        #endregion
    }
}
