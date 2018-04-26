using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaCentralita
{
    public class Llamada
    {
        #region Fields
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        #endregion

        #region properties
        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get 
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }
        #endregion

        #region Methods
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public string Mostrar()
        {
            string retorno = "";
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Numero de origen: {0}, Numero de destino: {1}, Duracion {2}", this.NroOrigen, this.NroDestino, this.Duracion);
            retorno = sb.ToString();
            return retorno;
        }

        public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = 0;

            if (!object.ReferenceEquals(llamada1, null) && !object.ReferenceEquals(llamada2, null))
            {
                if (llamada1.Duracion < llamada2.Duracion)
                    retorno = 1;
                else if(llamada1.Duracion > llamada2.Duracion)
                    retorno = -1;
            }

            return retorno;
        }
        #endregion

        #region Nested Types

        public enum TipoLlamadas
        {
            Local,
            Provincial,
            Todas,
        }
        #endregion

    }
}
