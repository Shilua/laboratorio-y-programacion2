using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeAtencion
{
    public class Negocio
    {
        #region Fields
        private PuestoAtencion caja;
        private Queue<Cliente> Clientes;
        private string nombre;

        #endregion
        
        #region properties
        public Cliente this[int i]
        {
            get
            {
                return Clientes.Dequeue();
            }
            set
            {
                Clientes.Enqueue(value);
            }
        }
        #endregion

        #region methods
        private Negocio()
        {
            Clientes = new Queue<Cliente>();
            caja = new PuestoAtencion(PuestoAtencion.Puesto.caja1);
        }
        
        public Negocio(string nombre)
        {
            this.nombre = nombre;
        }

        public bool operator !=(Negocio n, Cliente c)
        {
            bool retorno = false;
            if ()
            {
                retorno = true;
            }

            return retorno;
        }

        public bool operator ==(Negocio n, Cliente c)
        {
            bool retorno = false;

            return retorno;
        }

        public bool operator +(Negocio n, Cliente c)
        {
            bool retorno = false;

            return retorno;
        }
        

        #endregion
    }
}
