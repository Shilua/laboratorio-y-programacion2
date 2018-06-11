using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Archivos57
{
    public class Persona
    {
        public string nombre;
        public string apellido;



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
            try
            {
                XmlTextWriter writer;
                XmlSerializer ser;
                //StreamWriter strw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\archivo2.xml");
                writer = new XmlTextWriter("C:\\Users\\taller\\Desktop\\Archivo2.xml", Encoding.UTF8);
                ser = new XmlSerializer(typeof(Persona));
                ser.Serialize(writer, p1);
                writer.Close();
            }            
            catch (InvalidOperationException e)//no tiene constructor sin parametros
            {
                throw e;
            }
            catch(ArgumentException e)//el path esta mal
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static Persona Cargar()
        {
            Persona persona = new Persona();
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Persona));
                StreamWriter strw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\archivo2.xml");
                XmlTextReader reader = new XmlTextReader(strw.ToString());
                persona = (Persona)serializer.Deserialize(reader);
                reader.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            return persona;
        }
 

        public override string ToString()
        {
            return string.Format("Nombre {0} Apellido {1}", this.nombre, this.apellido);
        }
    }
}
