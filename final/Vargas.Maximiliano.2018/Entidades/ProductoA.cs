using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;


namespace Entidades
{

    public class ProductoA : Producto
    {
        #region fields
        private short diametro;
        private Material material;
        #endregion

        #region Properties
        public short Diametro
        {
            get { return this.diametro; }
        }
        public Material Material
        {
            get { return this.material; }
            set { this.material = value; }
        }
        #endregion
        #region Methods
        public ProductoA()
            :base()
        {
        }
        public ProductoA(string descripcion, short diametro, Material material)
            : base(descripcion)
        {
            this.diametro = diametro;
            this.Material = material;
        }

        public override string Mostrar()
        {
            return string.Format("{0},TIPO: A, DIAMETRO: {1}, MATERIAL{2}", base.Mostrar(), this.Diametro, this.Material);
        }

        public override bool ValidarDimensiones()
        {
            if (this.diametro < 30 && this.diametro > 50 && this.diametro % 2 == 0)
            
                return true;
            
            else
            
                return false;
            
        }

        public bool ValidarMaterial()
        {
            bool retorno = false;
            switch (this.material)
            {
                case Entidades.Material.Alumino:
                    if (this.diametro > 10)
                    {
                        retorno = true;
                    }
                    break;
                case Entidades.Material.Caucho:
                    if (this.diametro > 15)
                    {
                        retorno = true;
                    }
                    break;
                case Entidades.Material.Plastico:
                    retorno = true;
                    break;           
            }
            if (retorno == false)
            {
                throw new MaterialException(string.Format("No se puede fabricar una pieza de {0} y de diámetro {1} centimetros", this.material, this.diametro));
            }
            return retorno;
        }
        #endregion

    }
}
