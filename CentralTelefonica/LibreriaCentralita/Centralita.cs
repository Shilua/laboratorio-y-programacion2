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
            float retorno = 0;
            
            return retorno;
        }
        #endregion
    }
}
