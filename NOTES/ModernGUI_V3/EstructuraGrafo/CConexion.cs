using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministradorT
{
    public class CConexion
    {

        SqlConnection conex = new SqlConnection();
        //Nodo destino de la conexion realizada
        public CNodos nodoDestino;
        public int peso;
        
        public static string servidor = "localhost";
        public static string bd = "catedraPED";
        public static string usuario = "root";
        public static string password = "root";
        public static string puerto = "3387";
        public string cadenaConexion = "server" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        public CConexion(int peso)
        {
            nodoDestino = new CNodos();
            this.peso = peso;
        }

        public CConexion(CNodos nodo)
        {
            nodoDestino = nodo;
        }

        public CConexion()
        {
        }

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
                
            }
            return conex;
        }
    }
}
