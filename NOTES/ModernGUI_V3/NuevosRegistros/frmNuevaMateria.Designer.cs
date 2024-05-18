namespace AdministradorT
{
    partial class frmNuevaMateria
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbHora = new System.Windows.Forms.ComboBox();
            this.clbDias = new System.Windows.Forms.CheckedListBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtSalon = new System.Windows.Forms.TextBox();
            this.txtNDocente = new System.Windows.Forms.TextBox();
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.lblSalonM = new System.Windows.Forms.Label();
            this.lblDocenteM = new System.Windows.Forms.Label();
            this.lblHoraM = new System.Windows.Forms.Label();
            this.lblNombreM = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlMain.Controls.Add(this.pnlTop);
            this.pnlMain.Controls.Add(this.btnCancelar);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.cbHora);
            this.pnlMain.Controls.Add(this.clbDias);
            this.pnlMain.Controls.Add(this.btnRegistrar);
            this.pnlMain.Controls.Add(this.txtSalon);
            this.pnlMain.Controls.Add(this.txtNDocente);
            this.pnlMain.Controls.Add(this.txtNombreM);
            this.pnlMain.Controls.Add(this.lblSalonM);
            this.pnlMain.Controls.Add(this.lblDocenteM);
            this.pnlMain.Controls.Add(this.lblHoraM);
            this.pnlMain.Controls.Add(this.lblNombreM);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.ForeColor = System.Drawing.Color.Black;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(586, 534);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(89)))));
            this.pnlTop.Controls.Add(this.lblTitulo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(586, 60);
            this.pnlTop.TabIndex = 15;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Location = new System.Drawing.Point(216, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(154, 23);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Nueva Materia";
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(280, 456);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 46);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Hora clase";
            // 
            // cbHora
            // 
            this.cbHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHora.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHora.FormattingEnabled = true;
            this.cbHora.Location = new System.Drawing.Point(270, 281);
            this.cbHora.Name = "cbHora";
            this.cbHora.Size = new System.Drawing.Size(195, 26);
            this.cbHora.TabIndex = 12;
            // 
            // clbDias
            // 
            this.clbDias.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbDias.FormattingEnabled = true;
            this.clbDias.Location = new System.Drawing.Point(270, 132);
            this.clbDias.Name = "clbDias";
            this.clbDias.Size = new System.Drawing.Size(195, 124);
            this.clbDias.TabIndex = 11;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(169, 456);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(105, 46);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtSalon
            // 
            this.txtSalon.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalon.Location = new System.Drawing.Point(270, 401);
            this.txtSalon.Name = "txtSalon";
            this.txtSalon.Size = new System.Drawing.Size(195, 25);
            this.txtSalon.TabIndex = 8;
            // 
            // txtNDocente
            // 
            this.txtNDocente.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNDocente.Location = new System.Drawing.Point(270, 334);
            this.txtNDocente.Name = "txtNDocente";
            this.txtNDocente.Size = new System.Drawing.Size(195, 25);
            this.txtNDocente.TabIndex = 7;
            this.txtNDocente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validacion_KeyPress);
            // 
            // txtNombreM
            // 
            this.txtNombreM.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreM.Location = new System.Drawing.Point(270, 84);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(195, 25);
            this.txtNombreM.TabIndex = 5;
            this.txtNombreM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validacion_KeyPress);
            // 
            // lblSalonM
            // 
            this.lblSalonM.AutoSize = true;
            this.lblSalonM.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalonM.Location = new System.Drawing.Point(92, 408);
            this.lblSalonM.Name = "lblSalonM";
            this.lblSalonM.Size = new System.Drawing.Size(50, 18);
            this.lblSalonM.TabIndex = 3;
            this.lblSalonM.Text = "Salon:";
            // 
            // lblDocenteM
            // 
            this.lblDocenteM.AutoSize = true;
            this.lblDocenteM.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocenteM.Location = new System.Drawing.Point(74, 337);
            this.lblDocenteM.Name = "lblDocenteM";
            this.lblDocenteM.Size = new System.Drawing.Size(146, 18);
            this.lblDocenteM.TabIndex = 2;
            this.lblDocenteM.Text = "Nombre del docente:";
            // 
            // lblHoraM
            // 
            this.lblHoraM.AutoSize = true;
            this.lblHoraM.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraM.Location = new System.Drawing.Point(74, 132);
            this.lblHoraM.Name = "lblHoraM";
            this.lblHoraM.Size = new System.Drawing.Size(141, 18);
            this.lblHoraM.TabIndex = 1;
            this.lblHoraM.Text = "Seleccionar horario:";
            // 
            // lblNombreM
            // 
            this.lblNombreM.AutoSize = true;
            this.lblNombreM.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreM.Location = new System.Drawing.Point(74, 87);
            this.lblNombreM.Name = "lblNombreM";
            this.lblNombreM.Size = new System.Drawing.Size(68, 18);
            this.lblNombreM.TabIndex = 0;
            this.lblNombreM.Text = "Nombre:";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // frmNuevaMateria
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(586, 534);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmNuevaMateria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar nueva materia";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlMain;
        public System.Windows.Forms.Label lblSalonM;
        public System.Windows.Forms.Label lblDocenteM;
        public System.Windows.Forms.Label lblHoraM;
        public System.Windows.Forms.Label lblNombreM;
        public System.Windows.Forms.Button btnRegistrar;
        public System.Windows.Forms.TextBox txtSalon;
        public System.Windows.Forms.TextBox txtNDocente;
        public System.Windows.Forms.TextBox txtNombreM;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbHora;
        public System.Windows.Forms.CheckedListBox clbDias;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Panel pnlTop;
        public System.Windows.Forms.Label lblTitulo;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}