using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorT
{
    class CGrafo
    {
        //Lista de todos los nodos que se encuentran en el grafo
        public List<CNodos> nodos;

        public CGrafo()
        {
            nodos = new List<CNodos>();
        }

        public CNodos AgregarNodos(string valor, int peso)
        {
            CNodos nodo = new CNodos(valor, peso);
            nodos.Add(nodo);
            return nodo;
        }

        public void AgregarNodo(CNodos nodo)
        {
            nodos.Add(nodo);
        }

        public CNodos BuscarNodo(string valor)
        {
            return nodos.Find(n => n.valor == valor);
        }

        public bool AgregarArco(CNodos origen, CNodos destino)
        {
            if (origen.listaAdyacencia.Find(v => v.nodoDestino == destino) == null)
            {
                origen.listaAdyacencia.Add(new CConexion(destino));
                return true;
            }
            return false;
        }
    }
}
