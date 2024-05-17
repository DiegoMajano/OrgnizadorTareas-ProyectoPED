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
                tp.BackColor = tabPage1.BackColor;
                tp.Font = tabPage1.Font;
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
                cuerpo.Font = lblcuer.Font;
                tp.Controls.Add(cuerpo);

                Button Editar = new Button();
                Editar.AutoSize = true;
                Editar.Visible = true;
                Editar.Tag = anotacion;
                Editar.Text = "Editar Anotación";
                Editar.Font = btnEditarA.Font;
                Editar.Anchor = btnEditarA.Anchor;
                Editar.FlatStyle = btnEditarA.FlatStyle;
                Editar.Location = btnEditarA.Location;
                Editar.BackColor = btnEditarA.BackColor;
                Editar.Size = btnEditarA.Size;
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
                nuevaAnotacion.Visible = false;
                nuevaAnotacion.control = false;
                nuevaAnotacion.ShowDialog();
                Anotacion anotacion = boton.Tag as Anotacion;
                if (nuevaAnotacion.control) // tiene que ser un nuevo control porque sino se crea un nuevo nodo porque es el mismo control que se utiliza para agregar e insertar un nuevo nodo
                {
                    anotacion.Titulo = nuevaAnotacion.titulo;
                    anotacion.Cuerpo = nuevaAnotacion.cuerpo;
                    if (conexion.ActualizarAnotacion(anotacion))
                    {
                        MessageBox.Show("Se ha actualizado la Anotacion sin ningun problema", "Anotacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar la Anotacion", "Anotacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void EliminarAnotacion(object sender, EventArgs e)
        {
            NodoInfo nodoInfo;
            Anotacion anotacion;
            CGrafo grafo;

            Button boton = sender as Button;
            if (boton != null)
            {
                nodoInfo = boton.Tag as NodoInfo;
                anotacion = (Anotacion)nodoInfo.Nodo;
                grafo = nodoInfo.Grafo;

                DialogResult result = MessageBox.Show($"¿Estás seguro de eliminar la Anotacion {anotacion.Titulo}?, los cambios realizados no se podrán recuperar", "Adverdencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Anotacion anotacionEliminada = (Anotacion)grafo.EliminarNodo(3, anotacion.ID);
                    if (anotacionEliminada != null && !conexion.EliminarAnotacion(anotacion))
                    {
                        ActualizarForm(grafo, false);
                        MessageBox.Show($"Se ha eliminado correctamente la Anotacion: {anotacionEliminada.Titulo}", "Eliminar Anotacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show($"No se ha eliminado correctamente la Anotacion: {anotacionEliminada.Titulo}", "Eliminar Anotacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tabAnotaciones_DrawItem(object sender, DrawItemEventArgs e)
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
    }
}
