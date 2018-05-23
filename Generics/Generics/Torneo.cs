using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Torneo<T> where T : Equipo
    {
        protected List<T> equipos;
        protected string nombre;

        private Torneo()
        {
            this.equipos =  new List<T>();
        }

        public Torneo(string nombre)
            : this()
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            foreach (T aux in torneo.equipos)
            {
                if(object.Equals(aux,equipo))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Torneo<T> torneo, T equipo)
        {           
            if (!(torneo == equipo))
            {
                return true;
            }
            
            return false;
        }
        
        private string CalcularPartido(T equipo1,T equipo2)
        {
            return "algo";
        }

        public static Torneo<T> operator +(Torneo<T> torneo, T equipo)
        {
            if (torneo == equipo)
                return torneo;

            torneo.equipos.Add(equipo);
            return torneo; 
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Torneo: {0}", this.nombre);
            sb.AppendLine("");
            foreach (T aux in this.equipos)
            {
                sb.AppendFormat("Equipo: {0}", aux.Ficha());
                sb.AppendLine("");
            }       
            return sb.ToString();
        }
    }
}
