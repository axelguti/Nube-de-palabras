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

        private void button1_Click(object sender, EventArgs e)
        {
            Estudiante es = new Estudiante();
            RespuestasEstudiante rs = new RespuestasEstudiante();
            rs.conta = (int)dEntrada.Value;
            if (VerificarPregunta(txtPregunta.Text))
            {
                es.lblPregunta.Text = txtPregunta.Text;
                this.Hide();

                if (Seleccionar.Checked)
                {

                }
                if (dEntrada.Value == 1)
                {
                    Respuesta1.Visible = true;
                    Respuesta2.Visible = false;
                    Respuesta3.Visible = false;
                    es.txtRes1.Visible = true;
                    es.txtRes3.Visible = false;
                    es.txtRes2.Visible = false;
                }
                if (dEntrada.Value == 2)
                {
                    Respuesta1.Visible = true;
                    Respuesta2.Visible = true;
                    Respuesta3.Visible = false;
                    es.txtRes1.Visible = true;
                    es.txtRes3.Visible = true;
                    es.txtRes2.Visible = false;
                }
                if (dEntrada.Value == 3)
                {
                    Respuesta1.Visible = true;
                    Respuesta2.Visible = true;
                    Respuesta3.Visible = false;
                    es.txtRes1.Visible = true;
                    es.txtRes3.Visible = true;
                    es.txtRes2.Visible = true;
                }
                es.Show();
            }
        }

        private void btnCompartir_Click(object sender, EventArgs e)
        {
            Compartir com = new Compartir();
            com.Show();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if(new Interaccion().verificarConexion()){
                MessageBox.Show("Conexion esta abierta");
            }
            else
            {
                MessageBox.Show("Fallo la conexion con la base de datos");
            }
        }

        public Boolean VerificarPregunta(String pregun)
        {
            if(pregun == "")
            {
                MessageBox.Show("Error, Ingrese una pregunta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
