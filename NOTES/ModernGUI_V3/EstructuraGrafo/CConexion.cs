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


        //Nodo destino de la conexion realizada
        public CNodos nodoDestino;
        public int peso;

        private SqlConnection conexion;
        private string servidor = "localhost";
        private string bd = "catedraped";
        private string user = "root";
        private string password = "";
        private string cadenaConexion;

        public CConexion()
        {
            cadenaConexion =
                "Data Source=" + servidor +
                ";User id=" + user +
                ";password=" + password +
                ";Database=" + bd;
        }



        public CConexion(int peso)
        {
            nodoDestino = new CNodos();
            this.peso = peso;
        }

        public CConexion(CNodos nodo)
        {
            nodoDestino = nodo;
        }

       

        public SqlConnection GetConexion()
        {
            if(conexion == null)
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
            }
            return conexion;
        }


    }
}
