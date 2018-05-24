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

        public string JugarPartido
        {
            get
            {
                Random r = new Random();
                int randomTUno = r.Next(this.equipos.Count);
                int randomTDos;
                do
                {
                    Random r2 = new Random();
                    randomTDos = r2.Next(this.equipos.Count);
                } while (randomTUno == randomTDos);
                    
                return this.CalcularPartido(this.equipos[randomTUno],this.equipos[randomTDos]);
            }
        }

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
            Random r = new Random();
            
            StringBuilder sb = new StringBuilder();
            int resultado1;
            int resultado2;
            if (equipo1 is EquipoFutbol && equipo2 is EquipoFutbol)
            {
                resultado1 = r.Next(10);
                resultado2 = r.Next(10);
            }
            else
            {
                resultado1 = r.Next(100);
                resultado2 = r.Next(100);
            }
            sb.AppendFormat("[{0}][{1}]-[{2}][{3}]",equipo1.Nombre,resultado1,resultado2,equipo2.Nombre);
            return sb.ToString();
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
