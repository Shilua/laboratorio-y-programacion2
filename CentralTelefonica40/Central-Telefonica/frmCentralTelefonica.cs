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
    public partial class frmCentralTelefonica : Form
    {
        private Centralita central;
        
        public frmCentralTelefonica()
        {
            InitializeComponent();
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            frmLlamador frm = new frmLlamador();
            frm.Cental = central;
            frm.ShowDialog();
        }

        private void frmCentralTelefonica_Load(object sender, EventArgs e)
        {
           central = new Centralita("Centralita");
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            frmFacturacion frm = new frmFacturacion();
            frm.Central = this.central;
            frm.Opcion = "total";
            frm.ShowDialog();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            frmFacturacion frm = new frmFacturacion();
            frm.Central = this.central;
            frm.Opcion = "local";
            frm.ShowDialog();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            frmFacturacion frm = new frmFacturacion();
            frm.Central = this.central;
            frm.Opcion = "provincial";
            frm.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
