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
            p.txtRespuestas.Text = txtRes1.Text;
            p.Show();
        }
    }
}
