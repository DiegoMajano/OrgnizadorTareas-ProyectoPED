namespace ModernGUI_V3
{
    partial class frmAnotaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnotaciones));
            this.pnlAnotaciones = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabAnotaciones = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbltit = new System.Windows.Forms.Label();
            this.lblcuer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.pnlAnotaciones.SuspendLayout();
            this.tabAnotaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAnotaciones
            // 
            this.pnlAnotaciones.BackColor = System.Drawing.SystemColors.Control;
            this.pnlAnotaciones.Controls.Add(this.lblTitulo);
            this.pnlAnotaciones.Controls.Add(this.tabAnotaciones);
            this.pnlAnotaciones.Controls.Add(this.label1);
            this.pnlAnotaciones.Controls.Add(this.pictureBox1);
            this.pnlAnotaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAnotaciones.Location = new System.Drawing.Point(0, 0);
            this.pnlAnotaciones.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAnotaciones.Name = "pnlAnotaciones";
            this.pnlAnotaciones.Size = new System.Drawing.Size(861, 597);
            this.pnlAnotaciones.TabIndex = 10;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(294, 85);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(272, 31);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Anotaciones registradas";
            // 
            // tabAnotaciones
            // 
            this.tabAnotaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabAnotaciones.Controls.Add(this.tabPage1);
            this.tabAnotaciones.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabAnotaciones.Location = new System.Drawing.Point(32, 154);
            this.tabAnotaciones.Name = "tabAnotaciones";
            this.tabAnotaciones.SelectedIndex = 0;
            this.tabAnotaciones.Size = new System.Drawing.Size(800, 282);
            this.tabAnotaciones.TabIndex = 12;
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnEditar);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lblcuer);
            this.tabPage1.Controls.Add(this.lbltit);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 256);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbltit
            // 
            this.lbltit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltit.Location = new System.Drawing.Point(350, 16);
            this.lbltit.Name = "lbltit";
            this.lbltit.Size = new System.Drawing.Size(100, 23);
            this.lbltit.TabIndex = 7;
            this.lbltit.Text = "label2";
            this.lbltit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblcuer
            // 
            this.lblcuer.AutoSize = true;
            this.lblcuer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcuer.Location = new System.Drawing.Point(121, 79);
            this.lblcuer.Name = "lblcuer";
            this.lblcuer.Size = new System.Drawing.Size(53, 20);
            this.lblcuer.TabIndex = 8;
            this.lblcuer.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(6, 216);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(125, 34);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "button1";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // frmAnotaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 597);
            this.Controls.Add(this.pnlAnotaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAnotaciones";
            this.Text = "frmAnotaciones";
            this.pnlAnotaciones.ResumeLayout(false);
            this.pnlAnotaciones.PerformLayout();
            this.tabAnotaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlAnotaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tabAnotaciones;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblcuer;
        private System.Windows.Forms.Label lbltit;
    }
}