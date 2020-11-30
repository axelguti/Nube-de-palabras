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
            RespuestasEstudiante r = new RespuestasEstudiante();
            PantallaProfesor p = new PantallaProfesor();
            this.Hide();

            p.Respuesta1.Text = txtRes1.Text;
            p.Respuesta1.Visible = true;
            p.Respuesta2.Text = txtRes3.Text;
            p.Respuesta2.Visible = true;
            p.Respuesta3.Text = txtRes2.Text;
            p.Respuesta3.Visible = true;
            p.Show();

            r.Respuesta1.Text = txtRes1.Text;
            r.Respuesta1.Visible=true;
            r.Respuesta2.Text = txtRes3.Text;
            r.Respuesta2.Visible = true;
            r.Respuesta3.Text = txtRes2.Text;
            r.Respuesta3.Visible = true;
            r.Show();
        }
    }
}
