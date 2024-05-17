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
                Materia materia = boton.Tag as Materia;

                MessageBox.Show("Listo se editó :D");
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
