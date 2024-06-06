namespace Ejercicio2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrarAlumno = new System.Windows.Forms.Button();
            this.tbNota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btnVerAlumno = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbPromedio = new System.Windows.Forms.Label();
            this.btnCalcularPromedio = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gbOpcion = new System.Windows.Forms.GroupBox();
            this.rbSuperaronAlPromedio = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.lbxResultadoListado = new System.Windows.Forms.ListBox();
            this.btnVerResultados = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbxResultadoVer = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLUBuscar = new System.Windows.Forms.TextBox();
            this.tbLU = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbOpcion.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbLU);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnRegistrarAlumno);
            this.groupBox1.Controls.Add(this.tbNota);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(468, 137);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del alumno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nota";
            // 
            // btnRegistrarAlumno
            // 
            this.btnRegistrarAlumno.Location = new System.Drawing.Point(341, 59);
            this.btnRegistrarAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarAlumno.Name = "btnRegistrarAlumno";
            this.btnRegistrarAlumno.Size = new System.Drawing.Size(115, 42);
            this.btnRegistrarAlumno.TabIndex = 4;
            this.btnRegistrarAlumno.Text = "Registrar Alumno";
            this.btnRegistrarAlumno.UseVisualStyleBackColor = true;
            this.btnRegistrarAlumno.Click += new System.EventHandler(this.btnRegistrarAlumno_Click);
            // 
            // tbNota
            // 
            this.tbNota.Location = new System.Drawing.Point(119, 101);
            this.tbNota.Margin = new System.Windows.Forms.Padding(4);
            this.tbNota.Name = "tbNota";
            this.tbNota.Size = new System.Drawing.Size(187, 22);
            this.tbNota.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Libreta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(119, 69);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(187, 22);
            this.tbNombre.TabIndex = 2;
            // 
            // btnVerAlumno
            // 
            this.btnVerAlumno.Location = new System.Drawing.Point(341, 12);
            this.btnVerAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerAlumno.Name = "btnVerAlumno";
            this.btnVerAlumno.Size = new System.Drawing.Size(115, 42);
            this.btnVerAlumno.TabIndex = 7;
            this.btnVerAlumno.Text = "Ver alumno";
            this.btnVerAlumno.UseVisualStyleBackColor = true;
            this.btnVerAlumno.Click += new System.EventHandler(this.btnVerAlumno_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbPromedio);
            this.groupBox2.Controls.Add(this.btnCalcularPromedio);
            this.groupBox2.Location = new System.Drawing.Point(16, 159);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(468, 66);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mostrar promedio";
            // 
            // lbPromedio
            // 
            this.lbPromedio.AutoSize = true;
            this.lbPromedio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbPromedio.Location = new System.Drawing.Point(115, 38);
            this.lbPromedio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPromedio.Name = "lbPromedio";
            this.lbPromedio.Size = new System.Drawing.Size(77, 16);
            this.lbPromedio.TabIndex = 2;
            this.lbPromedio.Text = "lbPromedio";
            // 
            // btnCalcularPromedio
            // 
            this.btnCalcularPromedio.Location = new System.Drawing.Point(341, 17);
            this.btnCalcularPromedio.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcularPromedio.Name = "btnCalcularPromedio";
            this.btnCalcularPromedio.Size = new System.Drawing.Size(115, 42);
            this.btnCalcularPromedio.TabIndex = 5;
            this.btnCalcularPromedio.Text = "Calcular";
            this.btnCalcularPromedio.UseVisualStyleBackColor = true;
            this.btnCalcularPromedio.Click += new System.EventHandler(this.btnCalcularPromedio_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gbOpcion);
            this.groupBox3.Controls.Add(this.lbxResultadoListado);
            this.groupBox3.Controls.Add(this.btnVerResultados);
            this.groupBox3.Location = new System.Drawing.Point(492, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(475, 359);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultados";
            // 
            // gbOpcion
            // 
            this.gbOpcion.Controls.Add(this.rbSuperaronAlPromedio);
            this.gbOpcion.Controls.Add(this.rbTodos);
            this.gbOpcion.Location = new System.Drawing.Point(290, 130);
            this.gbOpcion.Name = "gbOpcion";
            this.gbOpcion.Size = new System.Drawing.Size(177, 92);
            this.gbOpcion.TabIndex = 6;
            this.gbOpcion.TabStop = false;
            this.gbOpcion.Text = "Opciones";
            // 
            // rbSuperaronAlPromedio
            // 
            this.rbSuperaronAlPromedio.AutoSize = true;
            this.rbSuperaronAlPromedio.Location = new System.Drawing.Point(15, 30);
            this.rbSuperaronAlPromedio.Name = "rbSuperaronAlPromedio";
            this.rbSuperaronAlPromedio.Size = new System.Drawing.Size(163, 20);
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
            this.rbTodos.Size = new System.Drawing.Size(65, 20);
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
            this.lbxResultadoListado.Size = new System.Drawing.Size(280, 324);
            this.lbxResultadoListado.TabIndex = 3;
            // 
            // btnVerResultados
            // 
            this.btnVerResultados.Location = new System.Drawing.Point(334, 60);
            this.btnVerResultados.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerResultados.Name = "btnVerResultados";
            this.btnVerResultados.Size = new System.Drawing.Size(99, 42);
            this.btnVerResultados.TabIndex = 10;
            this.btnVerResultados.Text = "Ver Resultados";
            this.btnVerResultados.UseVisualStyleBackColor = true;
            this.btnVerResultados.Click += new System.EventHandler(this.btnVerResultados_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbxResultadoVer);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.tbLUBuscar);
            this.groupBox4.Controls.Add(this.btnVerAlumno);
            this.groupBox4.Location = new System.Drawing.Point(16, 233);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(468, 142);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mostrar promedio";
            // 
            // lbxResultadoVer
            // 
            this.lbxResultadoVer.FormattingEnabled = true;
            this.lbxResultadoVer.ItemHeight = 16;
            this.lbxResultadoVer.Location = new System.Drawing.Point(49, 74);
            this.lbxResultadoVer.Margin = new System.Windows.Forms.Padding(4);
            this.lbxResultadoVer.Name = "lbxResultadoVer";
            this.lbxResultadoVer.Size = new System.Drawing.Size(405, 52);
            this.lbxResultadoVer.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Libreta";
            // 
            // tbLUBuscar
            // 
            this.tbLUBuscar.Location = new System.Drawing.Point(119, 32);
            this.tbLUBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.tbLUBuscar.Name = "tbLUBuscar";
            this.tbLUBuscar.Size = new System.Drawing.Size(187, 22);
            this.tbLUBuscar.TabIndex = 6;
            // 
            // tbLU
            // 
            this.tbLU.Location = new System.Drawing.Point(119, 39);
            this.tbLU.Margin = new System.Windows.Forms.Padding(4);
            this.tbLU.Name = "tbLU";
            this.tbLU.Size = new System.Drawing.Size(187, 22);
            this.tbLU.TabIndex = 1;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 382);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrincipal";
            this.Text = "Ejercicio 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.gbOpcion.ResumeLayout(false);
            this.gbOpcion.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVerAlumno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbNota;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbPromedio;
        private System.Windows.Forms.Button btnCalcularPromedio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbxResultadoListado;
        private System.Windows.Forms.Button btnVerResultados;
        private System.Windows.Forms.Button btnRegistrarAlumno;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lbxResultadoVer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLUBuscar;
        private System.Windows.Forms.GroupBox gbOpcion;
        private System.Windows.Forms.RadioButton rbSuperaronAlPromedio;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.TextBox tbLU;
    }
}

