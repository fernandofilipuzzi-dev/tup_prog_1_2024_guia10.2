
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ejercicio3_ConClaseControladora_Modal.Models;

namespace Ejercicio3_ConClaseControladora_Modal
{
    public partial class FormPrincipal : Form
    {
        Controlador controlador = new Controlador();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btmVerAlumno_Click(object sender, EventArgs e)
        {
            int lu = Convert.ToInt32(tbLU.Text);

            int idx = controlador.BusquedaSecuencial(lu);
            if (idx < 0)
            {
                //habilita para agregar el alumno
                gbDatosAlumno.Enabled = true;
                tbNombre.Clear();
                tbNota.Clear();
            }
            else
            {
                tbNombre.Text = controlador.Nombres[idx];
                tbNota.Text = $"{controlador.Notas[idx]:f2}";

                gbDatosAlumno.Enabled = false;
            }
        }

        private void btnRegistrarAlumno_Click(object sender, EventArgs e)
        {
            //no necesito verificar como el anterior por la logica de habilitar y deshabilitar los botones

            int lu = Convert.ToInt32(tbLU.Text);
            string nombre = tbNombre.Text;
            double nota = Convert.ToDouble(tbNota.Text);
            controlador.RegistrarAlumno(lu, nombre, nota);

            tbLU.Clear();
            tbNombre.Clear();
            tbNota.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double promedio = controlador.CalcularPromedio();

            lbPromedio.Text = $"{promedio:f2}";
        }

        private void btnVerResultados_Click(object sender, EventArgs e)
        {
            FormResultados fVer =new FormResultados();

            if (fVer.ShowDialog() == DialogResult.OK)//lanza una primera vez la ventana para que elija por que
                //algoritmo ordenar los datos
            {
                #region preinicializando la ventana
                fVer.lbxResultadoListado.Items.Clear();

                if (fVer.rbSuperaronAlPromedio.Checked == true)
                {
                    controlador.CalcularPromedio();
                    controlador.DeterminarAlumnosMayoresAlPromedio();
                    controlador.OrdenarListadoPorLU(controlador.LUsMAP, controlador.NombresMAP, controlador.NotasMAP, controlador.ContadorMAP);

                    for (int n = 0; n < controlador.ContadorMAP; n++)
                    {
                        fVer.lbxResultadoListado.Items.Add($"{controlador.LUsMAP[n]:00000} - {controlador.NombresMAP[n]} - {controlador.NotasMAP[n]:f2}");
                    }
                }
                else if (fVer.rbTodos.Checked == true)
                {
                    controlador.OrdenarListadoPorLU(controlador.LUs, controlador.Nombres, controlador.Notas, controlador.Contador);

                    for (int n = 0; n < controlador.Contador; n++)
                    {
                        fVer.lbxResultadoListado.Items.Add($"{controlador.LUs[n]:00000} - {controlador.Nombres[n]} - {controlador.Notas[n]:f2}");
                    }
                }
                #endregion

                //vuelve a relanzar la ventana para mostrar los datos
                fVer.ShowDialog();
            }
        }
    }
}
