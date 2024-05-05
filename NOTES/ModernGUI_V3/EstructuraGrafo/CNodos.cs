using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorT
{
    class CNodos
    {
        //El valor es momentaneo (pa cambia :D)
        public string valor;
        private int peso;

        public List<CConexion> listaAdyacencia; //Lista de adyacencia para los nodos (Solo para el principal)
        public CNodos Principal; //Nodo de la materia

        public int Peso
        {
            get { return peso; } set { peso = value; } 
        }

        public CNodos(string valor, int peso)
        {
            this.valor = valor;
            this.peso = peso;
            listaAdyacencia = new List<CConexion>();
        }

        //Si no recibe ningun parametro lo deja vacio
        public CNodos() : this("",0) { }
    }
}
