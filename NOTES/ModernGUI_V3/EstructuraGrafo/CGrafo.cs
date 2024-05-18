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

        public CNodos AgregarNodos(int tipo, string nombre, TimeSpan hora = new TimeSpan(), List<string> dias=null, string cuerpo = "", 
                                    string docente = "", string salon = "", DateTime aRecordar = new DateTime(), string titulo = "",
                                        DateTime fechaEntrega = new DateTime())
        {
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
                    Tarea tarea = new Tarea(nombre, cuerpo, fechaEntrega);
                    nodos.Add(tarea);
                    nodosTarea.Add(tarea);
                    return tarea;
            }
            return null;
        }

        public bool AgregarNodo(CNodos nodo)
        {
            int antiguo = nodos.Count;
            nodos.Add(nodo);
            if (nodos.Count > antiguo)
                return true;            
            return false;            
        }          

        public bool AgregarNodos(int tipo, List<Materia> materias = null, List<Anotacion> anotaciones = null, List<Recordatorio> recordatorios = null, List<Tarea> tareas = null) 
        {
            switch (tipo)
            {
                case 1: // si es materia 
                    foreach (var nodoMateria in materias)
                    {
                        nodos.Add(nodoMateria);
                        nodosMaterias.Add(nodoMateria);
                    }
                 return true;
                case 2: // si es anotacion
                    foreach (var nodoAnotacion in anotaciones)
                    {
                        nodos.Add(nodoAnotacion);
                        nodosAnotaciones.Add(nodoAnotacion);                            
                    }
                    return true;
                case 3: // si es recordatorio
                    foreach (var nodoRecordatorio in recordatorios)
                    {
                        nodos.Add(nodoRecordatorio);
                        nodosRecordatorios.Add(nodoRecordatorio);
                    }
                    return true;
                case 4: // si es tarea
                    foreach (var nodoTarea in tareas)
                    {
                        nodos.Add(nodoTarea);
                        nodosTarea.Add(nodoTarea);
                    }
                    return true;
            }
            return false;
        }

        public bool AgregarArco(CNodos origen, CNodos destino)
        {
            if (origen.listaAdyacencia.Find(v => v.nodoDestino == destino) == null) // se verifica que exista el nodo destino en la lista de adyacencia del nodo origen
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
        public CNodos EliminarNodo(string id)
        {
            CNodos nodoE = BuscarNodo(id);
            
            nodos.Remove(nodoE);

            foreach (CNodos nodo in nodos)
            {
                foreach (CConexion arco in nodo.listaAdyacencia)
                {
                    if (arco.nodoDestino.ID == id)
                    {
                        nodo.listaAdyacencia.Remove(arco);
                        break;
                    }
                }
            }
            return nodoE;
        }

        public CNodos EliminarNodo(int tipo, string id)
        {
            switch (tipo)
            {
                case 1:
                    Materia materia = (Materia) EliminarNodo(id);
                    nodosMaterias.Remove(materia);
                    return materia;
                case 2:
                    Anotacion anotacion = (Anotacion) EliminarNodo(id);
                    nodosAnotaciones.Remove(anotacion);
                    return anotacion;
                case 3:
                    Recordatorio recordatorio = (Recordatorio) EliminarNodo(id);
                    nodosRecordatorios.Remove(recordatorio);
                    return recordatorio;
                case 4:
                    Tarea tarea = (Tarea) EliminarNodo(id);
                    nodosTarea.Remove(tarea);
                    return tarea;
                default:
                    return null;
            }
        }

        public bool EliminarArco(CNodos nodoOrigen, CNodos nodoDestino)
        {
            // Buscar los vértices de origen y destino en el grafo
            CNodos nOrigen = BuscarNodo(nodoOrigen.ID);
            CNodos nDestino = BuscarNodo(nodoDestino.ID);

            if (nOrigen != null && nDestino != null)
            {
                // Eliminar el arco de la lista de adyacencia del vértice origen
                return nOrigen.listaAdyacencia.RemoveAll(arco => arco.nodoDestino == nDestino) > 0;
            }
            return false;
        }

        private void RecargarNodos()
        {
            nodos.Clear();
            nodosMaterias.Clear();
            nodosAnotaciones.Clear();
            nodosRecordatorios.Clear();
            nodosTarea.Clear();
        }
    }
}
