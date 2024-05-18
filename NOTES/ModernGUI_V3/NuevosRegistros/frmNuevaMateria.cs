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
        public Materia nuevaMateria;
        public bool control, editar;
        private CConexion conexion;
        private List<string> diasCb = new List<string>() { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado","Domingo" };


        public frmNuevaMateria()
        {
            InitializeComponent();
            LlenarCampos();
            conexion = new CConexion();

        }

        private void LlenarCampos()
        {
            List<TimeSpan> horas = new List<TimeSpan> {
                new TimeSpan(07,00,00),
                new TimeSpan(09,05,00),
                new TimeSpan(11,10,00),
                new TimeSpan(13,15,00),
                new TimeSpan(15,20,00),
                new TimeSpan(17,25,00)
            };

            cbHora.Items.Add("Seleccionar Hora");
            for (int i = 0; i < diasCb.Count; i++)
                clbDias.Items.Add(diasCb[i]);
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
                foreach (var dia in clbDias.CheckedItems)
                    dias.Add(dia.ToString());

                salon = txtSalon.Text;
                horaClase = TimeSpan.Parse(cbHora.SelectedItem.ToString()); // Corregido para obtener la hora seleccionada correctamente
                if(!editar)
                    nuevaMateria = new Materia(nombreM, horaClase, dias, nombreD, salon);
                control = true;
                LimpiarCampos();
                this.Hide();
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
            Desmarcar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            this.Hide();
        }
        public void CheckearList(List<string> dias)
        {
            Desmarcar();
            foreach (string dia in dias)
            {
                int pos = diasCb.IndexOf(dia);
                clbDias.SetItemChecked(pos,true);
            }
        }
        public void Desmarcar()
        {
            for (int i =0; i<clbDias.Items.Count; i++)
            {
                clbDias.SetItemChecked(i, false);
            }
        }
    }
}
