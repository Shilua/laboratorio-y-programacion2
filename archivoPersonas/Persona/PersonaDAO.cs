using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Persona
{
    public static class PersonaDAO
    {
        private static SqlCommand comando;
        private static SqlConnection conexion;

        static PersonaDAO()
        {
            PersonaDAO.conexion = new SqlConnection(Properties.Settings.Default.conexion);
            PersonaDAO.comando = new SqlCommand();

            PersonaDAO.comando.CommandType = System.Data.CommandType.Text;
            PersonaDAO.comando.Connection = PersonaDAO.conexion;
        }

        public static List<Persona> Leer()
        {
            bool todoOk = false;
            List<Persona> personas = new List<Persona>();
            try
            {
                PersonaDAO.comando.CommandText = "SELECT * FROM Persona";
                PersonaDAO.conexion.Open();
                SqlDataReader oDr = PersonaDAO.comando.ExecuteReader();
                while(oDr.Read())
                {
                    Persona p1 = new Persona(int.Parse(oDr["ID"].ToString()), oDr["Nombre"].ToString(), oDr["Apellido"].ToString());
                    personas.Add(p1);
                }
                oDr.Close();
                todoOk = true;
            }

            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if(todoOk)
                {
                    PersonaDAO.conexion.Close();
                }
            }
            
            return personas;               
        }


    }
}
