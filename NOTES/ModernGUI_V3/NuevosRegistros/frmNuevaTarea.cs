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
    public partial class frmNuevaTarea : Form
    {
        // atributos para el control de informacion
        public bool control;
        public string titulo, cuerpo, materiaE = "", anotacionE = "";
        public DateTime fechaEntrega;
        // listas para guardar y mostrar las materias y las anotaciones
        public List<string> materias, anotaciones;



        public frmNuevaTarea()
        {
            InitializeComponent();
        }

        // ------------------------- METODOS EXTRA -------------------------

        public void RellenarMateriaAnotacion()
        {
            // para materias
            cbMateriaT.Items.Clear();
            cbMateriaT.Items.Add("Seleccionar materia");
            cbMateriaT.SelectedIndex = 0;
            cbMateriaT.Items.AddRange(materias.ToArray());
            // para anotaciones
            cbAnotacionT.Items.Clear();
            cbAnotacionT.Items.Add("Seleccionar materia");
            cbAnotacionT.SelectedIndex = 0;
            cbAnotacionT.Items.AddRange(anotaciones.ToArray());
        }
        private void LimpiarCampos()
        {
            txtTituloR.Clear();
            txtCuerpo.Clear();
            dtpFecha.Value = DateTime.Now;
            cbMateriaT.SelectedIndex = 0;
            cbAnotacionT.SelectedIndex = 0;
        }

        // ------------------------- ACCION CLICK DE LOS BOTONES -------------------------
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTituloR.Text) || string.IsNullOrEmpty(txtCuerpo.Text))
                MessageBox.Show("Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if(cbImportanciaPeso.SelectedIndex<0)
                MessageBox.Show("Debe seleccionar el nivel de importancia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                titulo = txtTituloR.Text;
                cuerpo = txtCuerpo.Text;
                fechaEntrega = dtpFecha.Value;
                materiaE = cbMateriaT.SelectedIndex > 0 ? cbMateriaT.SelectedItem.ToString() : "";
                anotacionE = cbAnotacionT.SelectedIndex > 0 ? cbAnotacionT.SelectedItem.ToString() : "";
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
