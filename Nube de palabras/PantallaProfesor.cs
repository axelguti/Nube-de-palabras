using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nube_de_palabras
{
    public partial class PantallaProfesor : Form
    {
        public PantallaProfesor()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            dEntrada.Items.Add("1");
            dEntrada.Items.Add("2");
            dEntrada.Items.Add("3");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estudiante es = new Estudiante();

            es.lblPregunta.Text = txtPregunta.Text;

            if(Seleccionar.Checked)
            {

            }

            if (dEntrada.SelectedIndex == 1)
            {
                es.txtRes1.Enabled = true;
                es.txtRes2.Enabled = false;
                es.txtRes3.Enabled = false;
            }
            if (dEntrada.SelectedIndex == 2)
            {
                es.txtRes1.Enabled = true;
                es.txtRes2.Enabled = true;
                es.txtRes3.Enabled = false;
            }
            if (dEntrada.SelectedIndex == 3)
            {
                es.txtRes1.Enabled = true;
                es.txtRes2.Enabled = true;
                es.txtRes3.Enabled = true;
            }

            es.Show();
        }

        
    }
}
