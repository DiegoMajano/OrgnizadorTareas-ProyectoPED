using AdministradorT;
using AdministradorT.ClasesNodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            conexion = new CConexion();
        }

        public void ActualizarForm(CGrafo grafo, bool AlGrafo)
        {
            tabAnotaciones.TabPages.Clear();
            List<Anotacion> anotaciones = conexion.ObtenerTodasLasAnotaciones(); // Obtener todas las materias de la base de datos
            if (AlGrafo)
            {
                grafo.AgregarNodos(2, anotaciones: anotaciones);
            }

            foreach (Anotacion anotacion in anotaciones)
            {
                // Crear una nueva TabPage para mostrar los datos de la anotacion
                TabPage tp = new TabPage();
                tp.Text = anotacion.ID; // Usar un identificador único de la anotacion como texto de la TabPage

                // Crear y configurar los controles para mostrar los datos de la anotacion
                Label titulo = new Label();
                titulo.AutoSize = true;
                titulo.Location = lbltit.Location;
                titulo.Font = lbltit.Font;
                titulo.Anchor = lbltit.Anchor;
                titulo.Text = "Nombre: " + anotacion.Titulo;
                tp.Controls.Add(titulo);
                                
                Label cuerpo = new Label();
                cuerpo.AutoSize = true;
                cuerpo.Location = lblcuer.Location;
                cuerpo.Text = anotacion.Cuerpo;
                tp.Controls.Add(cuerpo);

                Button Editar = new Button();
                Editar.AutoSize = true;
                Editar.Visible = true;
                Editar.Text = "Editar";
                Editar.Font = btnEditar.Font;
                Editar.Anchor = btnEditar.Anchor;
                Editar.FlatStyle = btnEditar.FlatStyle;
                Editar.Location = btnEditar.Location;
                Editar.Click += EditarAnotacion_Click;
                tp.Controls.Add(Editar);

                // Agregar la TabPage al TabControl
                tabAnotaciones.TabPages.Add(tp);
            }
        }
        private void EditarAnotacion_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            if (boton != null)
            {
                Materia materia = boton.Tag as Materia;

                MessageBox.Show("Listo se editó :D");
            }
        }
    }
}
