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
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabAnotaciones = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEditarA = new System.Windows.Forms.Button();
            this.lblcuer = new System.Windows.Forms.Label();
            this.lbltit = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pnlAnotaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabAnotaciones.SuspendLayout();
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
            this.pnlAnotaciones.Controls.Add(this.tabAnotaciones);
            this.pnlAnotaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAnotaciones.Location = new System.Drawing.Point(0, 0);
            this.pnlAnotaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlAnotaciones.Name = "pnlAnotaciones";
            this.pnlAnotaciones.Size = new System.Drawing.Size(861, 597);
            this.pnlAnotaciones.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(74, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 33);
            this.label7.TabIndex = 22;
            this.label7.Text = "My Notes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "My Notes";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(35, 31);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(264, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 31);
            this.label2.TabIndex = 20;
            this.label2.Text = "Anotaciones registradas";
            // 
            // tabAnotaciones
            // 
            this.tabAnotaciones.Controls.Add(this.tabPage1);
            this.tabAnotaciones.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabAnotaciones.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAnotaciones.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabAnotaciones.Location = new System.Drawing.Point(51, 178);
            this.tabAnotaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabAnotaciones.Name = "tabAnotaciones";
            this.tabAnotaciones.SelectedIndex = 0;
            this.tabAnotaciones.Size = new System.Drawing.Size(759, 301);
            this.tabAnotaciones.TabIndex = 19;
            this.tabAnotaciones.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabAnotaciones_DrawItem);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.btnEditarA);
            this.tabPage1.Controls.Add(this.lblcuer);
            this.tabPage1.Controls.Add(this.lbltit);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(751, 269);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnEditarA
            // 
            this.btnEditarA.BackColor = System.Drawing.Color.SlateGray;
            this.btnEditarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarA.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarA.ForeColor = System.Drawing.Color.MintCream;
            this.btnEditarA.Location = new System.Drawing.Point(589, 176);
            this.btnEditarA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditarA.Name = "btnEditarA";
            this.btnEditarA.Size = new System.Drawing.Size(140, 38);
            this.btnEditarA.TabIndex = 11;
            this.btnEditarA.UseVisualStyleBackColor = false;
            // 
            // lblcuer
            // 
            this.lblcuer.AutoSize = true;
            this.lblcuer.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcuer.Location = new System.Drawing.Point(33, 80);
            this.lblcuer.Name = "lblcuer";
            this.lblcuer.Size = new System.Drawing.Size(57, 20);
            this.lblcuer.TabIndex = 8;
            this.lblcuer.Text = "label3";
            // 
            // lbltit
            // 
            this.lbltit.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltit.Location = new System.Drawing.Point(32, 27);
            this.lbltit.Name = "lbltit";
            this.lbltit.Size = new System.Drawing.Size(100, 23);
            this.lbltit.TabIndex = 7;
            this.lbltit.Text = "label2";
            this.lbltit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.SlateGray;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.MintCream;
            this.btnEliminar.Location = new System.Drawing.Point(589, 218);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(140, 38);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.UseVisualStyleBackColor = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabAnotaciones.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlAnotaciones;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabAnotaciones;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnEditarA;
        private System.Windows.Forms.Label lblcuer;
        private System.Windows.Forms.Label lbltit;
        private System.Windows.Forms.Button btnEliminar;
    }
}