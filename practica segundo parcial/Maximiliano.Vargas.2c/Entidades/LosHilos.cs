using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Entidades
{
    public class LosHilos : Irespuesta<int>
    {
        #region Fields
        int id;
        List<InfoHilo> misHilos;
        #endregion

        #region Properties
        public string Bitacora
        {
            get
            {
                return "";
            }
            set
            {
                string algo = value;
            }
        }
        #endregion

        #region Methods



        public void RespuestaHilo(int id)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
