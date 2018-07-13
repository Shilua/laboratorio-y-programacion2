using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Material
    {
        Plastico,
        Alumino,
        Caucho
    }

    public abstract class Producto
    {
        #region Fields
        protected string descripcion;
        #endregion

        #region Properties
        public string Descripcion
        {
            get { return this.descripcion; }
        }
        #endregion

        #region Methods

        public Producto()
        {
        }

        public Producto(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public virtual string Mostrar()
        {
            return string.Format("DESCRIPCION: {0}", this.Descripcion);
        }

        public abstract bool ValidarDimensiones();

        public void Elaborar()
        {
            ProductoDAO.GuardarProducto(this);
            InformarProductoTerminado.Invoke(this, null);
           
        }
        #endregion

        #region Events

        public delegate void ProductoTerminado(Object sender, EventArgs e);
        public event ProductoTerminado InformarProductoTerminado;
        #endregion
    }
}
