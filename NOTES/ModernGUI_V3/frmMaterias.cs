﻿using AdministradorT;
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
        frmNuevaMateria nuevaMateria = new frmNuevaMateria();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            nuevaMateria.Visible = false;
            nuevaMateria.control = false;
            nuevaMateria.ShowDialog();
            if (nuevaMateria.control)
            {
                //grafoMain.AgregarNodo(nuevaMateria.nuevaMateria);
            }
        }
    }
             
}
