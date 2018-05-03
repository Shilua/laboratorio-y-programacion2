using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEmpresa
{
    public class Empresa
    {
        #region fields
        private List<Empleado> nominaEmpleados;
        private string razonSocial;
        private string direccion;
        private float ganancia;
        #endregion

        #region properties
        public string RazonSocial
        {
            get
            {
                return this.razonSocial;
            }
            set
            {
                this.razonSocial = value;
            }
        }

        public string Direccion
        {
            get
            {
                return this.direccion;
            }

            set
            {
                this.direccion = value;
            }
        }

        public float Ganancia
        {
            get
            {
                return this.ganancia;
            }
            set
            {
                this.ganancia = value;
            }
        }
        #endregion

        #region methods
        
        private Empresa()
        {
            nominaEmpleados = new List<Empleado>();
        }

        public Empresa(string razonSocial,string direccion, float ganancia) 
            :this()
        {
            this.RazonSocial = razonSocial;
            this.Direccion = direccion;
            this.Ganancia = ganancia;
        }

        public Empresa operator +(Empresa em, Empleado e1)
        {
            if (!object.ReferenceEquals(em, null) && !object.ReferenceEquals(e1, null))
            {
                foreach (Empleado aux in em.nominaEmpleados)
                {
                    if (aux == e1)
                    {
                        return em;
                    }
                }
            }
            em.nominaEmpleados.Add(e1);
            return em;
        }

        #endregion

    }
}
