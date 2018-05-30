using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace _56
{
    class Persona
    {
        private string nombre;
        private string apellido;

        

        public Persona()
        {
        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public static void Guardar(Persona p1)
        {
            XmlTextWriter writer;
            XmlSerializer ser;
            StreamWriter strw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            writer = new XmlTextWriter(strw.ToString(), Encoding.UTF8);
            ser = new XmlSerializer(typeof(Persona));
            try
            {  
                ser.Serialize(writer, p1);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                writer.Close();
            }

        }
    }
}
