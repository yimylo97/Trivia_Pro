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
            this.components = new System.ComponentModel.Container();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.rbOpcion1 = new System.Windows.Forms.RadioButton();
            this.rbOpcion2 = new System.Windows.Forms.RadioButton();
            this.rbOpcion3 = new System.Windows.Forms.RadioButton();
            this.rbOpcion4 = new System.Windows.Forms.RadioButton();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnResponder = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.lstHistorial = new System.Windows.Forms.ListBox();
            this.progressTiempo = new System.Windows.Forms.ProgressBar();
            this.timerPregunta = new System.Windows.Forms.Timer(this.components);
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
            this.lblPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.Location = new System.Drawing.Point(446, 12);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(261, 36);
            this.lblPregunta.TabIndex = 2;
            this.lblPregunta.Text = "Mostrar Pregunta";
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Location = new System.Drawing.Point(338, 293);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(169, 16);
            this.lblPuntaje.TabIndex = 3;
            this.lblPuntaje.Text = "Mostrar puntaje acumulado";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(338, 266);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(147, 16);
            this.lblTiempo.TabIndex = 4;
            this.lblTiempo.Text = "Mostrar tiempo restante\n";
            // 
            // rbOpcion1
            // 
            this.rbOpcion1.AutoSize = true;
            this.rbOpcion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOpcion1.Location = new System.Drawing.Point(452, 70);
            this.rbOpcion1.Name = "rbOpcion1";
            this.rbOpcion1.Size = new System.Drawing.Size(112, 29);
            this.rbOpcion1.TabIndex = 6;
            this.rbOpcion1.TabStop = true;
            this.rbOpcion1.Text = "Opción 1";
            this.rbOpcion1.UseVisualStyleBackColor = true;
            // 
            // rbOpcion2
            // 
            this.rbOpcion2.AutoSize = true;
            this.rbOpcion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOpcion2.Location = new System.Drawing.Point(452, 121);
            this.rbOpcion2.Name = "rbOpcion2";
            this.rbOpcion2.Size = new System.Drawing.Size(112, 29);
            this.rbOpcion2.TabIndex = 7;
            this.rbOpcion2.TabStop = true;
            this.rbOpcion2.Text = "Opción 2";
            this.rbOpcion2.UseVisualStyleBackColor = true;
            // 
            // rbOpcion3
            // 
            this.rbOpcion3.AutoSize = true;
            this.rbOpcion3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOpcion3.Location = new System.Drawing.Point(452, 179);
            this.rbOpcion3.Name = "rbOpcion3";
            this.rbOpcion3.Size = new System.Drawing.Size(112, 29);
            this.rbOpcion3.TabIndex = 8;
            this.rbOpcion3.TabStop = true;
            this.rbOpcion3.Text = "Opción 3";
            this.rbOpcion3.UseVisualStyleBackColor = true;
            // 
            // rbOpcion4
            // 
            this.rbOpcion4.AutoSize = true;
            this.rbOpcion4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOpcion4.Location = new System.Drawing.Point(452, 231);
            this.rbOpcion4.Name = "rbOpcion4";
            this.rbOpcion4.Size = new System.Drawing.Size(112, 29);
            this.rbOpcion4.TabIndex = 9;
            this.rbOpcion4.TabStop = true;
            this.rbOpcion4.Text = "Opción 4";
            this.rbOpcion4.UseVisualStyleBackColor = true;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(12, 214);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 11;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnResponder
            // 
            this.btnResponder.Location = new System.Drawing.Point(93, 214);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(75, 23);
            this.btnResponder.TabIndex = 12;
            this.btnResponder.Text = "Confirmar respuesta";
            this.btnResponder.UseVisualStyleBackColor = true;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(174, 214);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btnReiniciar.TabIndex = 13;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
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
            // progressTiempo
            // 
            this.progressTiempo.Location = new System.Drawing.Point(255, 214);
            this.progressTiempo.Name = "progressTiempo";
            this.progressTiempo.Size = new System.Drawing.Size(80, 23);
            this.progressTiempo.TabIndex = 15;
            // 
            // timerPregunta
            // 
            this.timerPregunta.Tick += new System.EventHandler(this.timerPregunta_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 481);
            this.Controls.Add(this.progressTiempo);
            this.Controls.Add(this.lstHistorial);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnResponder);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.rbOpcion4);
            this.Controls.Add(this.rbOpcion3);
            this.Controls.Add(this.rbOpcion2);
            this.Controls.Add(this.rbOpcion1);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.cmbNivel);
            this.Controls.Add(this.cmbCategoria);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbNivel;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.RadioButton rbOpcion1;
        private System.Windows.Forms.RadioButton rbOpcion2;
        private System.Windows.Forms.RadioButton rbOpcion3;
        private System.Windows.Forms.RadioButton rbOpcion4;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnResponder;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.ListBox lstHistorial;
        private System.Windows.Forms.ProgressBar progressTiempo;
        private System.Windows.Forms.Timer timerPregunta;
    }
}

