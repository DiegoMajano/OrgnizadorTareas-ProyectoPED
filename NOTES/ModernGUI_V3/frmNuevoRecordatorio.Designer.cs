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
            this.cbAnotacionR = new System.Windows.Forms.ComboBox();
            this.lblAnotacion = new System.Windows.Forms.Label();
            this.cbMateriaR = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(355, 487);
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
            this.btnRegistrar.Location = new System.Drawing.Point(235, 487);
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
            this.txtCuerpo.Location = new System.Drawing.Point(265, 186);
            this.txtCuerpo.Multiline = true;
            this.txtCuerpo.Name = "txtCuerpo";
            this.txtCuerpo.Size = new System.Drawing.Size(253, 120);
            this.txtCuerpo.TabIndex = 7;
            // 
            // txtTituloR
            // 
            this.txtTituloR.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloR.Location = new System.Drawing.Point(265, 42);
            this.txtTituloR.Name = "txtTituloR";
            this.txtTituloR.Size = new System.Drawing.Size(253, 25);
            this.txtTituloR.TabIndex = 5;
            // 
            // lblRecordar
            // 
            this.lblRecordar.AutoSize = true;
            this.lblRecordar.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordar.Location = new System.Drawing.Point(69, 139);
            this.lblRecordar.Name = "lblRecordar";
            this.lblRecordar.Size = new System.Drawing.Size(157, 18);
            this.lblRecordar.TabIndex = 4;
            this.lblRecordar.Text = "Fecha de recordatorio:";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.Location = new System.Drawing.Point(69, 333);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(168, 18);
            this.lblMateria.TabIndex = 3;
            this.lblMateria.Text = "Materia del recordatorio";
            // 
            // lblCuerpo
            // 
            this.lblCuerpo.AutoSize = true;
            this.lblCuerpo.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuerpo.Location = new System.Drawing.Point(69, 189);
            this.lblCuerpo.Name = "lblCuerpo";
            this.lblCuerpo.Size = new System.Drawing.Size(164, 18);
            this.lblCuerpo.TabIndex = 2;
            this.lblCuerpo.Text = "Cuerpo del recordatorio";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(69, 45);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(52, 18);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo:";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Gainsboro;
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
            this.pnlMain.Size = new System.Drawing.Size(861, 597);
            this.pnlMain.TabIndex = 1;
            // 
            // cbAnotacionR
            // 
            this.cbAnotacionR.FormattingEnabled = true;
            this.cbAnotacionR.Location = new System.Drawing.Point(265, 384);
            this.cbAnotacionR.Name = "cbAnotacionR";
            this.cbAnotacionR.Size = new System.Drawing.Size(253, 26);
            this.cbAnotacionR.TabIndex = 18;
            // 
            // lblAnotacion
            // 
            this.lblAnotacion.AutoSize = true;
            this.lblAnotacion.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnotacion.Location = new System.Drawing.Point(69, 387);
            this.lblAnotacion.Name = "lblAnotacion";
            this.lblAnotacion.Size = new System.Drawing.Size(184, 18);
            this.lblAnotacion.TabIndex = 17;
            this.lblAnotacion.Text = "Anotación del recordatorio";
            // 
            // cbMateriaR
            // 
            this.cbMateriaR.FormattingEnabled = true;
            this.cbMateriaR.Location = new System.Drawing.Point(265, 330);
            this.cbMateriaR.Name = "cbMateriaR";
            this.cbMateriaR.Size = new System.Drawing.Size(253, 26);
            this.cbMateriaR.TabIndex = 16;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(265, 134);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(258, 25);
            this.dtpFecha.TabIndex = 15;
            // 
            // frmNuevoRecordatorio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(861, 597);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNuevoRecordatorio";
            this.Text = "frmNuevoRecordatorio";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtCuerpo;
        private System.Windows.Forms.TextBox txtTituloR;
        private System.Windows.Forms.Label lblRecordar;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblCuerpo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cbAnotacionR;
        private System.Windows.Forms.Label lblAnotacion;
        private System.Windows.Forms.ComboBox cbMateriaR;
    }
}