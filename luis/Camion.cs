using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace lt_clase8_ex34
{
    public class Camion : VehiculoTerrestre
    {
        
        #region ATRIBUTOS
        public int pesoCarga;
        #endregion

         #region CONSTRUCTORES

        public Camion(short cantidadDeRuedas, short cantidadDePuertas, Lib.Colores color, short cantidadDeMarchas)
        : base(cantidadDeRuedas, cantidadDePuertas, color, cantidadDeMarchas)
        {
            this.pesoCarga=2500;
            //this.cantidadDeMarchas = 4;
            //this.cantidadDePuertas=2;
            //this.cantidadDeRuedas = 8;
            //this.color =Lib.Colores.Gris;
        }
     }

        #endregion

}

