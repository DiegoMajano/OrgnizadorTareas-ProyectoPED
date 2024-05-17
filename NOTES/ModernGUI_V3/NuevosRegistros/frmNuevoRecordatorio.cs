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
        public bool  controlEditar;
        public DateTime aRecordar;
        private CConexion conexion;

        public frmNuevoRecordatorio()
        {
            InitializeComponent(); conexion = new CConexion();
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
                string titulo = txtTituloR.Text;
                DateTime fechaRecordatorio = dtpFecha.Value;
                string cuerpo = txtCuerpo.Text;
                string materiaR = cbMateriaR.SelectedIndex > 0 ? cbMateriaR.SelectedItem.ToString() : "";
                string anotacionR = cbAnotacionR.SelectedIndex > 0 ? cbAnotacionR.SelectedItem.ToString() : "";
                string tareaR = cbTareaR.SelectedIndex > 0 ? cbTareaR.SelectedItem.ToString() : ""; // Asegurarse de obtener el título de la tarea

                CConexion conexion = new CConexion();
                bool exito = conexion.InsertarRecordatorio(idRecordatorio, titulo, fechaRecordatorio, cuerpo, materiaR, anotacionR, tareaR);

                if (exito)
                {
                    MessageBox.Show("Recordatorio registrado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    this.Hide();
                }
            }
        }





        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            this.Hide();
        }
    }
}
