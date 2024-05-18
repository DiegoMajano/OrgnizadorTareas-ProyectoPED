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
using ZstdSharp.Unsafe;

namespace AdministradorT
{
    public partial class frmRecordatorios : Form
    {
        public CGrafo grafoMain = new CGrafo();
        private frmNuevoRecordatorio nuevoRecordatorio = new frmNuevoRecordatorio();
        private CConexion conexion;

        public frmRecordatorios()
        {
            InitializeComponent();
            conexion = new CConexion();
        }

        public void ActualizarForm(CGrafo grafo, bool alGrafo)
        {
            tabRecordatorios.TabPages.Clear();
            List<Recordatorio> recordatorios = conexion.ObtenerRecordatorios(); // Obtener todas las materias de la base de datos

            if (alGrafo)
                grafo.AgregarNodos(3, recordatorios: recordatorios);

            NodoInfo nodoInfo; // para agregar la info de este nodo

            foreach (Recordatorio recordatorio in recordatorios)
            {
                nodoInfo = new NodoInfo(recordatorio, grafo);
                // Crear una nueva TabPage para mostrar los datos de la materia
                TabPage tp = new TabPage();
                tp.Text = recordatorio.ID; // Usar un identificador único de la materia como texto de la TabPage
                tp.Font = tabPage1.Font;
                tp.BackColor = tabPage1.BackColor;

                // Crear y configurar los controles para mostrar los datos de la materia
                Label Titulo = new Label();
                Titulo.AutoSize = true;
                Titulo.Location = lbltr.Location;
                Titulo.Text = "Titulo: " + recordatorio.Titulo;
                tp.Controls.Add(Titulo);
                Titulo.Font = lbltr.Font;
                Titulo.Location = lbltr.Location;


                Label fechaRecordar = new Label();
                fechaRecordar.AutoSize = true;
                fechaRecordar.Location = lblfecha.Location;
                fechaRecordar.Text = "Fecha a recordar: " + recordatorio.aRecordar.ToString();
                tp.Controls.Add(fechaRecordar);
                fechaRecordar.Location = lblfecha.Location;
                fechaRecordar.Font = lblfecha.Font;

                Label cuerpo = new Label();
                cuerpo.AutoSize = true;
                cuerpo.Location = lblcuerpo.Location;
                cuerpo.Text = "Cuerpo del recordatorio: " + recordatorio.Cuerpo;
                cuerpo.Font = lblcuerpo.Font;
                tp.Controls.Add(cuerpo);

                Button Editar = new Button();
                Editar.AutoSize = true;
                Editar.Text = "Editar Recordatorio";
                Editar.Location = btnEditar.Location;
                Editar.Tag = nodoInfo;
                Editar.Click += EditarRecordatorio_Click;
                Editar.FlatStyle = btnEditar.FlatStyle;
                Editar.Location = btnEditar.Location;
                Editar.Size = btnEditar.Size;
                Editar.Font = btnEditar.Font;
                Editar.BackColor = btnEditar.BackColor;
                tp.Controls.Add(Editar);

                Button Eliminar = new Button();
                Eliminar.Text = "Eliminar Recordatorio";
                Eliminar.Location = btnEliminar.Location;
                Eliminar.FlatStyle = btnEliminar.FlatStyle;
                Eliminar.Font = btnEliminar.Font;
                Eliminar.Size = btnEliminar.Size;
                Eliminar.BackColor = btnEliminar.BackColor;
                Eliminar.Tag = nodoInfo;
                Eliminar.Click += EliminarRecordatorio_Click;
                tp.Controls.Add(Eliminar);


                // Agregar la TabPage al TabControl
                tabRecordatorios.TabPages.Add(tp);
            }
        }
        private void EditarRecordatorio_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            NodoInfo info = boton.Tag as NodoInfo;

            Recordatorio recordatorio = (Recordatorio)info.Nodo;
            CGrafo grafo = (CGrafo)info.Grafo;

            nuevoRecordatorio.control = false;
            nuevoRecordatorio.controlEditar = true;
            nuevoRecordatorio.txtTituloR.Text = recordatorio.Titulo;
            nuevoRecordatorio.txtCuerpo.Text = recordatorio.Cuerpo;
            nuevoRecordatorio.Visible = false;
            nuevoRecordatorio.cbAnotacionR.Enabled = nuevoRecordatorio.cbMateriaR.Enabled = nuevoRecordatorio.cbTareaR.Enabled = false;
            nuevoRecordatorio.ShowDialog();

            if (nuevoRecordatorio.control) // tiene que ser un nuevo control porque sino se crea un nuevo nodo porque es el mismo control que se utiliza para agregar e insertar un nuevo nodo
            {
                
                if (conexion.ActualizarRecordatorio(recordatorio))
                {
                    MessageBox.Show("Se ha actualizado la materia sin ningun problema", "Materias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al actualizar la materia", "Materias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public void EliminarRecordatorio_Click(object sender, EventArgs e)
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

                DialogResult result = MessageBox.Show($"¿Estás seguro de eliminar el registro de {recordatorio.Titulo}?, los cambios realizados no se podrán recuperar","Adverdencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(result == DialogResult.Yes)
                {
                    Recordatorio recordatorioEliminado = (Recordatorio) grafo.EliminarNodo(3,recordatorio.ID);                    
                    if (recordatorioEliminado!=null && !conexion.EliminarRecordatorio(recordatorio))
                    {
                        ActualizarForm(grafo, false);
                        MessageBox.Show($"Se ha eliminado correctamente el Recordatorio: {recordatorioEliminado.Titulo}","Eliminar recordatorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }               
                    
                    else
                        MessageBox.Show($"No se ha eliminado correctamente el Recordatorio: {recordatorioEliminado.Titulo}", "Eliminar recordatorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void tabRecordatorios_DrawItem(object sender, DrawItemEventArgs e)
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
    }
}
