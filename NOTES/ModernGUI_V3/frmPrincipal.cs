using AdministradorT;
using AdministradorT.ClasesNodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ModernGUI_V3
{
 
    public partial class frmPrincipal : Form
    {
        // crear la instancia del grafo
        public CGrafo grafoMain = new CGrafo();
        // ubicacion de los botones para agregar los nodos
        private Point ubicacion;
        // instanciar las ventanas para agregar los nodos
        private frmNuevaMateria nuevaMateria = new frmNuevaMateria();
        private frmNuevaAnotacion nuevaAnotacion = new frmNuevaAnotacion();
        private frmNuevaTarea nuevaTarea = new frmNuevaTarea();
        private frmNuevoRecordatorio nuevoRecordatorio = new frmNuevoRecordatorio();


        public frmPrincipal()
        {
            InitializeComponent();
            ubicacion = btnNuevaMat.Location;
            ConfigurarBotones();
        }

        private void ConfigurarBotones()
        {
            btnNuevaMat.Location = ubicacion;
            btnNuevaAnot.Location = ubicacion;
            btnNuevoCalen.Location = ubicacion;
            btnNuevoMeto.Location = ubicacion;
            btnNuevoReco.Location = ubicacion;
            btn.Location = ubicacion;
            btnNuevoReco.Visible = false;
            btnNuevoMeto.Visible = false;
            btnNuevaMat.Visible = false;
            btnNuevaAnot.Visible = false;
            btnNuevoCalen.Visible = false;
            btn.Visible = false;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        #region Funcionalidades del formulario
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        // --------------------------------------- ACCIONES CLICK DE LOS BOTONES ---------------------------------------
        private void btnMaterias_Click(object sender, EventArgs e)
        {            
            AbrirFormulario<frmMaterias>();
            btnNuevaMat.BringToFront();
            btnNuevaMat.Visible = true;
            ReestablecerConfig();
            btnMaterias.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void btnAnotaciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmAnotaciones>();
            btnNuevaAnot.BringToFront();
            btnNuevaAnot.Visible = true;
            ReestablecerConfig();
            btnAnotaciones.BackColor = Color.FromArgb(12, 61, 92);
        }
        private void btnMetodos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmTecnicaEstudio>();
            btnNuevoMeto.BringToFront();
            btnNuevoMeto.Visible = true;
            ReestablecerConfig();
            btnMetodos.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void btnRecordatorio_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmNuevoRecordatorio>(); 
            btnNuevoReco.BringToFront();
            btnNuevoReco.Visible = true;
            ReestablecerConfig();
            btnRecordatorio.BackColor = Color.FromArgb(12, 61, 92);
        }
        private void btnCalendario_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmCalendario>();
            btnNuevoCalen.BringToFront();
            btnNuevoCalen.Visible = true;
            ReestablecerConfig();
            btnCalendario.BackColor = Color.FromArgb(12, 61, 92);
        }
        private frmOutput form = new frmOutput();
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {            
            // Mostrar el formulario secundario
            this.Hide();
            form.Show();
        }
        //Capturar posicion y tamaño antes de maximizar para restaurar
        int lx, ly;
        int sw, sh;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMaximizar.Visible = false;
            btnRestaurar. Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true ;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw,sh);
            this.Location = new Point(lx,ly);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblNombreusuario_Click(object sender, EventArgs e)
        {
            //Mostar el que accedio
        }

        private void btnVerGrafo_Click(object sender, EventArgs e)
        {

            MessageBox.Show(grafoMain.nodos.Count.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevaM_Click(object sender, EventArgs e)
        {
            nuevaMateria.Visible = false;
            nuevaMateria.control = false;
            nuevaMateria.ShowDialog();
            if (nuevaMateria.control)
            {
                if (grafoMain.AgregarNodos(1, nombre: nuevaMateria.nombreM, hora: nuevaMateria.horaClase, dias: nuevaMateria.dias, docente: nuevaMateria.nombreD, salon: nuevaMateria.salon) != null)
                    MessageBox.Show("Se ha ingresado exitosamente la nueva materia", "Registro de materia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se ha ingresado la nueva materia", "Regustro de materia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNuevoMeto_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevaAnot_Click(object sender, EventArgs e)
        {
            nuevaAnotacion.Visible = false;
            nuevaAnotacion.control = false;
            nuevaAnotacion.materias = ObtenerMaterias(1);
            nuevaAnotacion.RellenarMaterias();
            nuevaAnotacion.ShowDialog();
            if (nuevaAnotacion.control)
            {
                CNodos nodoOrigen = grafoMain.AgregarNodos(2, nombre: nuevaAnotacion.titulo, cuerpo: nuevaAnotacion.cuerpo);
                CNodos nodoDestino = grafoMain.BuscarNodo(nuevaAnotacion.materiaE);
                if (nodoOrigen != null && nodoDestino != null)
                {
                    grafoMain.AgregarArco(nodoOrigen, nodoDestino);
                    MessageBox.Show("Se ha ingresado exitosamente la nueva anotación", "Registro de anotación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("No se ha ingresado la nueva anotación", "Regustro de anotación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNuevoCalen_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoReco_Click(object sender, EventArgs e)
        {

        }


        //--------------------------------- METODO PARA ARRASTRAR EL FORMULARIO ----------------------------------

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // ------------------------------- METODOS EXTRA -------------------------------

        private void ReestablecerConfig()
        {
            btnCalendario.BackColor = Color.FromArgb(4, 41, 68);
            btnMaterias.BackColor = Color.FromArgb(4, 41, 68);
            btnMetodos.BackColor = Color.FromArgb(4, 41, 68);
            btnAnotaciones.BackColor = Color.FromArgb(4, 41, 68);
            btnRecordatorio.BackColor = Color.FromArgb(4, 41, 68);
        }

        #endregion
        // --------------------------------------- METODO PARA ABRIR FORMULARIOS DENTRO DEL PANEL ---------------------------------------
        private void AbrirFormulario<MiForm>() where MiForm : Form, new() {
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
                formulario.FormClosed += new FormClosedEventHandler(CloseForms );
            }
            //si el formulario/instancia existe
            else {
                formulario.BringToFront();
            }
        }

       

        // --------------------------------------- EVENTOS CLOSE ---------------------------------------

        private void CloseForms(object sender,FormClosedEventArgs e) {
            if (Application.OpenForms["Form1"] == null)
                btnCalendario.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Form2"] == null)
                btnMetodos.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Form3"] == null)
                btnMaterias.BackColor = Color.FromArgb(4, 41, 68);
        }

        // --------------------------------------- EVENTOS MOUSE ---------------------------------------

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // --------------------------------------- METODOS EXTRA ---------------------------------------
        private List<string> ObtenerMaterias(int op)
        {
            List<string> nodos = new List<string>();
            switch (op)
            {
                case 1: // si es materia
                    foreach (Materia nodo in grafoMain.nodosMaterias)
                    {
                        if (nodo.ID.StartsWith("M"))
                            nodos.Add(nodo.Nombre);
                    }
                    break;
                case 2: // si es anotacion
                    foreach (Anotacion nodo in grafoMain.nodosAnotaciones)
                    {
                        if (nodo.ID.StartsWith("A"))
                            nodos.Add(nodo.Titulo);
                    }
                    break;
                case 3: // si es recordatorio
                    foreach (Recordatorio nodo in grafoMain.nodosRecordatorios)
                    {
                        if (nodo.ID.StartsWith("R"))
                            nodos.Add(nodo.Titulo);
                    }
                    break;
                case 4:
                    foreach (Tarea nodo in grafoMain.nodosTarea)
                    {
                        if (nodo.ID.StartsWith("T"))
                            nodos.Add(nodo.Titulo);
                    }
                    break;
                default:
                    break;
            }
            return nodos;
        }       
    }
}
