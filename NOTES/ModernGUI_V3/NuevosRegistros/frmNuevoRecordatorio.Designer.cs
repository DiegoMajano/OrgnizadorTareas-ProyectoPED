namespace AdministradorT
{
    partial class frmNuevoRecordatorio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtCuerpo = new System.Windows.Forms.TextBox();
            this.txtTituloR = new System.Windows.Forms.TextBox();
            this.lblRecordar = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblCuerpo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.cbTareaR = new System.Windows.Forms.ComboBox();
            this.lblTarea = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHead = new System.Windows.Forms.Label();
            this.cbAnotacionR = new System.Windows.Forms.ComboBox();
            this.lblAnotacion = new System.Windows.Forms.Label();
            this.cbMateriaR = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.pnlMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(288, 539);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 46);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(168, 539);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(105, 46);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtCuerpo
            // 
            this.txtCuerpo.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuerpo.Location = new System.Drawing.Point(248, 217);
            this.txtCuerpo.Multiline = true;
            this.txtCuerpo.Name = "txtCuerpo";
            this.txtCuerpo.Size = new System.Drawing.Size(253, 120);
            this.txtCuerpo.TabIndex = 7;
            // 
            // txtTituloR
            // 
            this.txtTituloR.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloR.Location = new System.Drawing.Point(248, 109);
            this.txtTituloR.Name = "txtTituloR";
            this.txtTituloR.Size = new System.Drawing.Size(253, 25);
            this.txtTituloR.TabIndex = 5;
            // 
            // lblRecordar
            // 
            this.lblRecordar.AutoSize = true;
            this.lblRecordar.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordar.Location = new System.Drawing.Point(52, 166);
            this.lblRecordar.Name = "lblRecordar";
            this.lblRecordar.Size = new System.Drawing.Size(157, 18);
            this.lblRecordar.TabIndex = 4;
            this.lblRecordar.Text = "Fecha de recordatorio:";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.Location = new System.Drawing.Point(52, 370);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(168, 18);
            this.lblMateria.TabIndex = 3;
            this.lblMateria.Text = "Materia del recordatorio";
            // 
            // lblCuerpo
            // 
            this.lblCuerpo.AutoSize = true;
            this.lblCuerpo.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuerpo.Location = new System.Drawing.Point(52, 217);
            this.lblCuerpo.Name = "lblCuerpo";
            this.lblCuerpo.Size = new System.Drawing.Size(164, 18);
            this.lblCuerpo.TabIndex = 2;
            this.lblCuerpo.Text = "Cuerpo del recordatorio";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(52, 112);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(52, 18);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo:";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlMain.Controls.Add(this.cbTareaR);
            this.pnlMain.Controls.Add(this.lblTarea);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.cbAnotacionR);
            this.pnlMain.Controls.Add(this.lblAnotacion);
            this.pnlMain.Controls.Add(this.cbMateriaR);
            this.pnlMain.Controls.Add(this.dtpFecha);
            this.pnlMain.Controls.Add(this.btnCancelar);
            this.pnlMain.Controls.Add(this.btnRegistrar);
            this.pnlMain.Controls.Add(this.txtCuerpo);
            this.pnlMain.Controls.Add(this.txtTituloR);
            this.pnlMain.Controls.Add(this.lblRecordar);
            this.pnlMain.Controls.Add(this.lblMateria);
            this.pnlMain.Controls.Add(this.lblCuerpo);
            this.pnlMain.Controls.Add(this.lblTitulo);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.ForeColor = System.Drawing.Color.Black;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(581, 597);
            this.pnlMain.TabIndex = 1;
            // 
            // cbTareaR
            // 
            this.cbTareaR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTareaR.FormattingEnabled = true;
            this.cbTareaR.Location = new System.Drawing.Point(248, 476);
            this.cbTareaR.Name = "cbTareaR";
            this.cbTareaR.Size = new System.Drawing.Size(253, 26);
            this.cbTareaR.TabIndex = 21;
            // 
            // lblTarea
            // 
            this.lblTarea.AutoSize = true;
            this.lblTarea.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarea.Location = new System.Drawing.Point(52, 480);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(154, 18);
            this.lblTarea.TabIndex = 20;
            this.lblTarea.Text = "Tarea del recordatorio";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.lblHead);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 60);
            this.panel1.TabIndex = 19;
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.ForeColor = System.Drawing.Color.Transparent;
            this.lblHead.Location = new System.Drawing.Point(186, 19);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(204, 23);
            this.lblHead.TabIndex = 20;
            this.lblHead.Text = "Nuevo recordatorio";
            // 
            // cbAnotacionR
            // 
            this.cbAnotacionR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnotacionR.FormattingEnabled = true;
            this.cbAnotacionR.Location = new System.Drawing.Point(248, 421);
            this.cbAnotacionR.Name = "cbAnotacionR";
            this.cbAnotacionR.Size = new System.Drawing.Size(253, 26);
            this.cbAnotacionR.TabIndex = 18;
            // 
            // lblAnotacion
            // 
            this.lblAnotacion.AutoSize = true;
            this.lblAnotacion.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnotacion.Location = new System.Drawing.Point(52, 425);
            this.lblAnotacion.Name = "lblAnotacion";
            this.lblAnotacion.Size = new System.Drawing.Size(184, 18);
            this.lblAnotacion.TabIndex = 17;
            this.lblAnotacion.Text = "Anotación del recordatorio";
            // 
            // cbMateriaR
            // 
            this.cbMateriaR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMateriaR.FormattingEnabled = true;
            this.cbMateriaR.Location = new System.Drawing.Point(248, 366);
            this.cbMateriaR.Name = "cbMateriaR";
            this.cbMateriaR.Size = new System.Drawing.Size(253, 26);
            this.cbMateriaR.TabIndex = 16;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(248, 163);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(258, 25);
            this.dtpFecha.TabIndex = 15;
            // 
            // frmNuevoRecordatorio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(581, 597);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmNuevoRecordatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar un nuevo recordatorio";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        public System.Windows.Forms.TextBox txtCuerpo;
        public System.Windows.Forms.TextBox txtTituloR;
        private System.Windows.Forms.Label lblRecordar;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblCuerpo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlMain;
        public System.Windows.Forms.DateTimePicker dtpFecha;
        public System.Windows.Forms.ComboBox cbAnotacionR;
        private System.Windows.Forms.Label lblAnotacion;
        public System.Windows.Forms.ComboBox cbMateriaR;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHead;
        public System.Windows.Forms.ComboBox cbTareaR;
        private System.Windows.Forms.Label lblTarea;
    }
}