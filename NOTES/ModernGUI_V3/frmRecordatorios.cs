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
        private frmNuevaAnotacion nuevaAnotacion = new frmNuevaAnotacion();
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

            foreach (Recordatorio recordatorio in recordatorios)
            {
                // Crear una nueva TabPage para mostrar los datos de la materia
                TabPage tp = new TabPage();
                tp.Text = recordatorio.ID; // Usar un identificador único de la materia como texto de la TabPage

                // Crear y configurar los controles para mostrar los datos de la materia
                Label Titulo = new Label();
                Titulo.AutoSize = true;
                Titulo.Location = lbltr.Location;
                Titulo.Text = "Titulo: " + recordatorio.Titulo;
                tp.Controls.Add(Titulo);

                Label fechaRecordar = new Label();
                fechaRecordar.AutoSize = true;
                fechaRecordar.Location = lblfecha.Location;
                fechaRecordar.Text = "Fecha a recordar: " + recordatorio.aRecordar.ToString();
                tp.Controls.Add(fechaRecordar);

                Label cuerpo = new Label();
                cuerpo.AutoSize = true;
                cuerpo.Location = lblcuerpo.Location;
                cuerpo.Text = "Cuerpo del recordatorio: " + recordatorio.Cuerpo;
                tp.Controls.Add(cuerpo);

                NodoInfo nodoInfo = new NodoInfo(recordatorio, grafo);
                Button Editar = new Button();
                Editar.AutoSize = true;
                Editar.Text = "editar";
                Editar.Location = button1.Location;
                Editar.Tag = nodoInfo;
                Editar.Click += EditarRecordatorio_Click;
                tp.Controls.Add(Editar);

                Button Eliminar = new Button();
                Eliminar.AutoSize = true;
                Eliminar.Text = "Eliminar";
                Eliminar.Location = button2.Location;
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
            if (boton != null)
            {
                Recordatorio recordatorio = boton.Tag as Recordatorio;

                MessageBox.Show("Listo se editó :D");
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
    }
}
