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

namespace VistaForm
{
    public partial class VistaForm : Form
    {
        public VistaForm()
        {
            InitializeComponent();
        }

        private void VistaForm_Load(object sender, EventArgs e)
        {
            cmbDepartamento.DataSource = Enum.GetValues(typeof(Entidades.Departamentos));
            cmbDepartamentoOficina.DataSource = Enum.GetValues(typeof(Entidades.Departamentos));
        }

        private void btnCrearOficina_Click(object sender, EventArgs e)
        {
            //Oficina oficina;
            //short piso; 
            //    short.TryParse(nudPisoOficina.ToString(),out piso);
            //oficina = new Oficina(
        }

        

        

        
    }
}
