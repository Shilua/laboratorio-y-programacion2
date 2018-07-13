using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {
        #region Fields
        List<Producto> productos;
        #endregion

        #region Properties
        public List<Producto> Productos
        {
            get { return this.productos; }
            set { this.productos = value; }
        }
        #endregion

        #region Methods
        public Pedido()
        {
            this.productos = new List<Producto>();
        }
        #endregion

    }
}
