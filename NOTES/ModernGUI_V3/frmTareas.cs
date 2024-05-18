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

                // agregar boton para asignar en compleada la tarea
               

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
    }
}
