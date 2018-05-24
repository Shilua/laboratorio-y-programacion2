using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics48
{
    public class Documento
    {
        #region fields
        private int numero;
        #endregion
        public int Numero
        {
            get
            { return this.numero; }
        }


        public Documento(int numero)
        {
            this.numero = numero;
        }
    }
}
