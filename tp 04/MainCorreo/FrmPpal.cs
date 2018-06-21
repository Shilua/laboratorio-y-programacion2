using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MainCorreo
{
    public partial class FrmPpal : Form
    {
        Correo correo;
        Paquete paquete;
        public FrmPpal()
        {
            InitializeComponent();
            correo = new Correo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblEstadoIngresado_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            paquete = new Paquete(txtDireccion.Text, mtxtTrackingID.Text);
            try
            {
                correo += paquete;
                ActualizarEstados();
            }
            catch(TrackingIdRepetidoException ex)
            {
                MessageBox.Show(ex.Message);               
            }            
        }

        private void ActualizarEstados()
        {
            lstEstadoIngresado.Text = "";
            lstEstadoEnViaje.Text = "";
            lstEstadoEntregado.Text = "";
            foreach(Paquete aux in correo.Paquetes)
            {
                switch(aux.Estado)
                {
                    case Paquete.EEstado.ingresado:
                        lstEstadoIngresado.Text = aux.ToString();
                        break;
                    case Paquete.EEstado.en_viaje:
                        lstEstadoEnViaje.Text = aux.ToString();
                        break;
                    case Paquete.EEstado.entregado:
                        lstEstadoEntregado.Text = aux.ToString();
                        break;
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
