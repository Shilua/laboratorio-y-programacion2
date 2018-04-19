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
            this.Close();
        }

        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado;
            string numero1, numero2, operador;
            numero1 = txtNumero1.Text;
            numero2 = txtNumero2.Text;
            operador = cmbOperador.SelectedItem.ToString();
            resultado = operar(numero1, numero2, operador);
            lblResultado.Text = resultado.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            lblResultado.Text = "";
            cmbOperador.Text = "";
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if(lblResultado.Text != "")
            {
               lblResultado.Text = Numero.EnteroBinario(lblResultado.Text);
            }
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != "")
            {
                lblResultado.Text = Numero.BinarioDecimal(lblResultado.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            cmbOperador.Items.Add("+");
            cmbOperador.Items.Add("-");
            cmbOperador.Items.Add("*");
            cmbOperador.Items.Add("/");

        }

        private static double operar(string numero1, string numero2, string operador)
        {
            double retorno = 0;
            Numero num1;
            Numero num2; 
            num1 = new Numero(numero1);
            num2 = new Numero(numero2);
            retorno = Calculadora.operar(num1, num2, operador);
            
            return retorno;
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
