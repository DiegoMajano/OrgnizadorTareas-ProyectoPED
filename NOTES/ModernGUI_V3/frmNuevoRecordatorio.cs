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
        Recordatorio nuevoRecordatorio;

        public frmNuevoRecordatorio()
        {
            InitializeComponent();
            RellenarMateriaAnotacion();
        }

        private void RellenarMateriaAnotacion()
        {
            
        }
        

        private void LimpiarCampos()
        {
            txtTituloR.Clear();
            txtCuerpo.Clear();
            dtpFecha.Value = DateTime.Now;
            cbMateriaR.SelectedIndex = 0;
            cbAnotacionR.SelectedIndex = 0;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTituloR.Text) || string.IsNullOrEmpty(txtCuerpo.Text))
                MessageBox.Show("Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else
            {
                string titulo, cuerpo;
                DateTime aRecordar;

                titulo = txtTituloR.Text;
                cuerpo = txtCuerpo.Text;
                aRecordar = dtpFecha.Value;

                nuevoRecordatorio = new Recordatorio(titulo, aRecordar, cuerpo);
                MessageBox.Show("Se ha ingresado exitosamente la nueva materia", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
