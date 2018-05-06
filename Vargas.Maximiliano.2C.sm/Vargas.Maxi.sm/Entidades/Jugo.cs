﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Jugo : Producto
    {
        #region Fields
        protected ESaborJugo sabor;
        protected static bool deConsumo;
        #endregion

        #region properties
        public override float CalcularCostoDeProduccion
        { get
            {
                float retorno = 0;
                retorno = (this.Precio * 40) / 100;
                return retorno;
            }
        }
        #endregion

        #region Methods

        static Jugo()
        {
            deConsumo = true;
        }

        public Jugo(int codigoBarra, float precio, EMarcaProducto marca, ESaborJugo sabor)
            :base(codigoBarra, marca, precio)
        {
            this.sabor = sabor;
        }

        #endregion

        #region Nested Types
        public enum ESaborJugo
        {
            Asqueroso,
            Pasable,
            Rico,
        }
        #endregion
    }
}
