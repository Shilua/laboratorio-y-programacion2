using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces52
{
    public class Cartuchera1 
    {
        public List<IAcciones> lista;

        public Cartuchera1()
        {
            lista =  new List<IAcciones>();
        }

        public bool ProbarElementos()
        {
            try
            {
                foreach (IAcciones aux in this.lista)
                {
                    if (aux.UnidadesDeEscritura >= 30)
                    {
                        aux.Recargar(30);
                    }
                    aux.Escribir("biblioteca");
                }
            }
            catch(NotImplementedException e)
            {
                throw e;
            }
            return true;
        }
    }
}
