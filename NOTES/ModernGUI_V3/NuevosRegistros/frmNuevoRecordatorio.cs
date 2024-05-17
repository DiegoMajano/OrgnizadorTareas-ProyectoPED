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
        public bool control, controlEditar;
        public string titulo, cuerpo, materiaE ="", anotacionE="", tareaE="";
        public DateTime aRecordar;

        public frmNuevoRecordatorio()
        {
            InitializeComponent();
        }

        public void RellenarMateriaAnotacion()
        {
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
                MessageBox.Show("Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else
            {
                titulo = txtTituloR.Text;
                cuerpo = txtCuerpo.Text;
                aRecordar = dtpFecha.Value;
                materiaE = cbMateriaR.SelectedIndex > 0 ? cbMateriaR.SelectedItem.ToString() : "";
                anotacionE = cbAnotacionR.SelectedIndex > 0 ? cbAnotacionR.SelectedItem.ToString() : "";
                tareaE = cbTareaR.SelectedIndex > 0 ? cbTareaR.SelectedItem.ToString() : "";
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
