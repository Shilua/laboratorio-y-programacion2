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
                return 2;
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return 2;
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return 2;
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
        #endregion
    }
}
