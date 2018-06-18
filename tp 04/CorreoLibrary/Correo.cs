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
            foreach(Paquete aux in c.Paquetes)
            {
                if(aux == p)
                {
                   //lanzar exception
                }
                else
                {
                    c.Paquetes.Add(p);
                }
            }
            return c;
        }
        public string MostrarDatos(List<Paquete> elemento)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
