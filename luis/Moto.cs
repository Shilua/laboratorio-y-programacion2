using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace lt_clase8_ex34
{
    public class Moto : Automovil
    {
        #region ATRIBUTOS
        public short cilindradas;
        #endregion

        #region CONSTRUCTORES

        public Moto(short cantidadDeRuedas, short cantidadDePuertas, Lib.Colores color, short cantidadDeMarchas) : base(cantidadDeRuedas, cantidadDePuertas, color , cantidadDeMarchas) 
        {
            this.cilindradas=125;
            //this.cantidadDeRuedas = 2;
            //this.cantidadDePuertas = 0;
            //this.color = Lib.Colores.Rojo;

        }

        #endregion
    }
}
