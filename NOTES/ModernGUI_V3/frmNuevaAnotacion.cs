using AdministradorT.ClasesNodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministradorT
{
    public partial class frmNuevaAnotacion : Form
    {
        public Anotacion nuevaAnotacion;
        public bool control;
        public List<string> materias;
        public frmNuevaAnotacion()
        {
            InitializeComponent();
        }

        public void RellenarMaterias()
        {
            cbMateriaA.Items.Clear();
            cbMateriaA.Items.Add("Seleccionar materia");
            cbMateriaA.SelectedIndex = 0;
            cbMateriaA.Items.AddRange(materias.ToArray());
        }

        private void LimpiarCampos()
        {
            txtTituloA.Clear();
            txtCuerpo.Clear();
            cbMateriaA.SelectedIndex = 0;
        }
        public string titulo, cuerpo, materiaE;
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTituloA.Text) || string.IsNullOrEmpty(txtCuerpo.Text) || cbMateriaA.SelectedIndex < 0)
                MessageBox.Show("Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {            
                titulo = txtTituloA.Text;
                cuerpo = txtCuerpo.Text;
                materiaE = cbMateriaA.SelectedItem.ToString();
                             
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
