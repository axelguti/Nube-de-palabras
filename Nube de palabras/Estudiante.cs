using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Nube_de_palabras
{
    public partial class Estudiante : Form
    {
        OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDNube.accdb");
        OleDbCommand cmd = new OleDbCommand();
        public Estudiante()
        {
            InitializeComponent();
        }
        /// <summary>
        /// inserta en la BD los datos de los estudiantes con sus respuestas.
        /// </summary>
        /// <param name="fecha">te dice la fecha exacta.</param>
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //Comando para obtener la fecha 
            DateTime dt = DateTime.Now;
            string fecha = dt.ToString("dd-MM-yyyy");
            int estado = 0;

            if (VerificarNombre(tboxNombre.Text) && VerificarApellido(tboxApp.Text) && VerificarIdea1(txtRes1.Text) && VerificarIdea2(txtRes2.Text) && Verificaridea3(txtRes3.Text))
            {
                try
                {
                    conexion.Open();
                    string insertar = "insert into tabEstudiante(Nombre, Apellido, Fecha, [Palabra 1], [Palabra 2], [Palabra 3])VALUES(@Nom, @App, @Fecha,@Pal1, @Pal2, @Pal3)";
                    OleDbCommand cmd = new OleDbCommand(insertar, conexion);
                    cmd.Parameters.AddWithValue("@Nom", tboxNombre.Text);
                    cmd.Parameters.AddWithValue("@App", tboxApp.Text);
                    cmd.Parameters.AddWithValue("@Fecha", fecha);
                    cmd.Parameters.AddWithValue("@Pal1", txtRes1.Text);
                    cmd.Parameters.AddWithValue("@Pal2", txtRes2.Text);
                    cmd.Parameters.AddWithValue("@Pal3", txtRes3.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro guardado");
                    cmd.Connection.Close();
                }
                catch (DBConcurrencyException ex)
                {
                    MessageBox.Show("Error de concurrencia:\n" + ex.Message);
                    estado = 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    estado = 1;
                }


                if (estado == 0)
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
                    r.Respuesta1.Visible = true;
                    r.Respuesta2.Text = txtRes3.Text;
                    r.Respuesta2.Visible = true;
                    r.Respuesta3.Text = txtRes2.Text;
                    r.Respuesta3.Visible = true;
                    r.Show();
                }
            }
        }
        /// <summary>
        /// validar nombre  
        /// </summary>
        /// <param name="nombre">el nombre del participante.</param>
        /// <returns>
        /// retorna false si en nombre esta sin completar
        /// retorna true si el nombre a sido ingresado
        /// </returns>
        public Boolean VerificarNombre(String nombre)
        {
            if (nombre == "")
            {
                MessageBox.Show("Error, Ingrese algun nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// valida el apellido.
        /// </summary>
        /// <param name="apellido">el apellido del participante.</param>
        /// <returns>
        /// retorna false si el apellido esta sin completar
        /// retorna true si el apellido a sido ingresado
        /// </returns>
        public Boolean VerificarApellido(String apellido)
        {
            if (apellido == "")
            {
                MessageBox.Show("Error, Ingrese un apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// valida la primera respuesta.
        /// </summary>
        /// <param name="idea1">la Respuesta 1.</param>
        /// <returns>
        /// retorna false si la respuesta esta sin completar
        /// retorna true si la respuesta a sido ingresado
        /// </returns>
        public Boolean VerificarIdea1(String idea1)
        {
            if (idea1 == "")
            {
                MessageBox.Show("Error, Ingrese una primera idea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// valida la Segunda respuesta.
        /// </summary>
        /// <param name="idea2">la Respuesta 2.</param>
        /// <returns>
        /// retorna false si la respuesta esta sin completar
        /// retorna true si la respuesta a sido ingresado
        /// </returns>
        public Boolean VerificarIdea2(String idea2)
        {
            if (idea2 == "")
            {
                MessageBox.Show("Error, Ingrese una segunda idea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// valida la tercera respuesta.
        /// </summary>
        /// <param name="idea3">la Respuesta 3.</param>
        /// <returns>
        /// retorna false si la respuesta esta sin completar
        /// retorna true si la respuesta a sido ingresado
        /// </returns>
        public Boolean Verificaridea3(String idea3)
        {
            if (idea3 == "")
            {
                MessageBox.Show("Error, Ingrese una tercera idea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void TxtRes3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
