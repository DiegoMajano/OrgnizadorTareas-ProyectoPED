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
<<<<<<< HEAD
           
            tabMaterias.TabPages.Clear();
            List<Materia> materias = conexion.ObtenerTodasLasMaterias(); // Obtener todas las materias de la base de datos
            if (AlGrafo)                                 
                grafo.AgregarNodos(1, materias: materias);                

            foreach (Materia materia in materias)
            {
                // Crear una nueva TabPage para mostrar los datos de la materia
=======
                tabMaterias.TabPages.Clear();
                List<Materia> materias = conexion.ObtenerTodasLasMaterias(); // Obtener todas las materias de la base de datos
                if (AlGrafo)                                 
                    grafo.AgregarNodos(1, materias: materias);
                

                foreach (Materia materia in materias)
                {
                    // Crear una nueva TabPage para mostrar los datos de la materia
>>>>>>> 6b96de676a3c09b83d70afbfb76bddb0051d8835
                TabPage tp = new TabPage();
                tp.BackColor = tabPage1.BackColor;
                tp.Font = tabPage1.Font;
                tp.Text = materia.ID; // Usar un identificador único de la materia como texto de la TabPage

                // Crear y configurar los controles para mostrar los datos de la materia
                Label nombre = new Label();
                nombre.AutoSize = true;
                nombre.Location = new Point(10, 10);
                nombre.Text = "Nombre: " + materia.Nombre;
                tp.Controls.Add(nombre);
                nombre.Font = lblNombre.Font;
                nombre.Location = lblNombre.Location;

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
                Editar.Click += btnEditar_Click;
                tp.Controls.Add(Editar);

                /*Button Eliminar = new Button();
                Eliminar.AutoSize = true;
                Eliminar.Text = "Editar Materia";
                Eliminar.Tag = materia;
                Eliminar.FlatStyle = btnEliminarMateria.FlatStyle;
                Eliminar.Location = btnEliminarMateria.Location;
                Eliminar.Click += btnEliminarMateria_Click;
                tp.Controls.Add(Eliminar);*/

                Label dias = new Label();
                dias.Text = "Días: ";
                dias.AutoSize = true;
                dias.Location = new Point(10, 90);
                foreach (var dia in materia.Dias)
                {
                    dias.Text += $"{dia} ";
                }
                tp.Controls.Add(dias);
                dias.Font = lblDias.Font;
<<<<<<< HEAD
                dias.Location = lblDias.Location;


                Label horaClase = new Label();
                horaClase.AutoSize = true;
                horaClase.Location = new Point(10, 30);
                horaClase.Text = "Hora de Clase: " + materia.HoraClase.ToString();
                tp.Controls.Add(horaClase);
                horaClase.Font = lblHora.Font;
                horaClase.Location = lblHora.Location;

                Label docente = new Label();
                docente.AutoSize = true;
                docente.Location = new Point(10, 50);
                docente.Text = "Docente: " + materia.Docente;
                tp.Controls.Add(docente);
                docente.Font = lblDocente.Font;
                docente.Location = lblDocente.Location;

                Label salon = new Label();
                salon.AutoSize = true;
                salon.Location = new Point(10, 70);
                salon.Text = "Salón: " + materia.Salon;
                tp.Controls.Add(salon);
                salon.Font = lblSalon.Font;
                salon.Location = lblSalon.Location;


                Button Editar = new Button();
                Editar.AutoSize = true;
                Editar.FlatStyle = btnEditar.FlatStyle;
                Editar.Location = btnEditar.Location;
                Editar.Size = btnEditar.Size;
                Editar.BackColor = btnEditar.BackColor;
                Editar.Text = "Editar Materia";

                tp.Controls.Add(Editar);
                Editar.Font = btnEditar.Font;
                Editar.Location = btnEditar.Location;


                Button Eliminar = new Button();
                Eliminar.AutoSize = true;
                Eliminar.FlatStyle = btnEliminarM.FlatStyle;
                Eliminar.Location = btnEliminarM.Location;
                Eliminar.Size = btnEliminarM.Size;
                Eliminar.BackColor = btnEliminarM.BackColor;
                Eliminar.Text = "Eliminar Materia";

                tp.Controls.Add(Eliminar);
               Eliminar.Font = btnEliminarM.Font;
                Eliminar.Location = btnEliminarM.Location;


=======
                dias.Location = lblDias.Location;               
>>>>>>> df17e1667757f96c9ef4e383d78f70d2914dd7c2
                // Agregar la TabPage al TabControl
                tabMaterias.TabPages.Add(tp);
            }
        }

        private void btnEliminarMateria_Click(object sender, EventArgs e)
        {
            NodoInfo nodoInfo;
            Materia materia;
            CGrafo grafo;

            Button boton = sender as Button;
            if (boton != null)
            {
                nodoInfo = boton.Tag as NodoInfo;
                materia = (Materia)nodoInfo.Nodo;
                grafo = nodoInfo.Grafo;

                DialogResult result = MessageBox.Show($"¿Estás seguro de eliminar la materia {materia.nombre}?, los cambios realizados no se podrán recuperar", "Adverdencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Materia materiaEliminada= (Materia)grafo.EliminarNodo(3, materia.ID);
                    if (materiaEliminada != null && !conexion.EliminarMateria(materia))
                    {
                        ActualizarForm(grafo, false);
                        MessageBox.Show($"Se ha eliminado correctamente la Materia: {materiaEliminada.nombre}", "Eliminar Materia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show($"No se ha eliminado correctamente la Materia: {materiaEliminada.nombre}", "Eliminar Materia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tabMaterias_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tb = (TabControl)sender;
            Brush textBrush;
            Rectangle tabRec = tb.GetTabRect(e.Index);

            Color tbColor;

            tbColor = Color.LightSteelBlue;

            e.Graphics.FillRectangle(new SolidBrush(tbColor), tabRec);
            textBrush = new SolidBrush(Color.Black);

            string tabText = tb.TabPages[e.Index].Text;
            StringFormat stringFlags = new StringFormat();
            stringFlags.Alignment = StringAlignment.Center;
            stringFlags.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString(tabText, tb.Font, textBrush, tabRec, stringFlags);

            tb.TabPages[e.Index].BackColor = tbColor;
        }

        private void btnEditar_Click(object sender, EventArgs e)
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
    }
}