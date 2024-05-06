using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorT
{
    public class CNodos
    {
        //El valor es momentaneo (pa cambia :D)
        private string id;
        public string ID
        {
            get { return id; }
            set { id = GenerarID(); }
        }
        public List<CConexion> listaAdyacencia; //Lista de adyacencia para los nodos (Solo para el principal)

        public CNodos() 
        { 
            listaAdyacencia = new List<CConexion>();
        }

        // crear funcion para generar el id segun el tipo de nodo - PENDIENTE XD
        //         public string id = "AC001"; <- ejemplo

        private string GenerarID()
        {
            return id;
        }
    }
}
