using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vargas.Maximiliano._2018
{
    public partial class FrmFinal : Form
    {
        #region Fields
        private MEspecialista medicoEspecialista;
        private MGeneral medicoGeneral;
        private Thread mocker;
        private Queue<Paciente> pacientesEnEspera;

        #endregion

        public FrmFinal()
        {
            InitializeComponent();
            this.medicoGeneral = new MGeneral("Luis", "Salinas");
            this.medicoEspecialista = new MEspecialista("Jorge", "Iglesias", MEspecialista.Especialidad.Traumatologo);
            this.pacientesEnEspera = new Queue<Paciente>();
            this.mocker = new Thread(MockPacientes);
        }

        private void FrmFinal_Load(object sender, EventArgs e)
        {
            this.mocker.Start();
        }

        private void frmFinal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.mocker.IsAlive)
                this.mocker.Abort();
        }

        private void FinAtencion(Paciente p, Medico m)
        {
            MessageBox.Show(String.Format("Finalizó la atención de {0} por {1}!", m.EstaAtendiendoA, m.ToString()));
        }

        private void MockPacientes()
        {
            List<Paciente> pacientes = new List<Paciente> { new Paciente("Clark", "Kent"), new Paciente("Bruce", "Wayne"), new Paciente("Diana", "Prince") };
            foreach (Paciente aux in pacientes)
            {
                this.pacientesEnEspera.Enqueue(aux);
                Thread.Sleep(5000);
            }
        }
    }
}
