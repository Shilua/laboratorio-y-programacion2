using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class MEspecialista : Medico, IMedico 
    {
        #region Fields
        private Especialidad especialidad;
        #endregion

        #region Methods
        public MEspecialista(string apellido, string nombre, Especialidad e)
            : base(apellido, nombre)
        {
            this.especialidad = e;  
        }

        public void IniciarAtencion(Paciente p)
        {
            Thread.Sleep(tiempoAleatorio.Next(5000, 10000));
            this.FinalizarAtencion();
        }

        protected override void Atender()
        {
            Thread hilo = new Thread(Atender);
            hilo.Start();
        }

        #endregion

        #region Nested Types
        public enum Especialidad
        {
            Traumatologo,
            Odontologo
        }
        #endregion 
    }
}
