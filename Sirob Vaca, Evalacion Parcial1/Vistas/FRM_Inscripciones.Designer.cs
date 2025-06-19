namespace Sirob_Vaca__Evalacion_Parcial1.Vistas
{
    partial class FRM_Inscripciones
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
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.cmbEstudiantes = new System.Windows.Forms.ComboBox();
            this.cmbCursos = new System.Windows.Forms.ComboBox();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.lstInscripciones = new System.Windows.Forms.ListBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Font = new System.Drawing.Font("Lucida Calligraphy", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiante.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblEstudiante.Location = new System.Drawing.Point(12, 32);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(212, 41);
            this.lblEstudiante.TabIndex = 0;
            this.lblEstudiante.Text = "Estudiante";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Lucida Calligraphy", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCurso.Location = new System.Drawing.Point(12, 150);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(118, 41);
            this.lblCurso.TabIndex = 2;
            this.lblCurso.Text = "Curso";
            // 
            // cmbEstudiantes
            // 
            this.cmbEstudiantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbEstudiantes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstudiantes.Font = new System.Drawing.Font("Lucida Calligraphy", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstudiantes.ForeColor = System.Drawing.Color.Navy;
            this.cmbEstudiantes.FormattingEnabled = true;
            this.cmbEstudiantes.Location = new System.Drawing.Point(230, 24);
            this.cmbEstudiantes.Name = "cmbEstudiantes";
            this.cmbEstudiantes.Size = new System.Drawing.Size(494, 49);
            this.cmbEstudiantes.TabIndex = 3;
            // 
            // cmbCursos
            // 
            this.cmbCursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCursos.Font = new System.Drawing.Font("Lucida Calligraphy", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCursos.ForeColor = System.Drawing.Color.Navy;
            this.cmbCursos.FormattingEnabled = true;
            this.cmbCursos.Location = new System.Drawing.Point(231, 150);
            this.cmbCursos.Name = "cmbCursos";
            this.cmbCursos.Size = new System.Drawing.Size(493, 49);
            this.cmbCursos.TabIndex = 4;
            // 
            // btnInscribir
            // 
            this.btnInscribir.BackColor = System.Drawing.Color.Red;
            this.btnInscribir.Font = new System.Drawing.Font("Lucida Calligraphy", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscribir.ForeColor = System.Drawing.Color.White;
            this.btnInscribir.Location = new System.Drawing.Point(39, 283);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(238, 97);
            this.btnInscribir.TabIndex = 5;
            this.btnInscribir.Text = "Inscribir";
            this.btnInscribir.UseVisualStyleBackColor = false;
            this.btnInscribir.Click += new System.EventHandler(this.btnInscribir_Click);
            // 
            // lstInscripciones
            // 
            this.lstInscripciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstInscripciones.Font = new System.Drawing.Font("Lucida Calligraphy", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstInscripciones.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lstInscripciones.FormattingEnabled = true;
            this.lstInscripciones.ItemHeight = 41;
            this.lstInscripciones.Location = new System.Drawing.Point(757, 24);
            this.lstInscripciones.Name = "lstInscripciones";
            this.lstInscripciones.Size = new System.Drawing.Size(630, 414);
            this.lstInscripciones.TabIndex = 6;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Lucida Calligraphy", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(376, 283);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(238, 97);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FRM_Inscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1410, 474);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lstInscripciones);
            this.Controls.Add(this.btnInscribir);
            this.Controls.Add(this.cmbCursos);
            this.Controls.Add(this.cmbEstudiantes);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblEstudiante);
            this.Name = "FRM_Inscripciones";
            this.Text = "FRM_Inscripciones";
            this.Load += new System.EventHandler(this.FRM_Inscripciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.ComboBox cmbEstudiantes;
        private System.Windows.Forms.ComboBox cmbCursos;
        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.ListBox lstInscripciones;
        private System.Windows.Forms.Button btnEliminar;
    }
}