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
        }

        public void ActualizarForm(CGrafo grafo)
        {/*
            tabRecordatorios.TabPages.Clear();
            List<Recordatorio> recordatorios = conexion.ObtenerTodasLasMaterias(); // Obtener todas las materias de la base de datos

            foreach (Recordatorio recordatorio in recordatorios)
            {
                // Crear una nueva TabPage para mostrar los datos de la materia
                TabPage tp = new TabPage();
                tp.Text = recordatorio.ID; // Usar un identificador único de la materia como texto de la TabPage

                // Crear y configurar los controles para mostrar los datos de la materia
                Label Titulo = new Label();
                Titulo.AutoSize = true;
                Titulo.Location = new Point(10, 10);
                Titulo.Text = "Titulo: " + recordatorio.Titulo;
                tp.Controls.Add(Titulo);

                Label fechaRecordar = new Label();
                fechaRecordar.AutoSize = true;
                fechaRecordar.Location = new Point(10, 30);
                fechaRecordar.Text = "Fecha a recordar: " + recordatorio.aRecordar.ToString();
                tp.Controls.Add(fechaRecordar);

                Label cuerpo = new Label();
                cuerpo.AutoSize = true;
                cuerpo.Location = new Point(10, 70);
                cuerpo.Text = "Cuerpo del recordatorio: " + recordatorio.Cuerpo;
                tp.Controls.Add(cuerpo);

                // Agregar la TabPage al TabControl
                tabRecordatorios.TabPages.Add(tp);
            }*/
        }
    }
}
