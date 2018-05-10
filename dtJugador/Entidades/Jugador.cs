using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        #region fields
        private bool esCapitan;
        private int numero;
        #endregion

        #region properties
        public bool EsCapitan
        {
            get
            {
                return this.esCapitan;
            }
            set
            {
                this.esCapitan = value;
            }
        }

        public int Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }
        #endregion

        #region methods
        public Jugador(string nombre, string apellido)
            :base(nombre,apellido)
        {
            this.EsCapitan = false;
            this.Numero = 0;
        }

        public Jugador(string nombre, string apellido, bool esCapitan, int numero)
            :base(nombre,apellido)
        {
            this.EsCapitan = esCapitan;
            this.Numero = numero;
        }

        protected override string FichaTecnica()
        {
            string retorno;
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} ", base.NombreCompleto());
            if(this.EsCapitan)
            {
                sb.Append("capitán del equipo ");
            }
            sb.AppendFormat("Numero de camiseta {0}", (int)this);
            sb.AppendLine("");
            retorno = sb.ToString();
            return retorno;
        }

        public override string ToString()
        {
            return this.FichaTecnica();
        }

        static public explicit operator int(Jugador jugador)
        {
            return jugador.Numero;
        }

        static public bool operator ==(Jugador jugador1, Jugador jugador2)
        {
            bool retorno = false;
            if (object.Equals(jugador1.Nombre, jugador2.Nombre) && object.Equals(jugador1.Apellido, jugador2.Apellido) && object.Equals(jugador1.Numero, jugador2.Numero))
                retorno = true;
            return retorno;
        }

        static public bool operator !=(Jugador jugador1, Jugador jugador2)
        {
            bool retorno = false;
            if (!(jugador1 == jugador2))
                retorno = true;
            return retorno;
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Jugador)
            {
                if(this == obj)
                    retorno = true;
            }
                
            return retorno;
        }
        #endregion
    }
}
