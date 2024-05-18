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

namespace AdministradorT
{
    public partial class frmNuevoRecordatorio : Form
    {
        // lista para guardar y mostrar nodos materias, anotaciones o tareas
        public List<string> materias, anotaciones, tareas;

        // atributos para el control de informacion
        public bool control;
        public string titulo, cuerpo, materiaE = "", anotacionE = "", tareaE = "";
        public bool controlEditar;
        public DateTime aRecordar;

        public Recordatorio newRecordatorio;

        public frmNuevoRecordatorio()
        {
            InitializeComponent();
            RellenarMateriaAnotacion();
        }

        public void RellenarMateriaAnotacion()
        {
            // Crear una instancia de CConexion
            CConexion conexion = new CConexion();

            // Obtener los datos desde la base de datos
            materias = conexion.ObtenerNombresMaterias();
            anotaciones = conexion.ObtenerNombresAnotaciones();
            tareas = conexion.ObtenerTitulosTareas(); // Obtener los títulos de las tareas

            // para materias
            cbMateriaR.Items.Clear();
            cbMateriaR.Items.Add("Seleccionar materia");
            cbMateriaR.SelectedIndex = 0;
            cbMateriaR.Items.AddRange(materias.ToArray());

            // para anotaciones
            cbAnotacionR.Items.Clear();
            cbAnotacionR.Items.Add("Seleccionar anotación");
            cbAnotacionR.SelectedIndex = 0;
            cbAnotacionR.Items.AddRange(anotaciones.ToArray());

            // para tareas
            cbTareaR.Items.Clear();
            cbTareaR.Items.Add("Seleccionar tarea");
            cbTareaR.SelectedIndex = 0;
            cbTareaR.Items.AddRange(tareas.ToArray());
        }

        private void LimpiarCampos()
        {
            txtTituloR.Clear();
            txtCuerpo.Clear();
            dtpFecha.Value = DateTime.Now;
            cbMateriaR.SelectedIndex = 0;
            cbTareaR.SelectedIndex = 0;
            cbAnotacionR.SelectedIndex = 0;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTituloR.Text) || string.IsNullOrEmpty(txtCuerpo.Text))
            {
                MessageBox.Show("Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string idRecordatorio = Guid.NewGuid().ToString().Substring(0, 5); // Generar un ID único para el recordatorio
                titulo = txtTituloR.Text;
                aRecordar = dtpFecha.Value;
                cuerpo = txtCuerpo.Text;
                materiaE = cbMateriaR.SelectedIndex > 0 ? cbMateriaR.SelectedItem.ToString() : "";
                anotacionE = cbAnotacionR.SelectedIndex > 0 ? cbAnotacionR.SelectedItem.ToString() : "";
                tareaE = cbTareaR.SelectedIndex > 0 ? cbTareaR.SelectedItem.ToString() : ""; // Asegurarse de obtener el título de la tarea
                if(!controlEditar)
                    newRecordatorio = new Recordatorio(titulo,aRecordar,cuerpo);
                control = true;
                LimpiarCampos();
                this.Hide();               
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            this.Hide();
        }
    }
}
