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
    }
}
