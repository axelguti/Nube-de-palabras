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
            conexion.Open();
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
            try
            {

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

            if(estado == 0)
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

        private void TxtRes3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
