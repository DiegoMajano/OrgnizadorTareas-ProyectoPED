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

namespace AdministradorT
{

    public partial class frmTareas : Form
    {
        public CGrafo grafoMain = new CGrafo();
        private frmNuevaTarea nuevaTarea = new frmNuevaTarea();
        private CConexion conexion;

        public frmTareas()
        {
            InitializeComponent();
            conexion = new CConexion();
        }

        //Funcion que actualiza los datos de el tab page para que aparezcan los datos de el grafo
        public void ActualizarForm(CGrafo grafo, bool alGrafo)
        {
            tabTareas.TabPages.Clear();
            List<Tarea> tareas = conexion.ObtenerTareas(); // Obtener todas las tareas de la base de datos

            if (alGrafo)
                grafo.AgregarNodos(4, tareas: tareas);
            NodoInfo nodoInfo;

            foreach (Tarea tarea in tareas)
            {
                nodoInfo = new NodoInfo(tarea, grafo);
                // Crear una nueva TabPage para mostrar los datos de la tarea
                TabPage tp = new TabPage();
                tp.BackColor = tabPage1.BackColor;
                tp.Font = tabPage1.Font;
                tp.Text = tarea.ID; // Usar un identificador único de la tarea como texto de la TabPage

                // Crear y configurar los controles para mostrar los datos de la tarea
                Label titulo = new Label();
                titulo.AutoSize = true;
                titulo.Location = new Point(10, 10);
                titulo.Text = "Titulo: " + tarea.Titulo;
                titulo.Location = lblTituloT.Location;
                titulo.Font = lblTituloT.Font;
                tp.Controls.Add(titulo);

                Label cuerpo = new Label();
                cuerpo.AutoSize = true;
                cuerpo.Location = new Point(10, 30);
                cuerpo.Text = "Descripción: " + tarea.Cuerpo;
                cuerpo.Location = lblCuerpo.Location;
                cuerpo.Font = lblCuerpo.Font;
                tp.Controls.Add(cuerpo);

                Label fechaEntrega = new Label();
                fechaEntrega.AutoSize = true;
                fechaEntrega.Location = new Point(10, 70);
                fechaEntrega.Text = "Fecha de entrega: " + tarea.FechaEntrega.ToString();
                fechaEntrega.Location = lblFecha.Location;
                fechaEntrega.Font = lblFecha.Font;
                tp.Controls.Add(fechaEntrega);


                Button Editar = new Button();
                Editar.AutoSize = true;
                Editar.Visible = true;
                Editar.Text = "Editar Tarea";
                Editar.Font = btnEditarT.Font;
                Editar.Anchor = btnEditarT.Anchor;
                Editar.FlatStyle = btnEditarT.FlatStyle;
                Editar.Location = btnEditarT.Location;
                Editar.BackColor = btnEditarT.BackColor;
                Editar.Size = btnEditarT.Size;
                Editar.Tag = nodoInfo;
                Editar.Click += EditarTarea_Click;
                tp.Controls.Add(Editar);


                Button Eliminar = new Button();
                Eliminar.AutoSize = true;
                Eliminar.Visible = true;
                Eliminar.Text = "Eliminar Anotación";
                Eliminar.Font = btnEliminarT.Font;
                Eliminar.Anchor = btnEliminarT.Anchor;
                Eliminar.FlatStyle = btnEliminarT.FlatStyle;
                Eliminar.Location = btnEliminarT.Location;
                Eliminar.BackColor = btnEliminarT.BackColor;
                Eliminar.Size = btnEliminarT.Size;
                Eliminar.Tag = nodoInfo;
                Eliminar.Click += EliminarTarea_Click;
                tp.Controls.Add(Eliminar);

                // agregar boton para asignar en compleada la tarea
                Button Completada = new Button();
                Completada.AutoSize = true;
                Completada.Visible = true;
                Completada.Text = "★ Tarea Completada ★";
                Completada.Font = btnTareaC.Font;
                Completada.Location = btnTareaC.Location;
                Completada.Anchor = btnTareaC.Anchor;
                Completada.FlatStyle = btnTareaC.FlatStyle;
                Completada.BackColor = btnTareaC.BackColor;
                Completada.Size = btnTareaC.Size;
                Completada.Click += CompletarTarea_Click;
                Completada.Tag = nodoInfo;
                tp.Controls.Add(Completada);

                // Agregar la TabPage al TabControl
                tabTareas.TabPages.Add(tp);
            }
        }
        private void tabTareas_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tbA = (TabControl)sender;
            Brush textBrush;
            Rectangle tabRec = tbA.GetTabRect(e.Index);

            Color tbAColor;

            tbAColor = Color.LightSteelBlue;


            e.Graphics.FillRectangle(new SolidBrush(tbAColor), tabRec);
            textBrush = new SolidBrush(Color.Black);

            string tabText = tbA.TabPages[e.Index].Text;
            StringFormat stringFlags = new StringFormat();
            stringFlags.Alignment = StringAlignment.Center;
            stringFlags.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString(tabText, tbA.Font, textBrush, tabRec, stringFlags);

            tbA.TabPages[e.Index].BackColor = tbAColor;
        }
        private void CompletarTarea_Click(object sender, EventArgs e) 
        {
            Button boton = sender as Button;
            NodoInfo nodoInfo = boton.Tag as NodoInfo;
            Tarea tarea = (Tarea)nodoInfo.Nodo;
            CGrafo grafo = (CGrafo)nodoInfo.Grafo;

            Tarea Completada = (Tarea)grafo.BuscarNodo(4,tarea.ID);

            if (tarea != null)
            {
                tarea.CompletarTarea();
                conexion.ActualizarTarea(tarea);
                ActualizarForm(grafo,false);
            }
        }

        private void EditarTarea_Click(Object sender, EventArgs e)
        {
            Button boton = sender as Button;
            if (boton != null)
            {
                NodoInfo nodoInfo = boton.Tag as NodoInfo;
                Tarea tarea = (Tarea)nodoInfo.Nodo;
                grafoMain = (CGrafo)nodoInfo.Grafo;

                nuevaTarea.Visible = false;
                nuevaTarea.control = false;
                //nuevaTarea.editar = true;
                nuevaTarea.txtTituloR.Text = tarea.Titulo;
                nuevaTarea.txtCuerpo.Text = tarea.Cuerpo;
                nuevaTarea.cbAnotacionT.Enabled = false;
                nuevaTarea.cbImportanciaPeso.Enabled = false;
                nuevaTarea.cbMateriaT.Enabled = false;
                nuevaTarea.bandera = true;
                nuevaTarea.edicion = true;
                nuevaTarea.id = tarea.ID;
                nuevaTarea.estado = tarea.EstadoTarea.ToString();
                nuevaTarea.ShowDialog();

                if (nuevaTarea.control) // tiene que ser un nuevo control porque sino se crea un nuevo nodo porque es el mismo control que se utiliza para agregar e insertar un nuevo nodo
                {
                    // crear el nodo origen
                    CNodos nodoOrigen = grafoMain.AgregarNodos(4, nombre: nuevaTarea.titulo, aRecordar: nuevaTarea.fechaEntrega, cuerpo: nuevaTarea.cuerpo);
                    if (conexion.ActualizarTarea(nuevaTarea.nuevaTarea))
                    {
                        MessageBox.Show("Se ha editado sin ningun problema la tarea", "Registro de tarea", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("No se ha ingresado la nueva tarea", "Registro de tarea", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarForm(grafoMain, false);
                }
            }
        }

        private void EliminarTarea_Click(object sender, EventArgs e)
        {
            NodoInfo nodoInfo;
            Tarea tarea;
            CGrafo grafo;

            Button boton = sender as Button;
            if (boton != null)
            {
                nodoInfo = boton.Tag as NodoInfo;
                tarea = (Tarea)nodoInfo.Nodo;
                grafo = nodoInfo.Grafo;

                DialogResult result = MessageBox.Show($"¿Estás seguro de eliminar la tarea de {tarea.Titulo}?, los cambios realizados no se podrán recuperar", "Adverdencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Tarea tareaEliminada= (Tarea)grafo.EliminarNodo(4, tarea.ID);
                    if (tareaEliminada != null && conexion.EliminarTarea(tarea))
                    {
                        ActualizarForm(grafo, false);
                        MessageBox.Show($"Se ha eliminado correctamente la Tarea: {tareaEliminada.Titulo}", "Eliminar Tarea", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show($"No se ha eliminado correctamente la Tarea: {tareaEliminada.Titulo}", "Eliminar Tarea", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
