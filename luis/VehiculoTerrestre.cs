using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace lt_clase8_ex34
{
    public class VehiculoTerrestre
    {
        public short cantidadDeRuedas;
        public short cantidadDePuertas;
        public Lib.Colores color;
        public short cantidadDeMarchas;

        public VehiculoTerrestre(short cantidadDeRuedas, short cantidadDePuertas, Lib.Colores color, short cantidadDeMarchas) 
        {
            this.cantidadDeRuedas =cantidadDeRuedas;
            this.cantidadDePuertas = cantidadDePuertas;
            this.color = color;
            this.cantidadDeMarchas = cantidadDeMarchas;
        }
    }
}
