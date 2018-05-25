using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Serializar<S,V> :IGuardar<S,V>
    {


        public bool Mostrar(S obj)
        {
            return true;
        }

        public V Leer()
        {
            string mensaje = "Objeto Leido";
            V v = (V)Convert.ChangeType(mensaje, typeof(V));
            return v;
        }
    }
}
