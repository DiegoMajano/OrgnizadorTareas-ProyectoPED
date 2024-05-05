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
        public int peso;

        public CConexion(int peso)
        {
            nodoDestino = new CNodos();
            this.peso = peso;
        }

        public CConexion(CNodos nodo)
        {
            nodoDestino = nodo;
        }
    }
}
