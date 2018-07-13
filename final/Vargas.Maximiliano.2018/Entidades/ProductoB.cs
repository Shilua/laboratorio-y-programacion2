using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoB : Producto
    {
        #region Fields
        private short alto;
        private short ancho;
        private short largo;
        #endregion

        #region Properties
        public short Alto
        {
            get { return this.alto; }
        }
        public short Ancho
        {
            get { return this.ancho; }
        }
        public short Largo
        {
            get { return this.largo; }
        }
        #endregion

        #region Methods
        public ProductoB()
            :base()
        {
        }

        public ProductoB(string descripcion, short largo, short alto, short ancho)
            : base(descripcion)
        {
            this.largo = largo;
            this.alto = alto;
            this.ancho = ancho;
        }

        public override string Mostrar()
        {
            return string.Format("{0},ANCHO{1}, ALTO{2}, LARGO{3}, VOLUMEN:{4}", base.Mostrar(), this.Ancho, this.Alto, this.Largo, this.CalcularVolumen());
        }

        public override bool ValidarDimensiones()
        {
            if (this.Largo + this.ancho + this.alto > 100)
                return true;
            else
                return false;
        }

        public int CalcularVolumen()
        {
            int volumen = this.alto * this.ancho * this.largo;
            return volumen;
        }
        #endregion
    }
}
