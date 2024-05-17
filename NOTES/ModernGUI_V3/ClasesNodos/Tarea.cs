﻿    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorT.ClasesNodos
{

    public enum EstadoTarea
    {
        Pendiente,
        Finalizada
    }

    // hacer el enum del estado de la tarea
    public class Tarea : CNodos
    {
        private string titulo;
        private string cuerpo;
        private DateTime fechaEntrega;
        private EstadoTarea estadoTarea;
        private int prioridad;

        public string Titulo
        {
            get { return titulo; } set { titulo = value; }
        }
        public string Cuerpo
        {
            get { return cuerpo; } set { cuerpo = value; }
        }
        public DateTime FechaEntrega
        {
            get { return fechaEntrega; } set { fechaEntrega = value; }
        }
        public EstadoTarea EstadoTarea
        {
            get { return estadoTarea; } set { estadoTarea = value; }
        }
        public int Prioridad
        {
            get { return prioridad; } set { prioridad = value; }
        }

        public Tarea(string titulo, string cuerpo, DateTime fechaEntrega, int prioridad = 1)
        {
            this.Titulo = titulo;
            this.Cuerpo = cuerpo;
            this.FechaEntrega = fechaEntrega;
            this.Prioridad = prioridad;
            this.EstadoTarea = EstadoTarea.Pendiente;
            setID(4, titulo);
        }
        
        public Tarea(string ID, string titulo, string cuerpo, DateTime fechaEntrega, string estado)
        {
            this.ID = ID;
            this.Titulo = titulo;
            this.Cuerpo = cuerpo;
            this.FechaEntrega = fechaEntrega;
            this.EstadoTarea = estado == EstadoTarea.Pendiente.ToString() ? EstadoTarea.Pendiente : EstadoTarea.Finalizada;
        }

        public void CompletarTarea()
        {
            this.EstadoTarea = EstadoTarea.Finalizada;
        }
    }
}
