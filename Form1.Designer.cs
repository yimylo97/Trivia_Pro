namespace Trivia_Pro
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
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblPreguntasRestantes = new System.Windows.Forms.Label();
            this.rbOpcion1 = new System.Windows.Forms.RadioButton();
            this.rbOpcion2 = new System.Windows.Forms.RadioButton();
            this.rbOpcion3 = new System.Windows.Forms.RadioButton();
            this.rbOpcion4 = new System.Windows.Forms.RadioButton();
            this.pbTiempo = new System.Windows.Forms.ProgressBar();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnResponder = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.lstHistorial = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Ciencia",
            "Historia",
            "Cultura General"});
            this.cmbCategoria.Location = new System.Drawing.Point(12, 285);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 24);
            this.cmbCategoria.TabIndex = 0;
            // 
            // cmbNivel
            // 
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.Items.AddRange(new object[] {
            "Fácil",
            "Medio",
            "Difícil"});
            this.cmbNivel.Location = new System.Drawing.Point(214, 285);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(121, 24);
            this.cmbNivel.TabIndex = 1;
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Location = new System.Drawing.Point(338, 115);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(44, 16);
            this.lblPregunta.TabIndex = 2;
            this.lblPregunta.Text = "label1";
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Location = new System.Drawing.Point(338, 142);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(44, 16);
            this.lblPuntaje.TabIndex = 3;
            this.lblPuntaje.Text = "label2";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(338, 167);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(44, 16);
            this.lblTiempo.TabIndex = 4;
            this.lblTiempo.Text = "label3";
            // 
            // lblPreguntasRestantes
            // 
            this.lblPreguntasRestantes.AutoSize = true;
            this.lblPreguntasRestantes.Location = new System.Drawing.Point(338, 192);
            this.lblPreguntasRestantes.Name = "lblPreguntasRestantes";
            this.lblPreguntasRestantes.Size = new System.Drawing.Size(44, 16);
            this.lblPreguntasRestantes.TabIndex = 5;
            this.lblPreguntasRestantes.Text = "label4";
            // 
            // rbOpcion1
            // 
            this.rbOpcion1.AutoSize = true;
            this.rbOpcion1.Location = new System.Drawing.Point(341, 14);
            this.rbOpcion1.Name = "rbOpcion1";
            this.rbOpcion1.Size = new System.Drawing.Size(103, 20);
            this.rbOpcion1.TabIndex = 6;
            this.rbOpcion1.TabStop = true;
            this.rbOpcion1.Text = "radioButton1";
            this.rbOpcion1.UseVisualStyleBackColor = true;
            // 
            // rbOpcion2
            // 
            this.rbOpcion2.AutoSize = true;
            this.rbOpcion2.Location = new System.Drawing.Point(341, 40);
            this.rbOpcion2.Name = "rbOpcion2";
            this.rbOpcion2.Size = new System.Drawing.Size(103, 20);
            this.rbOpcion2.TabIndex = 7;
            this.rbOpcion2.TabStop = true;
            this.rbOpcion2.Text = "radioButton2";
            this.rbOpcion2.UseVisualStyleBackColor = true;
            // 
            // rbOpcion3
            // 
            this.rbOpcion3.AutoSize = true;
            this.rbOpcion3.Location = new System.Drawing.Point(341, 66);
            this.rbOpcion3.Name = "rbOpcion3";
            this.rbOpcion3.Size = new System.Drawing.Size(103, 20);
            this.rbOpcion3.TabIndex = 8;
            this.rbOpcion3.TabStop = true;
            this.rbOpcion3.Text = "radioButton3";
            this.rbOpcion3.UseVisualStyleBackColor = true;
            // 
            // rbOpcion4
            // 
            this.rbOpcion4.AutoSize = true;
            this.rbOpcion4.Location = new System.Drawing.Point(341, 92);
            this.rbOpcion4.Name = "rbOpcion4";
            this.rbOpcion4.Size = new System.Drawing.Size(103, 20);
            this.rbOpcion4.TabIndex = 9;
            this.rbOpcion4.TabStop = true;
            this.rbOpcion4.Text = "radioButton4";
            this.rbOpcion4.UseVisualStyleBackColor = true;
            // 
            // pbTiempo
            // 
            this.pbTiempo.Location = new System.Drawing.Point(258, 214);
            this.pbTiempo.Name = "pbTiempo";
            this.pbTiempo.Size = new System.Drawing.Size(77, 23);
            this.pbTiempo.TabIndex = 10;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(12, 214);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 11;
            this.btnIniciar.Text = "button1";
            this.btnIniciar.UseVisualStyleBackColor = true;
            // 
            // btnResponder
            // 
            this.btnResponder.Location = new System.Drawing.Point(93, 214);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(75, 23);
            this.btnResponder.TabIndex = 12;
            this.btnResponder.Text = "button2";
            this.btnResponder.UseVisualStyleBackColor = true;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(174, 214);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btnReiniciar.TabIndex = 13;
            this.btnReiniciar.Text = "button3";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            // 
            // lstHistorial
            // 
            this.lstHistorial.FormattingEnabled = true;
            this.lstHistorial.ItemHeight = 16;
            this.lstHistorial.Location = new System.Drawing.Point(11, 12);
            this.lstHistorial.Name = "lstHistorial";
            this.lstHistorial.Size = new System.Drawing.Size(324, 196);
            this.lstHistorial.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 350);
            this.Controls.Add(this.lstHistorial);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnResponder);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.pbTiempo);
            this.Controls.Add(this.rbOpcion4);
            this.Controls.Add(this.rbOpcion3);
            this.Controls.Add(this.rbOpcion2);
            this.Controls.Add(this.rbOpcion1);
            this.Controls.Add(this.lblPreguntasRestantes);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.cmbNivel);
            this.Controls.Add(this.cmbCategoria);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbNivel;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblPreguntasRestantes;
        private System.Windows.Forms.RadioButton rbOpcion1;
        private System.Windows.Forms.RadioButton rbOpcion2;
        private System.Windows.Forms.RadioButton rbOpcion3;
        private System.Windows.Forms.RadioButton rbOpcion4;
        private System.Windows.Forms.ProgressBar pbTiempo;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnResponder;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.ListBox lstHistorial;
    }
}

