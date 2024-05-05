using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorT.ClasesSistema
{
    public class Materia : CNodos
    {
        // atributos

        private string nombre;
        private DateTime horaClase;
        private string docente;
        private string salon;

        // propiedades
        public string Nombre
        {
            get { return nombre; } set { nombre = value; }
        }
        public DateTime HoraClase
        {
            get { return horaClase; } set { horaClase = value; }
        }
        public string Docente
        {
            get { return docente; } set { docente = value; }
        }
        public string Salon
        {
            get { return salon; } set { salon = value; }
        }

        
        
    }
}
