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
    public partial class RespuestasEstudiante : Form
    {
        public int conta = 0;

        /// <summary>
        /// valida la cantidad de respuesta que ingreso el estudiante
        /// </summary>
        public RespuestasEstudiante()
        {
            InitializeComponent();
            if (conta == 1)
            {
                Respuesta1.Visible = true;
                Respuesta2.Visible = false;
                Respuesta3.Visible = false;
            }
            if (conta == 2)
            {
                Respuesta1.Visible = true;
                Respuesta2.Visible = true;
                Respuesta3.Visible = false;
            }
            if (conta == 3)
            {
                Respuesta1.Visible = true;
                Respuesta2.Visible = true;
                Respuesta3.Visible = true;
            }

        }

        private void Respuesta5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
