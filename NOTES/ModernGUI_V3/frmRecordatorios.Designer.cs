﻿namespace AdministradorT
{
    partial class frmRecordatorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecordatorios));
            this.pnlAnotaciones = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabRecordatorios = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblcuerpo = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lbltr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlAnotaciones.SuspendLayout();
            this.tabRecordatorios.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAnotaciones
            // 
            this.pnlAnotaciones.BackColor = System.Drawing.SystemColors.Control;
            this.pnlAnotaciones.Controls.Add(this.lblTitulo);
            this.pnlAnotaciones.Controls.Add(this.tabRecordatorios);
            this.pnlAnotaciones.Controls.Add(this.label1);
            this.pnlAnotaciones.Controls.Add(this.pictureBox1);
            this.pnlAnotaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAnotaciones.Location = new System.Drawing.Point(0, 0);
            this.pnlAnotaciones.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAnotaciones.Name = "pnlAnotaciones";
            this.pnlAnotaciones.Size = new System.Drawing.Size(861, 597);
            this.pnlAnotaciones.TabIndex = 11;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(285, 85);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(291, 31);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Recordatorios registrados";
            // 
            // tabRecordatorios
            // 
            this.tabRecordatorios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabRecordatorios.Controls.Add(this.tabPage1);
            this.tabRecordatorios.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabRecordatorios.Location = new System.Drawing.Point(32, 154);
            this.tabRecordatorios.Name = "tabRecordatorios";
            this.tabRecordatorios.SelectedIndex = 0;
            this.tabRecordatorios.Size = new System.Drawing.Size(800, 282);
            this.tabRecordatorios.TabIndex = 12;
            this.tabRecordatorios.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabRecordatorios_DrawItem);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblfecha);
            this.tabPage1.Controls.Add(this.lblcuerpo);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.btnEditar);
            this.tabPage1.Controls.Add(this.lbltr);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 256);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(114, 195);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(35, 13);
            this.lblfecha.TabIndex = 4;
            this.lblfecha.Text = "label2";
            // 
            // lblcuerpo
            // 
            this.lblcuerpo.AutoSize = true;
            this.lblcuerpo.Location = new System.Drawing.Point(114, 94);
            this.lblcuerpo.Name = "lblcuerpo";
            this.lblcuerpo.Size = new System.Drawing.Size(35, 13);
            this.lblcuerpo.TabIndex = 3;
            this.lblcuerpo.Text = "label2";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(672, 203);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(114, 39);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "button2";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(672, 158);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(114, 39);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "button1";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // lbltr
            // 
            this.lbltr.AutoSize = true;
            this.lbltr.Location = new System.Drawing.Point(114, 30);
            this.lbltr.Name = "lbltr";
            this.lbltr.Size = new System.Drawing.Size(35, 13);
            this.lbltr.TabIndex = 0;
            this.lbltr.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "My Notes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmRecordatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 597);
            this.Controls.Add(this.pnlAnotaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRecordatorios";
            this.Text = "frmRecordatorios";
            this.pnlAnotaciones.ResumeLayout(false);
            this.pnlAnotaciones.PerformLayout();
            this.tabRecordatorios.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAnotaciones;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tabRecordatorios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lbltr;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblcuerpo;
    }
}