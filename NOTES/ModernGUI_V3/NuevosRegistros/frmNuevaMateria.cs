using AdministradorT.ClasesNodos;
using ModernGUI_V3;
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
    public partial class frmNuevaMateria : Form
    {
        private frmPrincipal principal;
        public Materia nuevaMateria;
        public bool control;
         private CConexion conexion;
        
        public frmNuevaMateria()
        {
            InitializeComponent();
            LlenarCampos();
            conexion = new CConexion();
        }

        private void LlenarCampos()
        {
            List<string> dias = new List<string>() { "Luneas", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado","Domingo" };
            List<TimeSpan> horas = new List<TimeSpan> {
                new TimeSpan(07,00,00),
                new TimeSpan(09,05,00),
                new TimeSpan(11,10,00),
                new TimeSpan(13,15,00),
                new TimeSpan(15,20,00),
                new TimeSpan(17,25,00)
            };

            cbHora.Items.Add("Seleccionar Hora");
            for (int i = 0; i < dias.Count; i++)
                clbDias.Items.Add(dias[i]);
            for (int i=0; i<horas.Count;i++)
            {
                string format = string.Format("{00:00}:{1:00}", horas[i].TotalHours, horas[i].Minutes);
                cbHora.Items.Add(format);
            }
            cbHora.SelectedIndex = 0;
        }
        public string nombreM, nombreD, salon;
        public List<string> dias = new List<string>();
        public TimeSpan horaClase;
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cbHora.SelectedIndex == 0 || clbDias.CheckedItems.Count == 0 || string.IsNullOrEmpty(txtNDocente.Text) || string.IsNullOrEmpty(txtNombreM.Text) || string.IsNullOrEmpty(txtSalon.Text))
                MessageBox.Show("Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                nombreM = txtNombreM.Text;
                nombreD = txtNDocente.Text;
                salon = txtSalon.Text;
                horaClase = TimeSpan.Parse(cbHora.SelectedItem.ToString()); // Corregido para obtener la hora seleccionada correctamente
                nuevaMateria = new Materia(nombreM, horaClase, dias, nombreD, salon);
                control = true;

                // Insertar los datos en la base de datos
                if (InsertarMateriaEnBDD(nuevaMateria))
                {
                    MessageBox.Show("Materia registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error al registrar la materia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Método para insertar la materia en la base de datos
        private bool InsertarMateriaEnBDD(Materia materia)
        {
            string servidor = "localhost";
            string baseDeDatos = "catedraped";
            string usuario = "root";
            string contraseña = "";

            string cadenaConexion = $"Server={servidor};Database={baseDeDatos};Uid={usuario};Pwd={contraseña};";

            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                    string consulta = "INSERT INTO materia (nombre, horaClase, docente, salon) VALUES (@nombre, @horaClase, @docente, @salon)";
                    MySqlCommand comando = new MySqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@nombre", materia.Nombre);
                    comando.Parameters.AddWithValue("@horaClase", DateTime.Today.Add(materia.HoraClase)); // Se agrega la hora seleccionada al día actual
                    comando.Parameters.AddWithValue("@docente", materia.Docente);
                    comando.Parameters.AddWithValue("@salon", materia.Salon);
                    comando.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar la materia en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }






        private void Validacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void LimpiarCampos()
        {
            txtNDocente.Clear();
            txtNombreM.Clear();
            txtSalon.Clear();
            cbHora.SelectedIndex = 0;
            clbDias.ClearSelected();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            this.Hide();
        }
    }
}
