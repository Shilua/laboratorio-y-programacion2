using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        #region Fields
        static Deportes deporte;
        DirectorTecnico dt;
        List<Jugador> jugadores;
        string nombre;
        #endregion
        #region Propetries
        public Deportes Deporte
        {
            set
            {
                deporte = value;
            }
            get
            {
                return deporte;
            }
        }
        #endregion
        #region Methods
        static Equipo()
        {
            deporte = Deportes.Futbol;
        }

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(string nombre, DirectorTecnico director)
            :this()
        {
            this.nombre = nombre;
            this.dt = director;
        }

        public Equipo(string nombre, DirectorTecnico director, Deportes deporte)
            :this(nombre,director)
        {
            this.Deporte = deporte;
        }

        public static bool operator ==(Equipo equipo, Jugador jugador)
        {
            bool retorno = false;
            foreach(Jugador aux in equipo.jugadores)
            {
                if(aux == jugador)
                {
                    retorno = true;
                    return retorno;
                }
            }
           return retorno;
        }
        
        public static bool operator !=(Equipo equipo, Jugador jugador)
        {
            bool retorno = false;
            if (!(equipo == jugador))
                retorno = true;
            return retorno;
        }

        public static Equipo operator +(Equipo equipo, Jugador jugador)
        {
            if(equipo == jugador)
            {
                return equipo;
            }
            equipo.jugadores.Add(jugador);
            return equipo;
        }

        public static Equipo operator -(Equipo equipo, Jugador jugador)
        {
            if (equipo == jugador)
            {
                equipo.jugadores.Remove(jugador);
                return equipo;
            }
            return equipo;
        }

        public static implicit operator string(Equipo e)
        {
            string retorno;
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} {1}", e.nombre, e.Deporte.ToString());
            sb.AppendLine("Nomina de jugadores");
            foreach(Jugador jugador in e.jugadores)
            {
                sb.AppendLine(jugador.ToString());
            }
            sb.AppendFormat("Dirigido por: {0}", e.dt.ToString());
            sb.AppendLine("");
            retorno = sb.ToString();
            return retorno;
        }
        #endregion
        #region Nested Types

        public enum Deportes
        {
            Basquet,
            Futbol,
            Handball,
            Rugby,
        }

        #endregion

    }
}
