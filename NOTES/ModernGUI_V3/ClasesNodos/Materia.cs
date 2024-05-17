using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace AdministradorT.ClasesNodos
{
    public class Materia : CNodos
    {
        // atributos
        public string nombre;
        public TimeSpan horaClase;
        private List<string> dias;
        public string docente;
        public string salon;

        // propiedades
        public string Nombre
        {
            get { return nombre; } set { nombre = value; }
        }
        public TimeSpan HoraClase
        {
            get { return horaClase; } set { horaClase = value; }
        }
        public List<string> Dias
        {
            get { return dias; } set { dias = value; }
        }
        public string Docente
        {
            get { return docente; } set { docente = value; }
        }
        public string Salon
        {
            get { return salon; } set { salon = value; }
        }

        public int IdMateria { get; internal set; }

        public Materia(string nombre, TimeSpan horaClase, List<string> dias, string docente, string salon)
        {
            this.Nombre = nombre;
            this.HoraClase = horaClase;
            this.Dias = dias;
            this.Docente = docente;
            this.Salon = salon;
            
            setID(1, nombre);
        }

        public Materia(string ID, string nombre, TimeSpan horaClase, List<string> dias, string docente, string salon)
        {
            this.ID = ID;
            this.nombre = nombre;
            this.HoraClase = horaClase;
            this.Dias = dias;
            this.Docente = docente;
            this.Salon = salon;
        }
    }
}
