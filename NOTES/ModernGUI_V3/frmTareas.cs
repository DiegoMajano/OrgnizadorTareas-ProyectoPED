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

            foreach (Tarea tarea in tareas)
            {
                // Crear una nueva TabPage para mostrar los datos de la tarea
                TabPage tp = new TabPage();
                tp.Text = tarea.ID; // Usar un identificador único de la tarea como texto de la TabPage

                // Crear y configurar los controles para mostrar los datos de la tarea
                Label titulo = new Label();
                titulo.AutoSize = true;
                titulo.Location = new Point(10, 10);
                titulo.Text = "Titulo: " + tarea.Titulo;
                tp.Controls.Add(titulo);

                Label cuerpo = new Label();
                cuerpo.AutoSize = true;
                cuerpo.Location = new Point(10, 30);
                cuerpo.Text = "Salón: " + tarea.Cuerpo;
                tp.Controls.Add(cuerpo);

                Label fechaEntrega = new Label();
                fechaEntrega.AutoSize = true;
                fechaEntrega.Location = new Point(10, 70);
                fechaEntrega.Text = "Hora de Clase: " + tarea.FechaEntrega.ToString();
                tp.Controls.Add(fechaEntrega);

                
               

                // Agregar la TabPage al TabControl
                tabTareas.TabPages.Add(tp);
            }
        }
        private void EditarTarea_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            if (boton != null)
            {
                NodoInfo nodoInfo = boton.Tag as NodoInfo;
                Tarea tarea = (Tarea) nodoInfo.Nodo;
                grafoMain = (CGrafo)nodoInfo.Grafo;

                nuevaTarea.Visible = false;
                nuevaTarea.control = false;
                tarea.
                nuevaTarea.cbAnotacionT.Enabled = false;
                nuevaTarea.cbImportanciaPeso.Enabled = false;
                nuevaTarea.cbMateriaT.Enabled = false;
                nuevaTarea.ShowDialog();

                if (nuevaTarea.control) // tiene que ser un nuevo control porque sino se crea un nuevo nodo porque es el mismo control que se utiliza para agregar e insertar un nuevo nodo
                {
                    
                    // crear el nodo origen
                    CNodos nodoOrigen = grafoMain.AgregarNodos(4, nombre: nuevaTarea.titulo, aRecordar: nuevaTarea.fechaEntrega, cuerpo: nuevaTarea.cuerpo);

                   
                    if (nodoOrigen != null)
                    {
                        bool exito = conexion.ActualizarTarea(nuevaTarea.nuevaTarea);
                    }
                    else                    
                        MessageBox.Show("No se ha ingresado la nueva tarea", "Registro de anotación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarForm(grafoMain, false);
                }
            }
        }
        public void EliminarTarea_Click(object sender, EventArgs e)
        {
            NodoInfo nodoInfo;
            Recordatorio recordatorio;
            CGrafo grafo;

            Button boton = sender as Button;
            if (boton != null)
            {
                nodoInfo = boton.Tag as NodoInfo;
                recordatorio = (Recordatorio)nodoInfo.Nodo;
                grafo = nodoInfo.Grafo;

                DialogResult result = MessageBox.Show($"¿Estás seguro de eliminar el registro de {recordatorio.Titulo}?, los cambios realizados no se podrán recuperar", "Adverdencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Recordatorio recordatorioEliminado = (Recordatorio)grafo.EliminarNodo(3, recordatorio.ID);
                    if (recordatorioEliminado != null && !conexion.EliminarRecordatorio(recordatorio))
                    {
                        ActualizarForm(grafo, false);
                        MessageBox.Show($"Se ha eliminado correctamente el Recordatorio: {recordatorioEliminado.Titulo}", "Eliminar recordatorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                        MessageBox.Show($"No se ha eliminado correctamente el Recordatorio: {recordatorioEliminado.Titulo}", "Eliminar recordatorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
