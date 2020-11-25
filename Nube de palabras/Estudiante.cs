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
    public partial class Estudiante : Form
    {
        public Estudiante()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            PantallaProfesor p = new PantallaProfesor();
            p.Respuesta1.Text = txtRes1.Text;
            p.Respuesta1.Visible=true;
            p.Respuesta2.Text = txtRes2.Text;
            p.Respuesta2.Visible = true;
            p.Respuesta3.Text = txtRes3.Text;
            p.Respuesta3.Visible = true;
            p.Show();
        }
    }
}
