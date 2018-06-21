using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {
        #region Fields
        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;
        #endregion

        #region Properties
        public List<Paquete> Paquetes
        {
            get
            { return this.paquetes; }
            set
            { this.paquetes = value; }
        }
        #endregion

        #region Methods

        public Correo()
        {
            paquetes = new List<Paquete>();
            mockPaquetes = new List<Thread>();
        }

        public static Correo operator +(Correo c, Paquete p)
        {
           
                foreach (Paquete aux in c.Paquetes)
                {
                    if (aux == p)
                    {
                        throw new TrackingIdRepetidoException("Paquete repetido");
                    }                        
                }
            c.Paquetes.Add(p);
            Thread hilo = new Thread(p.MockCicloDeVida);
            c.mockPaquetes.Add(hilo);
            hilo.Start();

            return c;
        }
        public string  MostrarDatos(List<Paquete> elemento)
        {
            string retorno = "";
            foreach(Paquete aux in elemento)
            {
                retorno += aux.MostrarDatos(aux);
            }
            return retorno;
        }

        public void FinEntregas()
        {
            foreach(Thread aux in this.mockPaquetes)
            {
                if(aux.IsAlive)
                {
                    aux.Abort();
                }
            }
        }

        #endregion
    }
}
