using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class MGeneral : Medico, IMedico
    {
        #region Methods
        
        public MGeneral(string apellido, string nombre)
            :base(apellido,nombre)
        { }

        protected override void Atender()
        {
            Thread.Sleep(tiempoAleatorio.Next(1500, 2000));
            this.FinalizarAtencion();
        }

        public void IniciarAtencion(Paciente p)
        {
            Thread hilo = new Thread(Atender);
            hilo.Start();
        }
        #endregion
    }
}
