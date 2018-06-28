using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        #region Fields
        protected string apellido;
        protected string nombre;
        #endregion

        #region Methods
        public Persona(string apellido, string nombre)
        {
            this.apellido = apellido;
            this.nombre = nombre;
        }
        #endregion
    }
}
