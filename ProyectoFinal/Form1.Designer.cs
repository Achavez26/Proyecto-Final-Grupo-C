﻿
namespace ProyectoFinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNombreL = new System.Windows.Forms.TextBox();
            this.txtApellidoL = new System.Windows.Forms.TextBox();
            this.txtCursoL = new System.Windows.Forms.TextBox();
            this.txtParaleloL = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAlmacenar = new System.Windows.Forms.Button();
            this.btnMostrarL = new System.Windows.Forms.Button();
            this.btnAprovadosL = new System.Windows.Forms.Button();
            this.btnSuspensoL = new System.Windows.Forms.Button();
            this.mtxtPromedio = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lklblSiguiente = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(237, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nombres:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Stencil", 11.25F);
            this.label8.Location = new System.Drawing.Point(237, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Apellidos:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Font = new System.Drawing.Font("Stencil", 11.25F);
            this.label9.Location = new System.Drawing.Point(237, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "Curso:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Font = new System.Drawing.Font("Stencil", 11.25F);
            this.label10.Location = new System.Drawing.Point(237, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 18);
            this.label10.TabIndex = 3;
            this.label10.Text = "Paralelo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Font = new System.Drawing.Font("Stencil", 11.25F);
            this.label11.Location = new System.Drawing.Point(237, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 18);
            this.label11.TabIndex = 4;
            this.label11.Text = "Promedio:";
            // 
            // txtNombreL
            // 
            this.txtNombreL.Location = new System.Drawing.Point(372, 97);
            this.txtNombreL.Name = "txtNombreL";
            this.txtNombreL.Size = new System.Drawing.Size(182, 20);
            this.txtNombreL.TabIndex = 6;
            // 
            // txtApellidoL
            // 
            this.txtApellidoL.Location = new System.Drawing.Point(372, 137);
            this.txtApellidoL.Name = "txtApellidoL";
            this.txtApellidoL.Size = new System.Drawing.Size(182, 20);
            this.txtApellidoL.TabIndex = 7;
            // 
            // txtCursoL
            // 
            this.txtCursoL.Location = new System.Drawing.Point(372, 176);
            this.txtCursoL.Name = "txtCursoL";
            this.txtCursoL.Size = new System.Drawing.Size(182, 20);
            this.txtCursoL.TabIndex = 8;
            // 
            // txtParaleloL
            // 
            this.txtParaleloL.Location = new System.Drawing.Point(372, 216);
            this.txtParaleloL.Name = "txtParaleloL";
            this.txtParaleloL.Size = new System.Drawing.Size(182, 20);
            this.txtParaleloL.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Font = new System.Drawing.Font("Showcard Gothic", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(253, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(372, 38);
            this.label12.TabIndex = 10;
            this.label12.Text = "Listado Estudiantes";
            // 
            // btnAlmacenar
            // 
            this.btnAlmacenar.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Italic);
            this.btnAlmacenar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAlmacenar.Location = new System.Drawing.Point(118, 315);
            this.btnAlmacenar.Name = "btnAlmacenar";
            this.btnAlmacenar.Size = new System.Drawing.Size(89, 30);
            this.btnAlmacenar.TabIndex = 11;
            this.btnAlmacenar.Text = "Guardar";
            this.btnAlmacenar.UseVisualStyleBackColor = true;
            this.btnAlmacenar.Click += new System.EventHandler(this.btnAlmacenar_Click);
            // 
            // btnMostrarL
            // 
            this.btnMostrarL.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Italic);
            this.btnMostrarL.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnMostrarL.Location = new System.Drawing.Point(240, 315);
            this.btnMostrarL.Name = "btnMostrarL";
            this.btnMostrarL.Size = new System.Drawing.Size(91, 30);
            this.btnMostrarL.TabIndex = 12;
            this.btnMostrarL.Text = "Mostrar";
            this.btnMostrarL.UseVisualStyleBackColor = true;
            this.btnMostrarL.Click += new System.EventHandler(this.btnMostrarL_Click);
            // 
            // btnAprovadosL
            // 
            this.btnAprovadosL.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Italic);
            this.btnAprovadosL.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAprovadosL.Location = new System.Drawing.Point(363, 315);
            this.btnAprovadosL.Name = "btnAprovadosL";
            this.btnAprovadosL.Size = new System.Drawing.Size(108, 30);
            this.btnAprovadosL.TabIndex = 13;
            this.btnAprovadosL.Text = "Aprobados";
            this.btnAprovadosL.UseVisualStyleBackColor = true;
            this.btnAprovadosL.Click += new System.EventHandler(this.btnAprovadosL_Click);
            // 
            // btnSuspensoL
            // 
            this.btnSuspensoL.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Italic);
            this.btnSuspensoL.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSuspensoL.Location = new System.Drawing.Point(508, 315);
            this.btnSuspensoL.Name = "btnSuspensoL";
            this.btnSuspensoL.Size = new System.Drawing.Size(98, 30);
            this.btnSuspensoL.TabIndex = 14;
            this.btnSuspensoL.Text = "Suspensos";
            this.btnSuspensoL.UseVisualStyleBackColor = true;
            this.btnSuspensoL.Click += new System.EventHandler(this.btnSuspensoL_Click);
            // 
            // mtxtPromedio
            // 
            this.mtxtPromedio.Location = new System.Drawing.Point(372, 255);
            this.mtxtPromedio.Mask = "99";
            this.mtxtPromedio.Name = "mtxtPromedio";
            this.mtxtPromedio.Size = new System.Drawing.Size(63, 20);
            this.mtxtPromedio.TabIndex = 15;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Italic);
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLimpiar.Location = new System.Drawing.Point(638, 315);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(98, 30);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lklblSiguiente
            // 
            this.lklblSiguiente.AutoSize = true;
            this.lklblSiguiente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lklblSiguiente.Location = new System.Drawing.Point(694, 42);
            this.lklblSiguiente.Name = "lklblSiguiente";
            this.lklblSiguiente.Size = new System.Drawing.Size(51, 13);
            this.lklblSiguiente.TabIndex = 18;
            this.lklblSiguiente.TabStop = true;
            this.lklblSiguiente.Text = "Siguiente";
            this.lklblSiguiente.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblSiguiente_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.PROYECTO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(791, 411);
            this.Controls.Add(this.lklblSiguiente);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mtxtPromedio);
            this.Controls.Add(this.btnSuspensoL);
            this.Controls.Add(this.btnAprovadosL);
            this.Controls.Add(this.btnMostrarL);
            this.Controls.Add(this.btnAlmacenar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtParaleloL);
            this.Controls.Add(this.txtCursoL);
            this.Controls.Add(this.txtApellidoL);
            this.Controls.Add(this.txtNombreL);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.TextBox txtParalelo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnAprobados;
        private System.Windows.Forms.Button btnSuspensos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mktPromedio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNombreL;
        private System.Windows.Forms.TextBox txtApellidoL;
        private System.Windows.Forms.TextBox txtCursoL;
        private System.Windows.Forms.TextBox txtParaleloL;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAlmacenar;
        private System.Windows.Forms.Button btnMostrarL;
        private System.Windows.Forms.Button btnAprovadosL;
        private System.Windows.Forms.Button btnSuspensoL;
        private System.Windows.Forms.MaskedTextBox mtxtPromedio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.LinkLabel lklblSiguiente;
    }
}

