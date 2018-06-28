using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class GuardarString
    {
        public static bool Guardar(this string texto, string archivo)
        {
            try
            {
                
                using (StreamWriter guardar = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\" + archivo + ".txt", true))
                {
                    guardar.WriteLine(texto);
                    guardar.Close();
                }

                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
