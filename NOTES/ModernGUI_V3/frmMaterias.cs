using AdministradorT;
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

namespace ModernGUI_V3
{
    public partial class frmMaterias : Form
    {

        private frmNuevaMateria nuevaMateria = new frmNuevaMateria();
        public frmMaterias()
        {
            InitializeComponent();
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = pnlFormularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnlFormularios.Controls.Add(formulario);
                pnlFormularios.Tag = formulario;
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

        //Funcion que actualiza los datos de el tab page para que aparezcan los datos de el grafo
        public void ActualizarForm(CGrafo grafo)
        {
            tabMaterias.TabPages.Clear();
            foreach (Materia materia in grafo.nodosMaterias)
            {
                //Definicion de todos los objetos agregador al TABCONTROL
                TabPage tp = new TabPage();
                Label nombre = new Label();
                Label dias = new Label();
                Label horaClase = new Label();
                Label docente = new Label();
                Label salon = new Label();
                tp.Text = materia.ID;

                //Label de el nombre
                nombre.AutoSize = true;
                nombre.Location = new Point(0,0);
                nombre.Text = materia.Nombre.ToUpper();
                nombre.Font = new Font("Times New Roman", 20, FontStyle.Bold);

                //Label de los dias de clase
                dias.AutoSize = true;
                dias.Location = new Point(0,50);
                dias.Text = "";
                foreach (string dia in materia.Dias)
                {
                    dias.Text += dia+" ";
                }
                dias.Font = new Font("Times New Roman", 16);

                //Label de la hora de la clase
                horaClase.AutoSize = true;
                horaClase.Location = new Point(0,100);
                horaClase.Text = materia.HoraClase.ToString();
                horaClase.Font = new Font("Times New Roman", 16);

                //Label de el docente
                docente.AutoSize = true;
                docente.Location = new Point(0,150);
                docente.Text = materia.Docente;
                docente.Font = new Font("Times New Roman", 16);

                //Label de el salon
                salon.AutoSize = true;
                salon.Location = new Point(0,200);
                salon.Text = materia.Salon;
                salon.Font = new Font("Times New Roman", 16);

                tp.Controls.Add(nombre);
                tp.Controls.Add(dias);
                tp.Controls.Add(horaClase);
                tp.Controls.Add(docente);
                tp.Controls.Add(salon);

                tabMaterias.TabPages.Add(tp);
            }
        }
    }
}
