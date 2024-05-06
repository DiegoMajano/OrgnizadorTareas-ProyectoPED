using AdministradorT.ClasesSistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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

        public CNodos AgregarNodos(int tipo, string nombre, DateTime hora = new DateTime(), string cuerpo = "", string docente = "", string salon = "")
        {
            // SE PODRIA HACER UN SWITCH AQUI, SEGUN EL TIPO DE NODO QUE SE QUIERE CREAR ES COMO SE VA A GENERAR, SI ES MATERIA, ANOTACION, ETC
            switch (tipo)
            {
                case 1: //Creacion de nodo para la materia
                    Materia materia = new Materia(nombre, hora, docente, salon);//Faltan los valores
                    nodos.Add(materia);
                    return materia;
                case 2:
                    Anotacion anotacion = new Anotacion(nombre, cuerpo);
                    nodos.Add(anotacion);
                    return anotacion;
                case 3:
                    Recordatorio recordatorio = new Recordatorio(nombre, hora);
                    nodos.Add(recordatorio);
                    return recordatorio;
            }
            return null;
        }

        public void AgregarNodo(CNodos nodo)
        {
            nodos.Add(nodo);
        }

        public CNodos BuscarNodo(string valor)
        {
            return nodos.Find(n => n.ID == valor);
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
