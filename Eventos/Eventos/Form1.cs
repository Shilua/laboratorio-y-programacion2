using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos
{
    public partial class Form1 : Form
    {
        Persona p = null;
        private event DelegadoString delegado;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            delegado += NotificarUsuario;     
            //delegado = new DelegadoString(NotificarUsuario);
        }

        private void NotificarUsuario(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

            if (p == null)
            {
                p = new Persona(txtNombre.Text, txtApellido.Text);
                btnCargar.Text = "Actualizar";
                
                delegado.Invoke(string.Format("Usuario {0} Creado", p.Mostrar()));
                
            }
            else
            {
                p.Nombre = txtNombre.Text;
                p.Apellido = txtApellido.Text;
                delegado.Invoke(string.Format("Usuario {0} actualizado", p.Mostrar()));
            }
        }
    }
}
