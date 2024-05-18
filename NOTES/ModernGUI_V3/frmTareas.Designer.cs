namespace AdministradorT
{
    partial class frmTareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTareas));
            this.pnlAnotaciones = new System.Windows.Forms.Panel();
            this.tabTareas = new System.Windows.Forms.TabControl();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblTituloT = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCuerpo = new System.Windows.Forms.Label();
            this.btnEditarT = new System.Windows.Forms.Button();
            this.btnEliminarT = new System.Windows.Forms.Button();
            this.btnTareaC = new System.Windows.Forms.Button();
            this.pnlAnotaciones.SuspendLayout();
            this.tabTareas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAnotaciones
            // 
            this.pnlAnotaciones.BackColor = System.Drawing.SystemColors.Control;
            this.pnlAnotaciones.Controls.Add(this.label7);
            this.pnlAnotaciones.Controls.Add(this.label1);
            this.pnlAnotaciones.Controls.Add(this.pictureBox2);
            this.pnlAnotaciones.Controls.Add(this.label2);
            this.pnlAnotaciones.Controls.Add(this.tabTareas);
            this.pnlAnotaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAnotaciones.Location = new System.Drawing.Point(0, 0);
            this.pnlAnotaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAnotaciones.Name = "pnlAnotaciones";
            this.pnlAnotaciones.Size = new System.Drawing.Size(1148, 735);
            this.pnlAnotaciones.TabIndex = 12;
            // 
            // tabTareas
            // 
            this.tabTareas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabTareas.Controls.Add(this.tabPage1);
            this.tabTareas.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabTareas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.tabTareas.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabTareas.Location = new System.Drawing.Point(47, 226);
            this.tabTareas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabTareas.Name = "tabTareas";
            this.tabTareas.SelectedIndex = 0;
            this.tabTareas.Size = new System.Drawing.Size(1015, 388);
            this.tabTareas.TabIndex = 12;
            this.tabTareas.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabTareas_DrawItem);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(99, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 40);
            this.label7.TabIndex = 30;
            this.label7.Text = "My Notes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 40);
            this.label1.TabIndex = 31;
            this.label1.Text = "My Notes";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(47, 48);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(383, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 37);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tareas registrados";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnTareaC);
            this.tabPage1.Controls.Add(this.btnEliminarT);
            this.tabPage1.Controls.Add(this.btnEditarT);
            this.tabPage1.Controls.Add(this.lblCuerpo);
            this.tabPage1.Controls.Add(this.lblFecha);
            this.tabPage1.Controls.Add(this.lblTituloT);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1007, 352);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblTituloT
            // 
            this.lblTituloT.AutoSize = true;
            this.lblTituloT.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblTituloT.Location = new System.Drawing.Point(50, 44);
            this.lblTituloT.Name = "lblTituloT";
            this.lblTituloT.Size = new System.Drawing.Size(81, 26);
            this.lblTituloT.TabIndex = 0;
            this.lblTituloT.Text = "label3";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblFecha.Location = new System.Drawing.Point(50, 201);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(81, 26);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "label5";
            // 
            // lblCuerpo
            // 
            this.lblCuerpo.AutoSize = true;
            this.lblCuerpo.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblCuerpo.Location = new System.Drawing.Point(50, 119);
            this.lblCuerpo.Name = "lblCuerpo";
            this.lblCuerpo.Size = new System.Drawing.Size(81, 26);
            this.lblCuerpo.TabIndex = 3;
            this.lblCuerpo.Text = "label3";
            // 
            // btnEditarT
            // 
            this.btnEditarT.BackColor = System.Drawing.Color.SlateGray;
            this.btnEditarT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnEditarT.Location = new System.Drawing.Point(807, 88);
            this.btnEditarT.Name = "btnEditarT";
            this.btnEditarT.Size = new System.Drawing.Size(172, 43);
            this.btnEditarT.TabIndex = 4;
            this.btnEditarT.Text = "button1";
            this.btnEditarT.UseVisualStyleBackColor = false;
            // 
            // btnEliminarT
            // 
            this.btnEliminarT.BackColor = System.Drawing.Color.SlateGray;
            this.btnEliminarT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnEliminarT.Location = new System.Drawing.Point(807, 157);
            this.btnEliminarT.Name = "btnEliminarT";
            this.btnEliminarT.Size = new System.Drawing.Size(172, 43);
            this.btnEliminarT.TabIndex = 5;
            this.btnEliminarT.Text = "button2";
            this.btnEliminarT.UseVisualStyleBackColor = false;
            // 
            // btnTareaC
            // 
            this.btnTareaC.BackColor = System.Drawing.Color.CadetBlue;
            this.btnTareaC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTareaC.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnTareaC.Location = new System.Drawing.Point(376, 277);
            this.btnTareaC.Name = "btnTareaC";
            this.btnTareaC.Size = new System.Drawing.Size(214, 40);
            this.btnTareaC.TabIndex = 6;
            this.btnTareaC.Text = "button1";
            this.btnTareaC.UseVisualStyleBackColor = false;
            // 
            // frmTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 735);
            this.Controls.Add(this.pnlAnotaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTareas";
            this.Text = "frmTareas";
            this.pnlAnotaciones.ResumeLayout(false);
            this.pnlAnotaciones.PerformLayout();
            this.tabTareas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAnotaciones;
        private System.Windows.Forms.TabControl tabTareas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTituloT;
        private System.Windows.Forms.Label lblCuerpo;
        private System.Windows.Forms.Button btnEliminarT;
        private System.Windows.Forms.Button btnEditarT;
        private System.Windows.Forms.Button btnTareaC;
    }
}