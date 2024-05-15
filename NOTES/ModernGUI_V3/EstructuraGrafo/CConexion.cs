using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AdministradorT
{
    public class CConexion
    {
        private SqlConnection conexion;
        private string servidor = "localhost";
        private string bd = "catedraped";
        private string user = "william";
        private string password = "";
        private string cadenaConexion;

        public CConexion()
        {
            cadenaConexion = "Data Source=" + servidor +
                             ";User id=" + user +
                             ";password=" + password +
                             ";Database=" + bd;

            conexion = new SqlConnection(cadenaConexion);
        }

        public bool AbrirConexion()
        {
            try
            {
                conexion.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la conexión: " + ex.Message);
                return false;
            }
        }

        public void CerrarConexion()
        {
            if (conexion != null && conexion.State != System.Data.ConnectionState.Closed)
            {
                conexion.Close();
            }
        }
    }
}
