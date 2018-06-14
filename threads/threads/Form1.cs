using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace threads
{
    public partial class frmThreads : Form
    {
        public frmThreads()
        {
            InitializeComponent();
            //timer1.Enabled = true; 
        }

        private void frmThreads_Load(object sender, EventArgs e)
        {
            //string hora;
            //do
            //{
            //    hora = string.Format("{0}", DateTime.Now);
            //    lblHora.Text = hora;
            //} while (true);
            Thread t = new Thread(ActualizarHora);
            t.Start();

            

        }


        private void ActualizarHora()
        {
            do
              {
                if (lblHora.InvokeRequired)
                {
                    lblHora.BeginInvoke((MethodInvoker)delegate()
                    {
                        
                            lblHora.Text = DateTime.Now.ToString(" H:mm:ss yyyy-MM-dd");

                    });
                }
                Thread.Sleep(1000);
               } while (true);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString(" H:mm:ss yyyy-MM-dd");
        }
    }
}
