using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorT.ClasesNodos
{
    public class Tarea : CNodos
    {
        private string titulo;
        private string cuerpo;
        private DateTime fechaEntrega;

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

        public Tarea(string titulo, string cuerpo, DateTime fechaEntrega)
        {
            this.Titulo = titulo;
            this.Cuerpo = cuerpo;
            this.FechaEntrega = fechaEntrega;
            setID(4, titulo);
        }
    }
}
