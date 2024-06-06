using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class FormPrincipal : Form
    {
        #region variables y metodos del dominio

        #region datos de alumnos
        int[] lus = new int[100];
        string[] nombres = new string[100];
        double[] notas = new double[100];
        int contador = 0;
        #endregion

        #region datos Mayores al Promedio MP
        int[] lusMAP = new int[100];
        string[] nombresMAP = new string[100];
        double[] notasMAP = new double[100];
        int contadorMAP = 0;
        #endregion

        void CargarValor(int lu, string nombre, double nota)
        {
            lus[contador] = lu;
            nombres[contador] = nombre;
            notas[contador] = nota;
            contador++;
        }

        double CalcularPromedio()
        {
            double promedio = 0;
            for (int n = 0; n < contador; n++)
            {
                promedio += notas[n];
            }
            if (contador > 0)
                promedio /= contador;
            return promedio;
        }

        void DeterminarAlumnosMayoresAlPromedio()
        {
            double promedioGeneral = CalcularPromedio();
            for (int n = 0; n < contador; n++)
            {
                if (notas[n] >= promedioGeneral)
                {
                    AgregarAlumnoMayorAlPromedio(n);
                }
            }
        }

        void AgregarAlumnoMayorAlPromedio(int idx)
        {
            lusMAP[idx] = lus[idx];
            nombresMAP[idx] = nombres[idx];
            notasMAP[idx] = notas[idx];

            contadorMAP++;
        }

        void OrdenarListadoPorLU(int[] lus, string[] nombres, double[] notas, int contador)
        {
            for (int actual = 0; actual < contador - 1; actual++)
            {
                for (int sig = actual + 1; sig < contador; sig++)
                {
                    if (lus[actual] > lus[sig])
                    {
                        #region intercambio
                        int auxlu = lus[actual];
                        lus[actual] = lus[sig];
                        lus[sig] = auxlu;

                        string auxNombre = nombres[actual];
                        nombres[actual] = nombres[sig];
                        nombres[sig] = auxNombre;

                        double auxNota = notas[actual];
                        notas[actual] = notas[sig];
                        notas[sig] = auxNota;
                        #endregion
                    }
                }
            }
        }

        int BusquedaSecuencial(int numeroBuscar)
        {
            int idx = -1;
            int n = 0;
            while (n < contador && idx == -1)
            {
                if (lus[n] == numeroBuscar)
                {
                    idx = n;
                }
                n++;
            }
            return idx;
        }

        int BusquedaBinaria(int numeroBuscar)
        {
            int idx = -1;
            int inf = 0;
            int sup = contador;

            while (inf <= sup && idx == -1)
            {
                int c = (sup + inf) / 2;

                if (lus[c] == numeroBuscar)
                {
                    idx = c;
                }
                else if (numeroBuscar < lus[c])
                {
                    sup = c - 1;
                }
                else
                {
                    inf = c + 1;
                }
            }
            return idx;
        }

        #endregion

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrarAlumno_Click(object sender, EventArgs e)
        {
            int lu = Convert.ToInt32(tbLU.Text);

            int idx = BusquedaSecuencial(lu);
            if (idx < 0)
            {
                string nombre = tbNombre.Text;
                double nota = Convert.ToDouble(tbNota.Text);
                CargarValor(lu, nombre, nota);
            }
            else
            {
                MessageBox.Show("Error al intentar agregar el registro. Existe un registro con ese número de libreta");
            }

            tbLU.Clear();
            tbNombre.Clear();
            tbNota.Clear();
        }

        private void btnCalcularPromedio_Click(object sender, EventArgs e)
        {
            double promedio = CalcularPromedio();
            lbPromedio.Text = $"{promedio:f2}";
        }

        private void btnVerAlumno_Click(object sender, EventArgs e)
        {
            int luBuscar = Convert.ToInt32(tbLUBuscar.Text);
            int idx = -1;

            //idx = BusquedaSecuencial(numeroBuscar);
            //

            OrdenarListadoPorLU(lus, nombres, notas, contador);
            idx = BusquedaBinaria(luBuscar);

            lbxResultadoVer.Items.Clear();

            if (idx > -1)
            {
                lbxResultadoVer.Items.Add($"{lus[idx]}");
                lbxResultadoVer.Items.Add($"{nombres[idx]}");
                lbxResultadoVer.Items.Add($"{notas[idx]}:f2");
            }
            else 
            {
                lbxResultadoVer.Items.Add($"Registro no encontrado");
            }
        }

        private void btnVerResultados_Click(object sender, EventArgs e)
        {
            lbxResultadoListado.Items.Clear();

            if (rbSuperaronAlPromedio.Checked == true)
            {
                CalcularPromedio();
                DeterminarAlumnosMayoresAlPromedio();
                OrdenarListadoPorLU(lusMAP, nombresMAP, notasMAP, contadorMAP);

                for (int n = 0; n < contadorMAP; n++)
                {
                    lbxResultadoListado.Items.Add($"{lusMAP[n]:00000} - {nombresMAP[n]} - {notasMAP[n]:f2}");
                }
            }
            else if (rbTodos.Checked == true)
            {
                OrdenarListadoPorLU(lus, nombres, notas, contador);

                for (int n = 0; n < contador; n++)
                {
                    lbxResultadoListado.Items.Add($"{lus[n]:00000} - {nombres[n]} - {notas[n]:f2}");
                }
            }
        }
    }
}
