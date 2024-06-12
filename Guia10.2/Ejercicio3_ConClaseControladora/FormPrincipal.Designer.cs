namespace Ejercicio3_ConClaseControladora_Modal
{
    partial class FormPrincipal
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbPromedio = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbDatosAlumno = new System.Windows.Forms.GroupBox();
            this.btnRegistrarAlumno = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLU = new System.Windows.Forms.TextBox();
            this.btmVerAlumno = new System.Windows.Forms.Button();
            this.btnVerResultados = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbDatosAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbPromedio);
            this.groupBox2.Controls.Add(this.btnCalcular);
            this.groupBox2.Controls.Add(this.btnVerResultados);
            this.groupBox2.Location = new System.Drawing.Point(11, 228);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(479, 116);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mostrar Resultados";
            // 
            // lbPromedio
            // 
            this.lbPromedio.AutoSize = true;
            this.lbPromedio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbPromedio.Location = new System.Drawing.Point(120, 36);
            this.lbPromedio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPromedio.Name = "lbPromedio";
            this.lbPromedio.Size = new System.Drawing.Size(59, 13);
            this.lbPromedio.TabIndex = 2;
            this.lbPromedio.Text = "lbPromedio";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(341, 23);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(115, 42);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Ver Promedio General";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbDatosAlumno);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbLU);
            this.groupBox1.Controls.Add(this.btmVerAlumno);
            this.groupBox1.Location = new System.Drawing.Point(11, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(479, 207);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del alumno";
            // 
            // gbDatosAlumno
            // 
            this.gbDatosAlumno.Controls.Add(this.btnRegistrarAlumno);
            this.gbDatosAlumno.Controls.Add(this.label3);
            this.gbDatosAlumno.Controls.Add(this.tbNombre);
            this.gbDatosAlumno.Controls.Add(this.label2);
            this.gbDatosAlumno.Controls.Add(this.tbNota);
            this.gbDatosAlumno.Enabled = false;
            this.gbDatosAlumno.Location = new System.Drawing.Point(13, 81);
            this.gbDatosAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.gbDatosAlumno.Name = "gbDatosAlumno";
            this.gbDatosAlumno.Padding = new System.Windows.Forms.Padding(4);
            this.gbDatosAlumno.Size = new System.Drawing.Size(460, 116);
            this.gbDatosAlumno.TabIndex = 6;
            this.gbDatosAlumno.TabStop = false;
            this.gbDatosAlumno.Text = "Editar Datos alumno";
            // 
            // btnRegistrarAlumno
            // 
            this.btnRegistrarAlumno.Location = new System.Drawing.Point(328, 49);
            this.btnRegistrarAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarAlumno.Name = "btnRegistrarAlumno";
            this.btnRegistrarAlumno.Size = new System.Drawing.Size(115, 42);
            this.btnRegistrarAlumno.TabIndex = 7;
            this.btnRegistrarAlumno.Text = "Registrar Alumno";
            this.btnRegistrarAlumno.UseVisualStyleBackColor = true;
            this.btnRegistrarAlumno.Click += new System.EventHandler(this.btnRegistrarAlumno_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nota";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(111, 36);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(187, 20);
            this.tbNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // tbNota
            // 
            this.tbNota.Location = new System.Drawing.Point(111, 68);
            this.tbNota.Margin = new System.Windows.Forms.Padding(4);
            this.tbNota.Name = "tbNota";
            this.tbNota.Size = new System.Drawing.Size(187, 20);
            this.tbNota.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Libreta";
            // 
            // tbLU
            // 
            this.tbLU.Location = new System.Drawing.Point(124, 42);
            this.tbLU.Margin = new System.Windows.Forms.Padding(4);
            this.tbLU.Name = "tbLU";
            this.tbLU.Size = new System.Drawing.Size(187, 20);
            this.tbLU.TabIndex = 2;
            // 
            // btmVerAlumno
            // 
            this.btmVerAlumno.Location = new System.Drawing.Point(341, 32);
            this.btmVerAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.btmVerAlumno.Name = "btmVerAlumno";
            this.btmVerAlumno.Size = new System.Drawing.Size(115, 42);
            this.btmVerAlumno.TabIndex = 1;
            this.btmVerAlumno.Text = "Ver alumno";
            this.btmVerAlumno.UseVisualStyleBackColor = true;
            this.btmVerAlumno.Click += new System.EventHandler(this.btmVerAlumno_Click);
            // 
            // btnVerResultados
            // 
            this.btnVerResultados.Location = new System.Drawing.Point(341, 68);
            this.btnVerResultados.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerResultados.Name = "btnVerResultados";
            this.btnVerResultados.Size = new System.Drawing.Size(115, 40);
            this.btnVerResultados.TabIndex = 6;
            this.btnVerResultados.Text = "Ver listado";
            this.btnVerResultados.UseVisualStyleBackColor = true;
            this.btnVerResultados.Click += new System.EventHandler(this.btnVerResultados_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 349);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbDatosAlumno.ResumeLayout(false);
            this.gbDatosAlumno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbPromedio;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbDatosAlumno;
        private System.Windows.Forms.Button btnRegistrarAlumno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLU;
        private System.Windows.Forms.Button btmVerAlumno;
        private System.Windows.Forms.Button btnVerResultados;
    }
}

