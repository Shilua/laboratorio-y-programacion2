using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces52
{
    public class Boligrafo : IAcciones
    {
        ConsoleColor colorTinta;
        float tinta;

        public ConsoleColor Color
        {
            get
            {
                return colorTinta;
            }
            set
            {
                this.colorTinta = value;
            }
        }

        public float UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }
            set
            {
                this.tinta = value;
            }
        }

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.UnidadesDeEscritura = unidades;
            this.Color = color;
        }

        public EscrituraWrapper Escribir(string texto)
        {
            EscrituraWrapper escritura = new EscrituraWrapper(texto, this.Color);
            int caracteres = texto.Length;
            this.UnidadesDeEscritura = this.UnidadesDeEscritura - (caracteres * 0.3f);
            return escritura;
        }

        public bool Recargar(int unidades)
        {
            this.UnidadesDeEscritura = unidades;
            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Tipo: Boligrafo");
            sb.AppendFormat("Color de tinta: {0}", this.Color);
            sb.AppendLine();
            sb.AppendFormat("Nivel de tinta: {0}", this.UnidadesDeEscritura);
            return sb.ToString();
        }
    }
}
