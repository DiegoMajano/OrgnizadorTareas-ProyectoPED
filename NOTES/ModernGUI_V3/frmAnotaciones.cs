using AdministradorT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernGUI_V3
{
    public partial class frmAnotaciones : Form
    {
        public frmAnotaciones()
        {
            InitializeComponent();
        }

        private void btnAgregarA_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmNuevaAnotacion>();
        }
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = pnlAnotaciones.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnlAnotaciones.Controls.Add(formulario);
                pnlAnotaciones.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.Show();
                formulario.BringToFront();
            }
        }

    }
}
