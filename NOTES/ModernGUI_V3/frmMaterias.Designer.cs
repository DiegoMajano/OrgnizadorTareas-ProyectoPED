namespace ModernGUI_V3
{
    partial class frmMaterias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaterias));
            this.pnlFormularios = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabMaterias = new System.Windows.Forms.TabControl();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlFormularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFormularios
            // 
            this.pnlFormularios.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFormularios.Controls.Add(this.label1);
            this.pnlFormularios.Controls.Add(this.tabMaterias);
            this.pnlFormularios.Controls.Add(this.label7);
            this.pnlFormularios.Controls.Add(this.label2);
            this.pnlFormularios.Controls.Add(this.pictureBox2);
            this.pnlFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormularios.Location = new System.Drawing.Point(0, 0);
            this.pnlFormularios.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFormularios.Name = "pnlFormularios";
            this.pnlFormularios.Size = new System.Drawing.Size(861, 597);
            this.pnlFormularios.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Materias registradas";
            // 
            // tabMaterias
            // 
            this.tabMaterias.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabMaterias.Location = new System.Drawing.Point(31, 134);
            this.tabMaterias.Name = "tabMaterias";
            this.tabMaterias.SelectedIndex = 0;
            this.tabMaterias.Size = new System.Drawing.Size(800, 282);
            this.tabMaterias.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 31);
            this.label7.TabIndex = 9;
            this.label7.Text = "My Notes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "My Notes";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // frmMaterias
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(861, 597);
            this.Controls.Add(this.pnlFormularios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMaterias";
            this.Text = "Form3";
            this.pnlFormularios.ResumeLayout(false);
            this.pnlFormularios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormularios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabMaterias;
    }
}