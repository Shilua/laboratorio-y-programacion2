using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paquete  : IMostrar<Paquete> 
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

        public Paquete(string direccionEntrega, string trackingID)
        {
            this.DireccionEntrega = direccionEntrega;
            this.TrackingID = trackingID;
            this.Estado = EEstado.ingresado;
        }

        public void MockCicloDeVida()
        {
            do
            {
                Thread.Sleep(1000);
                if(this.Estado == EEstado.ingresado)
                {
                    this.Estado = EEstado.en_viaje;
                }
                else
                {
                    this.Estado = EEstado.entregado;
                }
                //informar estado
            } while (this.Estado != EEstado.entregado);
            try
            {
                PaqueteDAO.Insertar(this);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public override string ToString()
        {
            
            return this.MostrarDatos(this);
        }

        public static bool operator ==(Paquete p1, Paquete p2)
        {
            if(p1.TrackingID == p2.TrackingID)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Paquete p1, Paquete p2)
        {
            if(p1 == p2)
            {
                return false;
            }
            return true;           
        }
        public string MostrarDatos(Paquete elemento)
        {

            return string.Format("{0} para {1} ({2})", elemento.TrackingID,elemento.DireccionEntrega,elemento.Estado);
        }

        #endregion

        #region Events
        public delegate void DelegadoInformarEstado(string estado);
        public event DelegadoInformarEstado InformarEstado;

        #endregion

        #region Nested Types
        public enum EEstado
        {
            ingresado,
            en_viaje,
            entregado
        }

        #endregion

    }
}
