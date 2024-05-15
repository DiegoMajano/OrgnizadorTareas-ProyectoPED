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

        public int idMateria
        {
            get { return idMateria; }
            set { idMateria = value; }
        }

        public Anotacion(string titulo, string cuerpo)
        {
            this.titulo = titulo;
            this.cuerpo = cuerpo;
            setID(2, titulo);
            
        }
    }
}

