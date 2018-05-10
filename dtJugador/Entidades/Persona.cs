using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        #region fields
        private string nombre;
        private string apellido;
        #endregion

        #region properties
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }
        #endregion

        #region methods
        protected abstract string FichaTecnica();

        protected virtual string NombreCompleto()
        {
            string retorno;
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} {1}", this.Nombre, this.Apellido);
            retorno = sb.ToString();
            return retorno;
        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        #endregion
    }
}
