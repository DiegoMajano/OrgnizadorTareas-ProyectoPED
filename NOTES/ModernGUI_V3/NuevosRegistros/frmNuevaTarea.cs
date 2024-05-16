﻿using AdministradorT.ClasesNodos;
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
        public DateTime fechaEntrega;
        // listas para guardar y mostrar las materias y las anotaciones
        public List<string> materias, anotaciones;
        private CConexion conexion;//Conexion



        public frmNuevaTarea()
        {
            InitializeComponent();
            conexion = new CConexion();//Conexion
        }

        // ------------------------- METODOS EXTRA -------------------------

        public void RellenarMateriaAnotacion()
        {
            // para materias
            cbMateriaT.Items.Clear();
            cbMateriaT.Items.Add("Seleccionar materia");
            cbMateriaT.SelectedIndex = 0;
            cbMateriaT.Items.AddRange(materias.ToArray());
            // para anotaciones
            cbImportanciaPeso.Items.Clear();
            cbImportanciaPeso.Items.Add("Seleccionar importancia");
            cbImportanciaPeso.Items.Add("Muy importante");
            cbImportanciaPeso.Items.Add("Importante");
            cbImportanciaPeso.Items.Add("No importante");
            cbImportanciaPeso.SelectedIndex = 0;
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
                MessageBox.Show("Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (cbImportanciaPeso.SelectedIndex < 0)
                MessageBox.Show("Debe seleccionar el nivel de importancia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                titulo = txtTituloR.Text;
                cuerpo = txtCuerpo.Text;
                fechaEntrega = dtpFecha.Value;
                materiaE = cbMateriaT.SelectedIndex > 0 ? cbMateriaT.SelectedItem.ToString() : "";
                anotacionE = cbAnotacionT.SelectedIndex > 0 ? cbAnotacionT.SelectedItem.ToString() : "";

                // Obtener el nivel de importancia seleccionado
                int nivelImportancia = cbImportanciaPeso.SelectedIndex;
                ;

                // Llamar al método de inserción de tarea en la base de datos
                if (conexion.InsertarTarea(titulo, cuerpo, fechaEntrega, materiaE, anotacionE, nivelImportancia))
                {
                    MessageBox.Show("Tarea registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
