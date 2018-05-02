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
        private EPuestoJerarquico puesto;
        private int salario;
        #endregion

        #region methods

        public Empleado(string nombre, string apellido, string legajo, EPuestoJerarquico puesto,int salario)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.puesto = puesto;
            this.salario = salario;
        }

        public static bool operator == (Empleado e1, Empleado e2)
        {
            bool retorno = false;
            if(object.Equals(e1.legajo,e2.legajo))
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Empleado e1, Empleado e2)
        {
            bool retorno = false;
            if(!(e1 == e2))
            {
                retorno = true;
            }
            return retorno;
        }

        public string mostrar()
        {
            string retorno = "";
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Nombre: {0} Apellido: {1} Legajo: {2}", this.nombre, this.apellido, this.legajo);
            retorno = sb.ToString();
            return retorno;
        }
        #endregion

        #region Nested Types

        public enum EPuestoJerarquico
        {
            Administracion,
            Gerencia,
            Sistemas,
            Accionista,
        }
        #endregion
    }
}
