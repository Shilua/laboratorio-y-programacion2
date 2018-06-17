using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paquete :  IMostrar<T>
    {

        #region Field
        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;
        #endregion

        #region Properties

        public string DireccionEntrega
        {
            get
            {
                return this.direccionEntrega;
            }
            set
            {
                this.direccionEntrega = value;
            }
        }

        public EEstado Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }

        public string TrackingID
        {
            get
            {
                return this.trackingID;
            }
            set
            {
                this.trackingID = value;
            }
        }

        #endregion

        #region Methods

        #endregion

        #region Events
        #endregion

        #region Nested Types
        public enum EEstado
        {

        }
        #endregion

    }
}
