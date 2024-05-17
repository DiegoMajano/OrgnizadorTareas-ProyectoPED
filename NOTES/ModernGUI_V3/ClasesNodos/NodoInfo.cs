using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorT.ClasesNodos
{
    public class NodoInfo
    {
        private CNodos nodo;
        private CGrafo grafo;
        public CNodos Nodo
        {
            get { return nodo; } set { nodo = value; }
        }
        public CGrafo Grafo
        {
            get { return grafo; } set{ grafo = value; }
        }
        public NodoInfo(CNodos nodo, CGrafo grafo)
        {
            this.Nodo = nodo;
            this.Grafo = grafo;
        }
    }
}
