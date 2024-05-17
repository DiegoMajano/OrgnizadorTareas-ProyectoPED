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
    public partial class frmMaterias : Form
    {
        public CGrafo grafoMain = new CGrafo();
        private frmNuevaMateria nuevaMateria = new frmNuevaMateria();
        private CConexion conexion;
        public frmMaterias()
        {
            InitializeComponent();
            conexion = new CConexion();
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = pnlFormularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnlFormularios.Controls.Add(formulario);
                pnlFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.Show();
                formulario.BringToFront();
            }
        }

        //Funcion que actualiza los datos de el tab page para que aparezcan los datos de el grafo
        public void ActualizarForm(CGrafo grafo)
        {
            tabMaterias.TabPages.Clear();
            List<Materia> materias = conexion.ObtenerTodasLasMaterias(grafo); // Obtener todas las materias de la base de datos

            foreach (Materia materia in materias)
            {
                // Crear una nueva TabPage para mostrar los datos de la materia
                TabPage tp = new TabPage();
                tp.Text = materia.ID; // Usar un identificador único de la materia como texto de la TabPage

                // Crear y configurar los controles para mostrar los datos de la materia
                Label nombre = new Label();
                nombre.AutoSize = true;
                nombre.Location = new Point(10, 10);
                nombre.Text = "Nombre: " + materia.Nombre;
                tp.Controls.Add(nombre);

                Label dias = new Label();
                dias.Text = "Días: ";
                dias.AutoSize = true;
                dias.Location = new Point(10, 90);
                foreach (var dia in materia.Dias)
                {                    
                    dias.Text += $"{dia} ";                    
                }
                tp.Controls.Add(dias);

                Label horaClase = new Label();
                horaClase.AutoSize = true;
                horaClase.Location = new Point(10, 30);
                horaClase.Text = "Hora de Clase: " + materia.HoraClase.ToString();
                tp.Controls.Add(horaClase);

                Label docente = new Label();
                docente.AutoSize = true;
                docente.Location = new Point(10, 50);
                docente.Text = "Docente: " + materia.Docente;
                tp.Controls.Add(docente);

                Label salon = new Label();
                salon.AutoSize = true;
                salon.Location = new Point(10, 70);
                salon.Text = "Salón: " + materia.Salon;
                tp.Controls.Add(salon);

                Button Editar = new Button();
                Editar.AutoSize = true;
                Editar.Location = new Point(tabMaterias.Width - 140, 10);
                Editar.Text = "Editar Materia";
                tp.Controls.Add(Editar);

                // Agregar la TabPage al TabControl
                tabMaterias.TabPages.Add(tp);
            }
        }

    }
}