using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorT
{
    public class CNodos
    {
        //El valor es momentaneo (pa cambia :D)
        private string id;
        public string ID
        {
            get { return id; }
        }
        public List<CConexion> listaAdyacencia; //Lista de adyacencia para los nodos (Solo para el principal)

        public CNodos() 
        { 
            listaAdyacencia = new List<CConexion>();
        }

        public void setID(int tipo, string nombre)
        {
            this.id = GenerarID(tipo, nombre);
        }

        //funcion para la creacion de el id
        private string GenerarID(int tipo, string nombre)
        {
            string id = "";
            int[] numero = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Random rand = new Random();
            switch (tipo)
            {
                case 1: //Tipo 1: materia
                    id += "M";
                    break;
                case 2: //Tipo 2: anotacion
                    id += "A";
                    break;
                case 3: //Tipo 3: recordatorio
                    id += "R";
                    break;
                case 4: // Tipo 4: tarea
                    id += "T";
                    break;
            }
            id += nombre[0];
            for (int i = 0; i == 2; i++)
            {
                id += numero[rand.Next(0, 11)].ToString();
            }
            return id;
        }
    }
}
