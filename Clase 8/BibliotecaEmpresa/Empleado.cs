using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEmpresa
{
    public class Empleado
    {
        #region Fields
        private string nombre;
        private string apellido;
        private string legajo;
        private EPuestoJeranquico puesto;
        private int salario;
        #endregion

        #region methods
        #endregion

        #region Nested Types

        public enum EPuestoJeranquico
        {
            Administracion,
            Gerencia,
            Sistemas,
            Accionista,
        }
        #endregion
    }
}
