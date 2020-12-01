using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Nube_de_palabras
{
    public class ConexionBD
    {
        protected OleDbConnection connection;
        /// <summary>
        /// conexion con la BD.
        /// </summary>
        protected OleDbConnection ConBD
        {
            get
            {
                connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDNube.accdb");
                connection.Open();
                return connection;
            }
        }
    }
}
