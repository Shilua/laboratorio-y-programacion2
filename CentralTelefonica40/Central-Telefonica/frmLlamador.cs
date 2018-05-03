using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaCentralita;

namespace Central_Telefonica
{
    public partial class frmLlamador : Form
    {
        private Centralita central;

        public Centralita Cental
        {
            set
            {
                this.central = value;
            }
        }

        public frmLlamador()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtBox.AppendText("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtBox.AppendText("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtBox.AppendText("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtBox.AppendText("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtBox.AppendText("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtBox.AppendText("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtBox.AppendText("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtBox.AppendText("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtBox.AppendText("9");
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            txtBox.AppendText("*");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtBox.AppendText("0");
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            txtBox.AppendText("#");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBox.Text = "";
            txtNroOrigen.Text = "Nro Origen";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLlamador_Load(object sender, EventArgs e)
        {
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
        }

        private void cmbFranja_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblPanel_Click(object sender, EventArgs e)
        {

        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            if (txtBox.Text[0] == '#')
            {
                Provincial.Franja franjas;
                Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);
                Provincial llamadaProvincial = new Provincial(txtNroOrigen.Text, franjas, 30, txtBox.Text);
                central.Llamadas.Add(llamadaProvincial);
                
            }
            else
            {
                Local llamadaLocal = new Local(txtNroOrigen.Text, 30, txtBox.Text, 2.65f);
                central.Llamadas.Add(llamadaLocal);
            }
        }

        
       
    }
}
