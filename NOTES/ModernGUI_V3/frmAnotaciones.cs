using AdministradorT;
using AdministradorT.ClasesNodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernGUI_V3
{
    public partial class frmAnotaciones : Form
    {
        public CGrafo grafoMain = new CGrafo();
        private frmNuevaAnotacion nuevaAnotacion = new frmNuevaAnotacion();
        private CConexion conexion;

        public frmAnotaciones()
        {
            InitializeComponent();
        }

        public void ActualizarForm(CGrafo grafo)
        {/*
            tabAnotaciones.TabPages.Clear();
            List<Anotacion> anotaciones = conexion.ObtenerTodasLasMaterias(); // Obtener todas las materias de la base de datos

            foreach (Anotacion anotacion in anotaciones)
            {
                // Crear una nueva TabPage para mostrar los datos de la anotacion
                TabPage tp = new TabPage();
                tp.Text = anotacion.ID; // Usar un identificador único de la anotacion como texto de la TabPage

                // Crear y configurar los controles para mostrar los datos de la anotacion
                Label titulo = new Label();
                titulo.AutoSize = true;
                titulo.Location = new Point(10, 10);
                titulo.Text = "Nombre: " + anotacion.Titulo;
                tp.Controls.Add(titulo);
                                
                Label cuerpo = new Label();
                cuerpo.AutoSize = true;
                cuerpo.Location = new Point(10, 30);
                cuerpo.Text = anotacion.Cuerpo;
                tp.Controls.Add(cuerpo);

                // Agregar la TabPage al TabControl
                tabAnotaciones.TabPages.Add(tp);
            }*/
        }
    }
}
