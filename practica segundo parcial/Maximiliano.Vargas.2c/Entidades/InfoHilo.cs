using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Interfaces;

namespace Entidades
{
    public class InfoHilo
    {
        #region Fields
        Irespuesta<int> callback;
        Thread Hilo;
        int id;
        static Random randomizer;
        #endregion

        #region Methods
        public InfoHilo(int id, Irespuesta<int> callback)
        {
            randomizer = new Random();
            this.id = id;
            this.callback = callback;
            this.Hilo = new Thread(Ejecutar);
            this.Hilo.Start();
        }

        private void Ejecutar()
        {
            Thread.Sleep(randomizer.Next(1, 6));
            callback.RespuestaHilo(this.id);
        }
        #endregion
    }
}
