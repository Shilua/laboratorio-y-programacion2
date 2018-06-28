using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Medico : Persona
    {
        #region Fields
        private Paciente pacienteActual;
        protected static Random tiempoAleatorio;
        #endregion

        #region Properties
        public Paciente AtenderA
        {
            set
            {
                this.pacienteActual = value;
            }
        }
        public virtual string EstaAtendiendoA
        {
            get
            {
                return pacienteActual.ToString();
            }
        }
        #endregion

        #region Methods

        static Medico()
        {
            tiempoAleatorio = new Random();
        }

        public Medico(string apellido, string nombre)
            :base(apellido,nombre)
        {

        }

        protected abstract void Atender();

        protected void FinalizarAtencion()
        {
            AtencionFinalizada(this.pacienteActual, this);
            this.pacienteActual = null;
        }

        public override string ToString()
        {
            return string.Format("El Doctor {0} {1}", this.apellido, this.nombre);
        }
        #endregion

        #region Events
        public delegate void FinAtencionPaciente(Paciente p, Medico m);
        public event FinAtencionPaciente AtencionFinalizada;
        #endregion

    }
}
