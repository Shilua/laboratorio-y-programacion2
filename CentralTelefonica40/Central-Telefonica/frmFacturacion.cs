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
    public partial class frmFacturacion : Form
    {
        private Centralita central;

        public Centralita Central
        {
            set
            {
                this.central = value;
            }
        }

        public frmFacturacion()
        {
            InitializeComponent();
        }

        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            rchtFacturacion.Text = central.ToString();
        }
    }
}
