using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces52
{
    public class Lapiz : IAcciones
    {
        float tamanioMina;
        

        public ConsoleColor IAcciones.Color
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public float IAcciones.UnidadesDeEscritura
        {
            get
            {
                return this.tamanioMina;
            }
            set
            {
                this.tamanioMina = value;
            }
        }

        public Lapiz(int unidades)
        {
            ((IAcciones)this).UnidadesDeEscritura = unidades;
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            EscrituraWrapper escritura = new EscrituraWrapper(texto, ((IAcciones)this).Color);
            int caracteres = texto.Length;
            ((IAcciones)this).UnidadesDeEscritura = ((IAcciones)this).UnidadesDeEscritura - (caracteres * 0.1f);
            return escritura;
        }

        public bool Recargar(int unidades)
        {
            throw new NotImplementedException("No se ha podido cargar el lapiz.");
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Tipo: Lapiz");
            sb.AppendFormat("Color de tinta: {0}", ((IAcciones)this).Color);
            sb.AppendLine();
            sb.AppendFormat("Nivel de tinta: {0}", ((IAcciones)this).UnidadesDeEscritura);
            return sb.ToString();
        }
    }
}
