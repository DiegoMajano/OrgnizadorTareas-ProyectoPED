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
        bool actualizado = false;
        //Funcion que actualiza los datos de el tab page para que aparezcan los datos de el grafo
        public void ActualizarForm(CGrafo grafo,bool AlGrafo)
        {
           
                tabMaterias.TabPages.Clear();
                List<Materia> materias = conexion.ObtenerTodasLasMaterias(); // Obtener todas las materias de la base de datos
                if (AlGrafo)                                 
                    grafo.AgregarNodos(1, materias: materias);
                

                foreach (Materia materia in materias)
                {
                    // Crear una nueva TabPage para mostrar los datos de la materia
                    TabPage tp = new TabPage();
                    tp.Text = materia.ID; // Usar un identificador único de la materia como texto de la TabPage

                    // Crear y configurar los controles para mostrar los datos de la materia
                    Label nombre = new Label();
                    nombre.Font = lblPrueba.Font;

                    nombre.AutoSize = true;
                    nombre.Location = new Point(10, 10);
                    nombre.Text = "Nombre: " + materia.Nombre;
                    nombre.Location = lblPrueba.Location;
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
                    horaClase.Location = lblHora.Location;

                    horaClase.Text = "Hora de Clase: " + materia.HoraClase.ToString();
                    tp.Controls.Add(horaClase);

                    Label docente = new Label();
                    docente.AutoSize = true;
                    docente.Location = lblDocente.Location;
                    docente.Text = "Docente: " + materia.Docente;
                    tp.Controls.Add(docente);

                    Label salon = new Label();
                    salon.AutoSize = true;
                    salon.Location = lblSalon.Location;
                    salon.Text = "Salón: " + materia.Salon;
                    tp.Controls.Add(salon);

                    Button Editar = new Button();
                    Editar.AutoSize = true;
                    Editar.Text = "Editar Materia";
                    Editar.Tag = materia;
                    Editar.FlatStyle = btnEditar.FlatStyle;
                    Editar.Location = btnEditar.Location;
                    Editar.Click += EditarMateria_Click;
                    tp.Controls.Add(Editar);

                    Button Eliminar = new Button();
                    Eliminar.AutoSize = true;
                    Eliminar.Text = "Eliminar Materia";
                    Eliminar.Tag = materia;
                    Eliminar.FlatStyle = btnEliminarMateria.FlatStyle;
                    Eliminar.Location = btnEliminarMateria.Location;
                    Eliminar.Click += btnEliminarMateria_Click;
                    tp.Controls.Add(Eliminar);


                    // Agregar la TabPage al TabControl
                    tabMaterias.TabPages.Add(tp);
            }
        }

        private void EditarMateria_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            if (boton != null)
            {
                nuevaMateria.Visible = false;
                nuevaMateria.control = false;
                nuevaMateria.ShowDialog();
                Materia materia = boton.Tag as Materia;
                if (nuevaMateria.control) // tiene que ser un nuevo control porque sino se crea un nuevo nodo porque es el mismo control que se utiliza para agregar e insertar un nuevo nodo
                {
                    materia.nombre = nuevaMateria.nombreM;
                    materia.Salon = nuevaMateria.salon;
                    materia.Dias = nuevaMateria.dias;
                    materia.Docente = nuevaMateria.nombreD;
                    materia.horaClase = nuevaMateria.horaClase;
                    if (conexion.ActualizarMateria(materia))
                    {
                        MessageBox.Show("Se ha actualizado la materia sin ningun problema", "Materias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar la materia", "Materias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnEliminarMateria_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            DialogResult resultado = MessageBox.Show("Esta seguro que quiere eliminar esta materia?", "Materia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes) // andate al frmRecordatorio y mira como hice esta parte de acá
            {
                Materia materia = boton.Tag as Materia;
                if (conexion.EliminarMateria(materia))
                {
                    MessageBox.Show("Se ha eliminado la materia sin ningun incomveniente", "Materias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}