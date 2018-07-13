using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public static class ProductoDAO
    {
        #region Field
        private static string cadenDeConexion;
        private static SqlCommand comando;
        private static SqlConnection conexion;
        #endregion

        #region Methods
        static ProductoDAO()
        {
            ProductoDAO.cadenDeConexion = Properties.Settings.Default.cadenaConexion;
            ProductoDAO.comando = new SqlCommand();
            ProductoDAO.conexion = new SqlConnection(cadenDeConexion);
            ProductoDAO.comando.CommandType = CommandType.Text;
            ProductoDAO.comando.Connection = ProductoDAO.conexion;
        }

        public static List<Producto> ObtenerProductos()
        {
            List<Producto> lista = new List<Producto>();
            Producto p = null;

            ProductoDAO.comando.CommandText = "SELECT * FROM productos";
            ProductoDAO.conexion.Open();
            SqlDataReader oDr = ProductoDAO.comando.ExecuteReader();

            while (oDr.Read())
            {
               string tipo = oDr["tipo"].ToString();
               if (tipo == "A")
               {
                   Material mat = Material.Alumino;
                   switch (oDr["material"].ToString())
                   {
                       case "Plastico":
                           mat = Material.Plastico;
                           break;
                       case "Aluminio":
                           mat = Material.Alumino;
                           break;
                       case "Caucho":
                           mat = Material.Caucho;
                           break;
                   }
                   p = new ProductoA(oDr["descripcion"].ToString(), short.Parse(oDr["diametro"].ToString()), mat);
                   lista.Add(p);
               }
               else
               {
                   p = new ProductoB(oDr["descripcion"].ToString(), short.Parse(oDr["largo"].ToString()), short.Parse(oDr["ancho"].ToString()), short.Parse(oDr["alto"].ToString()));
                   lista.Add(p);
               }
                 
                
            }

            return lista;
        }

        public static bool GuardarProducto(Producto p)
        {
            string sql;
            if (p is ProductoA)
            {
                ProductoA pA = (ProductoA)p;
                sql = string.Format("INSERT INTO Productos (descripcion,tipo,diametro,material) VALUES('{0}','A','{1}','{2}')", pA.Descripcion, pA.Diametro, pA.Material.ToString());
            }
            else
            {
                ProductoB pB = (ProductoB)p;
                sql = string.Format("INSERT INTO Productos (descripcion,tipo,alto,ancho,largo) VALUES('{0}','B','{1}','{2}')", pB.Descripcion, pB.Alto, pB.Ancho, pB.Largo);
            }

            return EjecutarNonQuery(sql);
        }



        private static bool EjecutarNonQuery(string sql)
        {
            bool todoOk = false;
            try
            {
                // LE PASO LA INSTRUCCION SQL
                ProductoDAO.comando.CommandText = sql;

                // ABRO LA CONEXION A LA BD
                ProductoDAO.conexion.Open();

                // EJECUTO EL COMMAND
                ProductoDAO.comando.ExecuteNonQuery();

                todoOk = true;
            }
            catch (Exception e)
            {
                todoOk = false;
            }
            finally
            {
                if (todoOk)
                    ProductoDAO.conexion.Close();
            }
            return todoOk;
        }
        #endregion
    }
}
