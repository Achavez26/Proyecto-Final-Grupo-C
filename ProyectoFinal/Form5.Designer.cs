namespace ProyectoFinal
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtPromedio = new System.Windows.Forms.MaskedTextBox();
            this.btnContar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarSe = new System.Windows.Forms.TextBox();
            this.btnMostrarSe = new System.Windows.Forms.Button();
            this.dvgBuscarSe = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgBuscarSe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTAR PROMEDIOS";
            // 
            // mtxtPromedio
            // 
            this.mtxtPromedio.Location = new System.Drawing.Point(208, 32);
            this.mtxtPromedio.Mask = "00";
            this.mtxtPromedio.Name = "mtxtPromedio";
            this.mtxtPromedio.Size = new System.Drawing.Size(100, 20);
            this.mtxtPromedio.TabIndex = 1;
            // 
            // btnContar
            // 
            this.btnContar.Font = new System.Drawing.Font("Stencil", 10F);
            this.btnContar.Location = new System.Drawing.Point(355, 28);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(99, 42);
            this.btnContar.TabIndex = 2;
            this.btnContar.Text = "Contar";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "BUSCAR POR SEMESTRE";
            // 
            // txtBuscarSe
            // 
            this.txtBuscarSe.Location = new System.Drawing.Point(208, 106);
            this.txtBuscarSe.Name = "txtBuscarSe";
            this.txtBuscarSe.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarSe.TabIndex = 4;
            // 
            // btnMostrarSe
            // 
            this.btnMostrarSe.Font = new System.Drawing.Font("Stencil", 10F);
            this.btnMostrarSe.Location = new System.Drawing.Point(355, 106);
            this.btnMostrarSe.Name = "btnMostrarSe";
            this.btnMostrarSe.Size = new System.Drawing.Size(99, 42);
            this.btnMostrarSe.TabIndex = 5;
            this.btnMostrarSe.Text = "Mostrar ";
            this.btnMostrarSe.UseVisualStyleBackColor = true;
            this.btnMostrarSe.Click += new System.EventHandler(this.btnMostrarSe_Click);
            // 
            // dvgBuscarSe
            // 
            this.dvgBuscarSe.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dvgBuscarSe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgBuscarSe.Location = new System.Drawing.Point(29, 170);
            this.dvgBuscarSe.Name = "dvgBuscarSe";
            this.dvgBuscarSe.RowHeadersWidth = 51;
            this.dvgBuscarSe.Size = new System.Drawing.Size(601, 207);
            this.dvgBuscarSe.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources.WhatsApp_Image_2024_02_18_at_9_29_55_PM;
            this.pictureBox1.Location = new System.Drawing.Point(565, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.form5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 416);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dvgBuscarSe);
            this.Controls.Add(this.btnMostrarSe);
            this.Controls.Add(this.txtBuscarSe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.mtxtPromedio);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.dvgBuscarSe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxtPromedio;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarSe;
        private System.Windows.Forms.Button btnMostrarSe;
        private System.Windows.Forms.DataGridView dvgBuscarSe;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}