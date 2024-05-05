using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorT
{
    class CConexion
    {
        //Nodo destino de la conexion realizada
        public CNodos nodoDestino;

        public CConexion()
        {
            nodoDestino = new CNodos();
        }

        public CConexion(CNodos nodo)
        {
            nodoDestino = nodo;
        }
    }
}
