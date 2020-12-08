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
        /// <summary>
        /// Valida cuantas preguntas por estudiante se pude ingresar
        /// el rango es de 1-3 preguntas por participante.
        /// </summary>
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
                    es.txtRes2.Visible = false;
                    es.txtRes3.Visible = false;
                    es.lblIdea1.Visible = true;
                    es.lblIdea2.Visible = false;
                    es.lblIdea3.Visible = false;
                }
                if (dEntrada.Value == 2)
                {
                    Respuesta1.Visible = true;
                    Respuesta2.Visible = true;
                    Respuesta3.Visible = false;
                    es.txtRes1.Visible = true;
                    es.txtRes2.Visible = true;
                    es.txtRes3.Visible = false;
                    es.lblIdea1.Visible = true;
                    es.lblIdea2.Visible = true;
                    es.lblIdea3.Visible = false;
                }
                if (dEntrada.Value == 3)
                {
                    Respuesta1.Visible = true;
                    Respuesta2.Visible = true;
                    Respuesta3.Visible = false;
                    es.txtRes1.Visible = true;
                    es.txtRes2.Visible = true;
                    es.txtRes3.Visible = true;
                    es.lblIdea1.Visible = true;
                    es.lblIdea2.Visible = true;
                    es.lblIdea3.Visible = true;
                }
                es.Show();
            }
        }
        /// <summary>
        /// cambia a la interfaz de compartir.
        /// </summary>

        private void btnCompartir_Click(object sender, EventArgs e)
        {
            Compartir com = new Compartir();
            com.Show();
        }
        /// <summary>
        /// Verificar la pregunta.
        /// </summary>
        /// <param name="pregun">Pregunta echa por el docente.</param>
        /// <returns>
        /// retorna verdadero si en la pregunta contiene caracteres
        /// retorna false cuando la pregunta esta vacia
        /// </returns>
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
