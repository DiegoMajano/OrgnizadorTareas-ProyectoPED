using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorT.ClasesNodos
{
    public class Anotacion : CNodos
    {
        private string titulo;
        private string cuerpo;
        private string idMateria;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Cuerpo
        {
            get { return cuerpo; }
            set { cuerpo = value; }
        }

        public string IdMateria
        {
            get { return idMateria; }
            set { idMateria = value; }
        }

        public Anotacion(string titulo, string cuerpo)
        {
            this.Titulo = titulo;
            this.Cuerpo = cuerpo;
            setID(2, titulo);
            
        }

        public Anotacion(string ID, string titulo, string cuerpo)
        {
            this.ID = ID;
            this.Titulo = titulo;
            this.Cuerpo = cuerpo;
        }
    }
}

