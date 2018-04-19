using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaCalculadora;

namespace MiCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }

        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            Numero numero1;
            Numero numero2;
            string num1, num2, operador;
            double aux;
            num1 = txtNumero1.Text;
            num2 = txtNumero2.Text;
            numero1 = new Numero(num1);
            numero2 = new Numero(num2);
            operador = cmbOperador.SelectedItem.ToString();
            aux  = Calculadora.operar(numero1, numero2, operador);
            lblResultado.Text = aux.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            cmbOperador.Items.Add("+");
            cmbOperador.Items.Add("-");
            cmbOperador.Items.Add("*");
            cmbOperador.Items.Add("/");

        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
