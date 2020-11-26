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

        private void button1_Click(object sender, EventArgs e)
        {
            Estudiante es = new Estudiante();

            es.lblPregunta.Text = txtPregunta.Text;

            if(Seleccionar.Checked)
            {

            }

            if (dEntrada.Value == 1)
            {
                es.txtRes1.Visible = true;
                es.txtRes3.Visible = false;
                es.txtRes2.Visible = false;
            }
            if (dEntrada.Value == 2)
            {
                es.txtRes1.Visible = true;
                es.txtRes3.Visible = true;
                es.txtRes2.Visible = false;
            }
            if (dEntrada.Value == 3)
            {
                es.txtRes1.Visible = true;
                es.txtRes3.Visible = true;
                es.txtRes2.Visible = true;
            }
            es.Show();
        }

        private void btnCompartir_Click(object sender, EventArgs e)
        {
            Compartir com = new Compartir();
            com.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
