using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorT.ClasesSistema
{
    public class Anotacion : CNodos
    {
        public string titulo;
        public string cuerpo;

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

        public Anotacion(string titulo, string cuerpo)
        {
            this.titulo = titulo;
            this.cuerpo = cuerpo;
            setID(2, titulo);
        }
    }
}

