using AdministradorT.ClasesNodos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorT
{
    public class CGrafo
    {
        //Lista de todos los nodos que se encuentran en el grafo
        public List<CNodos> nodos;
        public List<Materia> nodosMaterias;
        public List<Anotacion> nodosAnotaciones;
        public List<Recordatorio> nodosRecordatorios;
        public List<Tarea> nodosTarea;

        public CGrafo()
        { // crear instancias de las listas
            nodos = new List<CNodos>();
            nodosMaterias = new List<Materia>();
            nodosAnotaciones = new List<Anotacion>();
            nodosRecordatorios = new List<Recordatorio>();
            nodosTarea = new List<Tarea>();
        }

        public CNodos AgregarNodos(int tipo, string nombre, TimeSpan hora = new TimeSpan(), List<string> dias=null, string cuerpo = "", string docente = "", string salon = "", DateTime aRecordar = new DateTime(), string titulo = "", DateTime fechaEntrega = new DateTime())
        {
            // SE PODRIA HACER UN SWITCH AQUI, SEGUN EL TIPO DE NODO QUE SE QUIERE CREAR ES COMO SE VA A GENERAR, SI ES MATERIA, ANOTACION, ETC
            switch (tipo)
            {
                case 1: //Creacion de nodo para la materia
                    Materia materia = new Materia(nombre, hora, dias, docente, salon);//Faltan los valores
                    nodos.Add(materia);
                    nodosMaterias.Add(materia);
                    return materia;
                case 2: // creacion de nodo para la anotacion
                    Anotacion anotacion = new Anotacion(nombre, cuerpo);
                    nodos.Add(anotacion);
                    nodosAnotaciones.Add(anotacion);
                    return anotacion;
                case 3: // creacion del nodo para el recordatorio
                    Recordatorio recordatorio = new Recordatorio(nombre, aRecordar, cuerpo);
                    nodos.Add(recordatorio);
                    nodosRecordatorios.Add(recordatorio);
                    return recordatorio;
                case 4: // creacion del nodo para la tarea
                    Tarea tarea = new Tarea(titulo, cuerpo, fechaEntrega);
                    nodos.Add(tarea);
                    nodosTarea.Add(tarea);
                    return tarea;
            }
            return null;
        }

        public bool AgregarNodo(CNodos nodo)
        {
            int antiugo = nodos.Count;
            nodos.Add(nodo);
            if (nodos.Count > antiugo)
                return true;            
            return false;            
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

        public CNodos BuscarNodo(string valor)
        {
            return nodos.Find(n => n.ID == valor);
        }

        public CNodos BuscarNodo(int tipo, string nombre)
        {
            switch (tipo)
            {
                case 1: // si es materia 
                    foreach  (Materia nodoMateria in nodosMaterias)
                    {
                        if(nodoMateria.Nombre == nombre)
                            return nodoMateria;
                    }
                    break; 
                case 2: // si es anotacion
                    foreach (Anotacion nodoAnotacion in nodosAnotaciones)
                    {
                        if (nodoAnotacion.Titulo == nombre)
                            return nodoAnotacion;
                    }
                    break; 
                case 3: // si es recordatorio
                    foreach (Recordatorio nodoRecordatorio in nodosRecordatorios)
                    {
                        if (nodoRecordatorio.Titulo == nombre)
                            return nodoRecordatorio;
                    }
                    break;
                case 4: // si es tarea
                    foreach (Tarea nodoTarea in nodosTarea)
                    {
                        if (nodoTarea.Titulo == nombre)
                            return nodoTarea;
                    }
                    break;
            }
            return null;
        }
    }
}
