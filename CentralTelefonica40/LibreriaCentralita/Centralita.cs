using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaCentralita
{
    public class Centralita
    {
        #region Fields
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;
        #endregion

        #region properties
        public float GananciasPorLocal
        {
            get
            {
                float retorno;
                retorno = this.CalcularGanancia(Llamada.TipoLlamadas.Local);
                return retorno;
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                float retorno;
                retorno = this.CalcularGanancia(Llamada.TipoLlamadas.Provincial);
                return retorno;
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                float retorno;
                retorno = this.CalcularGanancia(Llamada.TipoLlamadas.Todas);
                return retorno;
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }
        #endregion

        #region methods
        private float CalcularGanancia(Llamada.TipoLlamadas tipo)
        {
            Local auxLocal;   
            Provincial auxProvincial;
            float retornoLocal = 0;
            float retornoProvincial = 0;
            float retorno = 0;
            foreach(Llamada aux in this.Llamadas)
            {
                if (aux is Local)
                {
                    auxLocal = (Local)aux;
                    retornoLocal += auxLocal.CostoLlamada;
                }
                else if (aux is Provincial)
                {
                    auxProvincial = (Provincial)aux;
                    retornoProvincial += auxProvincial.CostoLlamada;
                }
            }

            switch ((int)tipo)
            { 
                case 0: //local
                    retorno = retornoLocal;
                    break;
                case 1: //provincial
                    retorno = retornoProvincial;
                    break;
                case 2: //todas
                    retorno = retornoLocal + retornoProvincial;
                    break;
            }

            return retorno;
        }

        public Centralita()
        {
           this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public string Mostrar()
        {
            string retorno = "";
            Local auxLocal;
            Provincial auxProvincial;
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Ganancia Total: {0} Ganancia por Local {1} Ganancia por Provincial {2} ", this.GananciasPorTotal, this.GananciasPorLocal, this. GananciasPorProvincial);
            sb.AppendLine("");
            foreach(Llamada aux in this.Llamadas)
            {
                if(aux is Local)
                {
                    auxLocal = (Local)aux;
                    sb.AppendFormat("{0}", auxLocal.Mostrar());
                    sb.AppendLine("");
                }
                else
                {
                    auxProvincial = (Provincial)aux;
                    sb.AppendFormat("{0}", auxProvincial.Mostrar());
                    sb.AppendLine("");
                }
            }

            retorno = sb.ToString();
            return retorno;
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort();
        }
        #endregion
    }
}
