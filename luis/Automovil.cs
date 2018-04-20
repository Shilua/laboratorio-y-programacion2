using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace lt_clase8_ex34
{
    public class Automovil : Camion
    {
        #region ATRIBUTOS
        public int cantidadPasajeros;
        #endregion

         #region CONSTRUCTORES

        public Automovil(short cantidadDeRuedas, short cantidadDePuertas, Lib.Colores color, short cantidadDeMarchas)
            : base(cantidadDeRuedas, cantidadDePuertas, color, cantidadDeMarchas)
        {
            this.cantidadPasajeros=5;
        //    this.cantidadDeMarchas = 5;
        //    this.cantidadDePuertas = 4;
        //    this.cantidadDeRuedas = 4;
        //    this.color = Lib.Colores.Negro;
        }

        #endregion

    }
}
