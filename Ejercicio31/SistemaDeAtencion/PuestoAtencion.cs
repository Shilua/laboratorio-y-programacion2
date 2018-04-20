using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SistemaDeAtencion
{
    class PuestoAtencion
    {
        #region Fields
        private static int numeroAcutal;
        private Puesto puesto;

        #endregion

        #region properties

        public int NumeroActual
        {
            get
            {
                return numeroAcutal;
            }
        }

        #endregion

        #region methods
        public bool Atender(Cliente cli)
        {
            bool retorno =  false;
            Thread.Sleep(5000);
            retorno = true;
            return retorno;
        }

        private static PuestoAtencion()
        {
            numeroAcutal = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        #endregion
        
        #region Nested Types

        public enum Puesto
        {
            caja1,
            caja2,
        }

        #endregion
    }
}
