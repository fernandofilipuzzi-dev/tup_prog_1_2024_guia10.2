namespace Ejercicio3
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gbOpcion = new System.Windows.Forms.GroupBox();
            this.rbSuperaronAlPromedio = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.lbxResultadoListado = new System.Windows.Forms.ListBox();
            this.btnVerResultados = new System.Windows.Forms.Button();
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
            this.groupBox3.SuspendLayout();
            this.gbOpcion.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbDatosAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gbOpcion);
            this.groupBox3.Controls.Add(this.lbxResultadoListado);
            this.groupBox3.Controls.Add(this.btnVerResultados);
            this.groupBox3.Location = new System.Drawing.Point(503, 17);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(423, 286);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultados";
            // 
            // gbOpcion
            // 
            this.gbOpcion.Controls.Add(this.rbSuperaronAlPromedio);
            this.gbOpcion.Controls.Add(this.rbTodos);
            this.gbOpcion.Location = new System.Drawing.Point(221, 173);
            this.gbOpcion.Name = "gbOpcion";
            this.gbOpcion.Size = new System.Drawing.Size(195, 92);
            this.gbOpcion.TabIndex = 7;
            this.gbOpcion.TabStop = false;
            this.gbOpcion.Text = "Opciones";
            // 
            // rbSuperaronAlPromedio
            // 
            this.rbSuperaronAlPromedio.AutoSize = true;
            this.rbSuperaronAlPromedio.Location = new System.Drawing.Point(15, 30);
            this.rbSuperaronAlPromedio.Name = "rbSuperaronAlPromedio";
            this.rbSuperaronAlPromedio.Size = new System.Drawing.Size(171, 21);
            this.rbSuperaronAlPromedio.TabIndex = 8;
            this.rbSuperaronAlPromedio.Text = "Superaron el promedio";
            this.rbSuperaronAlPromedio.UseVisualStyleBackColor = true;
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Checked = true;
            this.rbTodos.Location = new System.Drawing.Point(15, 56);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(66, 21);
            this.rbTodos.TabIndex = 9;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // lbxResultadoListado
            // 
            this.lbxResultadoListado.FormattingEnabled = true;
            this.lbxResultadoListado.ItemHeight = 16;
            this.lbxResultadoListado.Location = new System.Drawing.Point(8, 23);
            this.lbxResultadoListado.Margin = new System.Windows.Forms.Padding(4);
            this.lbxResultadoListado.Name = "lbxResultadoListado";
            this.lbxResultadoListado.Size = new System.Drawing.Size(206, 260);
            this.lbxResultadoListado.TabIndex = 3;
            // 
            // btnVerResultados
            // 
            this.btnVerResultados.Location = new System.Drawing.Point(271, 92);
            this.btnVerResultados.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerResultados.Name = "btnVerResultados";
            this.btnVerResultados.Size = new System.Drawing.Size(91, 69);
            this.btnVerResultados.TabIndex = 6;
            this.btnVerResultados.Text = "Ver resultados";
            this.btnVerResultados.UseVisualStyleBackColor = true;
            this.btnVerResultados.Click += new System.EventHandler(this.btnVerResultados_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbPromedio);
            this.groupBox2.Controls.Add(this.btnCalcular);
            this.groupBox2.Location = new System.Drawing.Point(16, 229);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(479, 74);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mostrar promedio";
            // 
            // lbPromedio
            // 
            this.lbPromedio.AutoSize = true;
            this.lbPromedio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbPromedio.Location = new System.Drawing.Point(120, 36);
            this.lbPromedio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPromedio.Name = "lbPromedio";
            this.lbPromedio.Size = new System.Drawing.Size(79, 17);
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
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbDatosAlumno);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbLU);
            this.groupBox1.Controls.Add(this.btmVerAlumno);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(479, 207);
            this.groupBox1.TabIndex = 7;
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
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nota";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(111, 36);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(187, 23);
            this.tbNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // tbNota
            // 
            this.tbNota.Location = new System.Drawing.Point(111, 68);
            this.tbNota.Margin = new System.Windows.Forms.Padding(4);
            this.tbNota.Name = "tbNota";
            this.tbNota.Size = new System.Drawing.Size(187, 23);
            this.tbNota.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Libreta";
            // 
            // tbLU
            // 
            this.tbLU.Location = new System.Drawing.Point(124, 42);
            this.tbLU.Margin = new System.Windows.Forms.Padding(4);
            this.tbLU.Name = "tbLU";
            this.tbLU.Size = new System.Drawing.Size(187, 23);
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
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 308);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrincipal";
            this.Text = "Ejercicio 3";
            this.groupBox3.ResumeLayout(false);
            this.gbOpcion.ResumeLayout(false);
            this.gbOpcion.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbDatosAlumno.ResumeLayout(false);
            this.gbDatosAlumno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbxResultadoListado;
        private System.Windows.Forms.Button btnVerResultados;
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
        private System.Windows.Forms.GroupBox gbOpcion;
        private System.Windows.Forms.RadioButton rbSuperaronAlPromedio;
        private System.Windows.Forms.RadioButton rbTodos;
    }
}

