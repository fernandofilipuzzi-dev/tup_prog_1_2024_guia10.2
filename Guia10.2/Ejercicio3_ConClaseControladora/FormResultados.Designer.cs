namespace Ejercicio3_ConClaseControladora_Modal
{
    partial class FormResultados
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gbOpcion = new System.Windows.Forms.GroupBox();
            this.rbSuperaronAlPromedio = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.lbxResultadoListado = new System.Windows.Forms.ListBox();
            this.btnVerResultados = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.gbOpcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gbOpcion);
            this.groupBox3.Controls.Add(this.lbxResultadoListado);
            this.groupBox3.Controls.Add(this.btnVerResultados);
            this.groupBox3.Location = new System.Drawing.Point(4, 13);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(423, 286);
            this.groupBox3.TabIndex = 13;
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
            this.rbSuperaronAlPromedio.Size = new System.Drawing.Size(131, 17);
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
            this.rbTodos.Size = new System.Drawing.Size(55, 17);
            this.rbTodos.TabIndex = 9;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // lbxResultadoListado
            // 
            this.lbxResultadoListado.FormattingEnabled = true;
            this.lbxResultadoListado.Location = new System.Drawing.Point(8, 23);
            this.lbxResultadoListado.Margin = new System.Windows.Forms.Padding(4);
            this.lbxResultadoListado.Name = "lbxResultadoListado";
            this.lbxResultadoListado.Size = new System.Drawing.Size(206, 251);
            this.lbxResultadoListado.TabIndex = 3;
            // 
            // btnVerResultados
            // 
            this.btnVerResultados.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnVerResultados.Location = new System.Drawing.Point(271, 92);
            this.btnVerResultados.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerResultados.Name = "btnVerResultados";
            this.btnVerResultados.Size = new System.Drawing.Size(91, 69);
            this.btnVerResultados.TabIndex = 6;
            this.btnVerResultados.Text = "Ver resultados";
            this.btnVerResultados.UseVisualStyleBackColor = true;
            // 
            // FormResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 304);
            this.Controls.Add(this.groupBox3);
            this.Name = "FormResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormResultados";
            this.groupBox3.ResumeLayout(false);
            this.gbOpcion.ResumeLayout(false);
            this.gbOpcion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gbOpcion;
        private System.Windows.Forms.Button btnVerResultados;
        public System.Windows.Forms.RadioButton rbSuperaronAlPromedio;
        public System.Windows.Forms.RadioButton rbTodos;
        public System.Windows.Forms.ListBox lbxResultadoListado;
    }
}