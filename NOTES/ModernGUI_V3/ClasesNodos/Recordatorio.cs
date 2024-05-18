using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorT.ClasesNodos
{
    public class Recordatorio : CNodos
    {
        private string titulo;
        private DateTime arecordar;
        private string cuerpo;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public DateTime aRecordar
        {
            get { return arecordar; }
            set { arecordar = value; }
        }
        public string Cuerpo
        {
            get { return cuerpo; }
            set { cuerpo = value; }
        }

        public Recordatorio(string titulo, DateTime arecordar, string cuerpo)
        {
            this.Titulo = titulo;
            this.aRecordar = arecordar;
            this.Cuerpo = cuerpo;
            setID(3, titulo);
        }
        public Recordatorio(string codigo, string titulo, DateTime arecordar, string cuerpo)
        {
            this.ID = codigo;
            this.Titulo = titulo;
            this.aRecordar = arecordar;
            this.Cuerpo = cuerpo;
        }
    }
}
