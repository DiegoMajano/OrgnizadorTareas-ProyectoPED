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
        public int importancia;
        public DateTime fechaEntrega;
        // listas para guardar y mostrar las materias y las anotaciones
        public List<string> materias, anotaciones;
        private CConexion conexion;//Conexion

        public Tarea nuevaTarea;

        public bool bandera = false;
        public bool edicion = false;
        public string id = "";
        public string estado;

        public frmNuevaTarea()
        {
            InitializeComponent();
            conexion = new CConexion();//Conexion
            RellenarMateria();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        // ------------------------- METODOS EXTRA -------------------------

        public void RellenarMateria()
        {
            cbMateriaT.Items.Clear();
            cbMateriaT.Items.Add("Seleccionar materia");
            materias = conexion.ObtenerNombresMaterias(); // Obtener los nombres de las materias desde la base de datos
            cbMateriaT.Items.AddRange(materias.ToArray());
            cbMateriaT.SelectedIndex = 0;

            cbImportanciaPeso.Items.Clear();
            cbImportanciaPeso.Items.Add("Seleccionar importancia");
            cbImportanciaPeso.Items.Add("Muy importante");  // Map to 2
            cbImportanciaPeso.Items.Add("Importante");      // Map to 1
            cbImportanciaPeso.SelectedIndex = 0;



            cbAnotacionT.Items.Clear();
            cbAnotacionT.Items.Add("Seleccionar anotación");
            anotaciones = conexion.ObtenerNombresAnotaciones(); // Obtener los nombres de las anotaciones desde la base de datos
            cbAnotacionT.Items.AddRange(anotaciones.ToArray());
            cbAnotacionT.SelectedIndex = 0;
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
            {
                MessageBox.Show("Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cbImportanciaPeso.SelectedIndex <= 0 && bandera == false)
            {
                MessageBox.Show("Debe seleccionar el nivel de importancia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                titulo = txtTituloR.Text;
                cuerpo = txtCuerpo.Text;
                fechaEntrega = dtpFecha.Value;
                if(cbMateriaT.SelectedIndex == 0 && bandera == false)
                    MessageBox.Show("Debe de asignar una materia para la registrar la tarea","Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else  
                {
                    materiaE = cbMateriaT.SelectedItem.ToString();
                    anotacionE = cbAnotacionT.SelectedIndex > 0 ? cbAnotacionT.SelectedItem.ToString() : "";

                    // Obtener el nivel de importancia seleccionado como cadena
                    string nivelImportancia = cbImportanciaPeso.SelectedItem.ToString();
                    importancia = nivelImportancia == "Muy Importante" ? 1 : 2;
                    if (edicion == false)
                        nuevaTarea = new Tarea(titulo, cuerpo, fechaEntrega, importancia);
                    else
                        nuevaTarea = new Tarea(id ,titulo, cuerpo, fechaEntrega, estado);
                    // Llamar al método de inserción de tarea en la base de datos
                    control = true;
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
