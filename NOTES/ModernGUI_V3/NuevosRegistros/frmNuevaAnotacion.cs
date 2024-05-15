using AdministradorT.ClasesNodos;
using MySql.Data.MySqlClient;
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
        private CConexion conexion;//Conexion
        public frmNuevaAnotacion()
        {
            InitializeComponent();
            conexion = new CConexion();//Conexion
        }

        public void RellenarMaterias()
        {
            cbMateriaA.Items.Clear();
            cbMateriaA.Items.Add("Seleccionar materia");
            materias = conexion.ObtenerNombresMaterias(); // Obtener los nombres de las materias desde la base de datos
            cbMateriaA.Items.AddRange(materias.ToArray());
            cbMateriaA.SelectedIndex = 0;
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
                string titulo = txtTituloA.Text;
                string cuerpo = txtCuerpo.Text;
                string nombreMateria = cbMateriaA.SelectedItem.ToString();

                if (conexion.InsertarAnotacion(titulo, cuerpo, nombreMateria))
                {
                    MessageBox.Show("Anotación registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error al registrar la anotación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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