namespace AdministradorT
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
            this.tabRecordatorios = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblcuerpo = new System.Windows.Forms.Label();
            this.btnEditR = new System.Windows.Forms.Button();
            this.btnElimR = new System.Windows.Forms.Button();
            this.lbltr = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAnotaciones.SuspendLayout();
            this.tabRecordatorios.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAnotaciones
            // 
            this.pnlAnotaciones.BackColor = System.Drawing.SystemColors.Control;
            this.pnlAnotaciones.Controls.Add(this.label7);
            this.pnlAnotaciones.Controls.Add(this.label2);
            this.pnlAnotaciones.Controls.Add(this.pictureBox2);
            this.pnlAnotaciones.Controls.Add(this.label1);
            this.pnlAnotaciones.Controls.Add(this.tabRecordatorios);
            this.pnlAnotaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAnotaciones.Location = new System.Drawing.Point(0, 0);
            this.pnlAnotaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAnotaciones.Name = "pnlAnotaciones";
            this.pnlAnotaciones.Size = new System.Drawing.Size(1148, 735);
            this.pnlAnotaciones.TabIndex = 11;
            // 
            // tabRecordatorios
            // 
            this.tabRecordatorios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabRecordatorios.Controls.Add(this.tabPage1);
            this.tabRecordatorios.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabRecordatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRecordatorios.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabRecordatorios.Location = new System.Drawing.Point(43, 190);
            this.tabRecordatorios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabRecordatorios.Name = "tabRecordatorios";
            this.tabRecordatorios.SelectedIndex = 0;
            this.tabRecordatorios.Size = new System.Drawing.Size(1067, 347);
            this.tabRecordatorios.TabIndex = 12;
            this.tabRecordatorios.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabRecordatorios_DrawItem);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblfecha);
            this.tabPage1.Controls.Add(this.lblcuerpo);
            this.tabPage1.Controls.Add(this.btnEditR);
            this.tabPage1.Controls.Add(this.btnElimR);
            this.tabPage1.Controls.Add(this.lbltr);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1059, 309);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblfecha.Location = new System.Drawing.Point(152, 240);
            this.lblfecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(81, 26);
            this.lblfecha.TabIndex = 4;
            this.lblfecha.Text = "label2";
            // 
            // lblcuerpo
            // 
            this.lblcuerpo.AutoSize = true;
            this.lblcuerpo.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblcuerpo.Location = new System.Drawing.Point(152, 116);
            this.lblcuerpo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcuerpo.Name = "lblcuerpo";
            this.lblcuerpo.Size = new System.Drawing.Size(81, 26);
            this.lblcuerpo.TabIndex = 3;
            this.lblcuerpo.Text = "label2";
            // 
            // btnEditR
            // 
            this.btnEditR.BackColor = System.Drawing.Color.SlateGray;
            this.btnEditR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditR.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnEditR.Location = new System.Drawing.Point(666, 54);
            this.btnEditR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditR.Name = "btnEditR";
            this.btnEditR.Size = new System.Drawing.Size(125, 51);
            this.btnEditR.TabIndex = 2;
            this.btnEditR.Text = "button2";
            this.btnEditR.UseVisualStyleBackColor = false;
            // 
            // btnElimR
            // 
            this.btnElimR.BackColor = System.Drawing.Color.SlateGray;
            this.btnElimR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElimR.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnElimR.Location = new System.Drawing.Point(666, 216);
            this.btnElimR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnElimR.Name = "btnElimR";
            this.btnElimR.Size = new System.Drawing.Size(125, 50);
            this.btnElimR.TabIndex = 1;
            this.btnElimR.Text = "button1";
            this.btnElimR.UseVisualStyleBackColor = false;
            // 
            // lbltr
            // 
            this.lbltr.AutoSize = true;
            this.lbltr.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold);
            this.lbltr.Location = new System.Drawing.Point(152, 37);
            this.lbltr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltr.Name = "lbltr";
            this.lbltr.Size = new System.Drawing.Size(81, 26);
            this.lbltr.TabIndex = 0;
            this.lbltr.Text = "label2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(116, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 40);
            this.label7.TabIndex = 24;
            this.label7.Text = "My Notes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 40);
            this.label2.TabIndex = 25;
            this.label2.Text = "My Notes";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(64, 59);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(431, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 37);
            this.label1.TabIndex = 22;
            this.label1.Text = "Recordatorios ";
            // 
            // frmRecordatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 735);
            this.Controls.Add(this.pnlAnotaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRecordatorios";
            this.Text = "frmRecordatorios";
            this.pnlAnotaciones.ResumeLayout(false);
            this.pnlAnotaciones.PerformLayout();
            this.tabRecordatorios.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAnotaciones;
        private System.Windows.Forms.TabControl tabRecordatorios;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.Button btnEditR;
        public System.Windows.Forms.Button btnElimR;
        private System.Windows.Forms.Label lbltr;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblcuerpo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}