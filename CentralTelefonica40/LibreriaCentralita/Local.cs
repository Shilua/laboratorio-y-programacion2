using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaCentralita
{
    public class Local : Llamada
    {
        #region Fields
        protected float costo;
        #endregion

        #region properties
        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        #endregion

        #region Methods

        private float CalcularCosto()
        {
            float retorno = 0;

            retorno = this.costo * base.Duracion;

            return retorno;
        }

        public Local(string origen, float duracion, string destino, float costo) 
        :base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        public Local(Llamada llamada, float costo) 
       :this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }

        public string Mostrar()
        {
            string retorno = "";
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} Costo: {1}", base.Mostrar(), this.CostoLlamada);
            retorno = sb.ToString();
            return retorno;
        }

        #endregion

        #region Nested Types

        
        #endregion
    }
}
