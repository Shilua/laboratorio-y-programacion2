using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace baseDeDatos
{
    public static class ProductDAO
    {
        #region Fields
        private static SqlConnection conexion;
        private static SqlCommand comando;
        #endregion
        #region Constructs
        static ProductDAO()
        {
            ProductDAO.conexion = new SqlConnection(Properties.Settings.Default.cadenaDeConexion);
            ProductDAO.comando = new SqlCommand();

            ProductDAO.comando.CommandType = System.Data.CommandType.Text;
            ProductDAO.comando.Connection = ProductDAO.conexion;
        }
        #endregion

        #region Getters
        public static List<Product> ObtenerProductos()
        {
            Product producto = null;
            List<Product> productos = new List<Product>();
            try
            {
                ProductDAO.comando.CommandText = "SELECT TOP 20 ProductID, Name, DaysToManufacture FROM Production.Product";

                ProductDAO.conexion.Open();

                SqlDataReader oRd = ProductDAO.comando.ExecuteReader();

                while (oRd.Read())
                {
                    producto = new Product(int.Parse(oRd["ProductID"].ToString()), oRd["Name"].ToString(),int.Parse(oRd["DaysToManufacture"].ToString()));
                    productos.Add(producto);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            ProductDAO.conexion.Close();
            return productos;
        }
        #endregion

        #region Methods
        
        public static bool InsertarProducto(Product p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("INSERT INTO Production.Product (ProductID,Name,DaysToManufacture) VALUES('{0}','{1}','{2}');", p.ProductId, p.Name, p.DaysToManufacture);
            return EjecutarNonQuery(sb.ToString());
        }

        public static bool ModificaProducto(Product p)
        {
            //string sql = "UPDATE Production.Product SET ProductNumber = '" + p.ProductNumber + "' WHERE ProductID =" + p.ProductId.ToString();
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("UPDATE Production.Product SET Name = '{0}', DaysToManufacture = '{1}' WHERE = {2});", p.Name, p.DaysToManufacture, p.ProductId);
            return EjecutarNonQuery(sb.ToString());
        }

        public static bool EliminarProducto(Product p)
        {
            
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("DELETE FORM Production.Product WHERE ProductID = {0}", p.ProductId);
            return EjecutarNonQuery(sb.ToString());
        }
        #endregion

        /// <summary>
        /// Funcion que ejecuta el non query
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private static bool EjecutarNonQuery(string sql)
        {
            bool todoOk = false;
            try
            {
                // LE PASO LA INSTRUCCION SQL
                ProductDAO.comando.CommandText = sql;

                // ABRO LA CONEXION A LA BD
                ProductDAO.conexion.Open();

                // EJECUTO EL COMMAND
                ProductDAO.comando.ExecuteNonQuery();

                todoOk = true;
            }
            catch (Exception e)
            {
                todoOk = false;
            }
            finally
            {
                if (todoOk)
                    ProductDAO.conexion.Close();
            }
            return todoOk;
        }
    }
}
