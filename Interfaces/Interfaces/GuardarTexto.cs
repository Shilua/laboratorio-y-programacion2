using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class GuardarTexto <T,V> : IGuardar<T,V>
    {

        public bool Mostrar(T obj)
        {
            return true;
        }

        public V Leer()
        {
            string mensaje = "Texto Leido";
            V v = (V)Convert.ChangeType(mensaje, typeof(V));
            return v;
        }
    }
}
