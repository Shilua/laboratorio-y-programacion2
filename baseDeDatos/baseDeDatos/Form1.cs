using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baseDeDatos
{
    public partial class Form1 : Form
    {
        List<Product> lista;

        public Form1()
        {
            InitializeComponent();
        }

        private void lblProductName_Click(object sender, EventArgs e)
        {

        }

        private void lblDaysToManufacture_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            lista = ProductDAO.ObtenerProductos();

            foreach (Product p in lista)
            {
                cmbId.Items.Add(p.Name);
            }
        }

        private void btnCargarProducto_Click(object sender, EventArgs e)
        {
            string dato = cmbId.Text;
            foreach (Product aux in lista)
            {
                if (aux.Name == dato)
                {
                    txtNameProduct.Text = aux.Name;
                    txtDaysToManufacture.Text = aux.DaysToManufacture.ToString();
                    break;
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Product p = new Product(505,txtNameProduct.Text, int.Parse(txtDaysToManufacture.Text));
            ProductDAO.InsertarProducto(p);
            
        }
    }
}
