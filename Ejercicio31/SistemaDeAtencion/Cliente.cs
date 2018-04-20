using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeAtencion;

namespace SistemaDeAtencion
{
    public class Cliente
    {
        #region Fields
        private string nombre;
        private int numero;
        #endregion

        #region Properties
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public int Numero
        {
            get
            {
                return this.numero;
            }
            
        }

        #endregion

        #region Methods

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero, string nombre)
            :this(numero)
        {
            this.Nombre = nombre;
        }
        
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            bool retorno = false;
            if(object.ReferenceEquals(c1.Numero,c2.Numero))
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            bool retorno = true;
            if (c1!=c2)
            {
                retorno = false;
            }
            return retorno;
        }
        #endregion

    }
}
