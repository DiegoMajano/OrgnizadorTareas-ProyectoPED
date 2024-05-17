using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministradorT.Conexion
{
    internal class conectbdd
    {
        SqlConnection conex = new SqlConnection();
        static string servidor = "localhost";
        static string bd = "catedraPED";
        static string usuario = "root";
        static string password = "root";
        static string puerto = "3387";
        string cadenaConexion = "server" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";
        public SqlConnection establecerConexion()
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();

                MessageBox.Show("Se logró a la Base de Datos Correctamente");
            }
            catch (SqlException e)
            {
                MessageBox.Show("No se pudo conectar a la base de datos, erro: " + e.ToString());
                return conex;
            }
        }
    }
}
