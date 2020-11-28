using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Nube_de_palabras
{
    public class Interaccion: ConexionBD
    {
        public Boolean verificarConexion()
        {
            return ConBD.State.ToString().Equals("Open");
        }

    }
}
