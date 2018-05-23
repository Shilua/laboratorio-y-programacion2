using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public abstract class Equipo
    {
        protected string nombre;
        protected DateTime fechaCreacion;

        public Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }

        public virtual string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("[{0}] Fundado el [{0}]",this.nombre, this.fechaCreacion.ToString("dd-mm-yyyy"));
            return sb.ToString();
        }

        public static bool operator ==(Equipo e1, Equipo e2)
        {
            if (object.Equals(e1.nombre, e2.nombre) && object.Equals(e1.fechaCreacion, e2.fechaCreacion))
                return true;
            
            return false;
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            if (!(e1 == e2))
                return true;

            return false;
           
        }
    }
}
