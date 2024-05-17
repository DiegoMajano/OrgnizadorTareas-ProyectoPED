    using System;
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

        public Tarea(string titulo, string cuerpo, DateTime fechaEntrega)
        {
            this.Titulo = titulo;
            this.Cuerpo = cuerpo;
            this.FechaEntrega = fechaEntrega;
            this.EstadoTarea = EstadoTarea.Pendiente;
            setID(4, titulo);
        }
        

        public void CompletarTarea()
        {
            this.EstadoTarea = EstadoTarea.Finalizada;
        }
    }
}
