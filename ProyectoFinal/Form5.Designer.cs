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
            ((System.ComponentModel.ISupportInitialize)(this.dvgBuscarSe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTAR PROMEDIOS";
            // 
            // mtxtPromedio
            // 
            this.mtxtPromedio.Location = new System.Drawing.Point(172, 32);
            this.mtxtPromedio.Mask = "00";
            this.mtxtPromedio.Name = "mtxtPromedio";
            this.mtxtPromedio.Size = new System.Drawing.Size(100, 20);
            this.mtxtPromedio.TabIndex = 1;
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(299, 28);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(75, 23);
            this.btnContar.TabIndex = 2;
            this.btnContar.Text = "Contar";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "BUSCAR POR SEMESTRE";
            // 
            // txtBuscarSe
            // 
            this.txtBuscarSe.Location = new System.Drawing.Point(172, 106);
            this.txtBuscarSe.Name = "txtBuscarSe";
            this.txtBuscarSe.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarSe.TabIndex = 4;
            // 
            // btnMostrarSe
            // 
            this.btnMostrarSe.Location = new System.Drawing.Point(299, 106);
            this.btnMostrarSe.Name = "btnMostrarSe";
            this.btnMostrarSe.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarSe.TabIndex = 5;
            this.btnMostrarSe.Text = "Mostrar ";
            this.btnMostrarSe.UseVisualStyleBackColor = true;
            this.btnMostrarSe.Click += new System.EventHandler(this.btnMostrarSe_Click);
            // 
            // dvgBuscarSe
            // 
            this.dvgBuscarSe.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dvgBuscarSe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgBuscarSe.Location = new System.Drawing.Point(29, 156);
            this.dvgBuscarSe.Name = "dvgBuscarSe";
            this.dvgBuscarSe.Size = new System.Drawing.Size(639, 178);
            this.dvgBuscarSe.TabIndex = 6;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dvgBuscarSe);
            this.Controls.Add(this.btnMostrarSe);
            this.Controls.Add(this.txtBuscarSe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.mtxtPromedio);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.dvgBuscarSe)).EndInit();
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
    }
}