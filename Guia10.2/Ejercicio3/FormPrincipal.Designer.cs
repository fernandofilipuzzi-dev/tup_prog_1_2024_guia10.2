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
            this.lbxResultados = new System.Windows.Forms.ListBox();
            this.btnVerResultados = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLibreta = new System.Windows.Forms.TextBox();
            this.btmVerAlumno = new System.Windows.Forms.Button();
            this.gbOpcion = new System.Windows.Forms.GroupBox();
            this.rbSuperaronAlPromedio = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbOpcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gbOpcion);
            this.groupBox3.Controls.Add(this.lbxResultados);
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
            // lbxResultados
            // 
            this.lbxResultados.FormattingEnabled = true;
            this.lbxResultados.ItemHeight = 16;
            this.lbxResultados.Location = new System.Drawing.Point(8, 23);
            this.lbxResultados.Margin = new System.Windows.Forms.Padding(4);
            this.lbxResultados.Name = "lbxResultados";
            this.lbxResultados.Size = new System.Drawing.Size(206, 260);
            this.lbxResultados.TabIndex = 3;
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
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(120, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "lbPromedio";
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbLibreta);
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.tbNombre);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.tbNota);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(13, 81);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(460, 116);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Editar Datos alumno";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(328, 49);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 42);
            this.button4.TabIndex = 7;
            this.button4.Text = "Registrar Alumno";
            this.button4.UseVisualStyleBackColor = true;
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
            // tbLibreta
            // 
            this.tbLibreta.Location = new System.Drawing.Point(124, 42);
            this.tbLibreta.Margin = new System.Windows.Forms.Padding(4);
            this.tbLibreta.Name = "tbLibreta";
            this.tbLibreta.Size = new System.Drawing.Size(187, 23);
            this.tbLibreta.TabIndex = 2;
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbOpcion.ResumeLayout(false);
            this.gbOpcion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbxResultados;
        private System.Windows.Forms.Button btnVerResultados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLibreta;
        private System.Windows.Forms.Button btmVerAlumno;
        private System.Windows.Forms.GroupBox gbOpcion;
        private System.Windows.Forms.RadioButton rbSuperaronAlPromedio;
        private System.Windows.Forms.RadioButton rbTodos;
    }
}

