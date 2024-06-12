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
        int[] LUs = new int[100];
        string[] Nombres = new string[100];
        double[] Notas = new double[100];
        int contador = 0;
        #endregion

        #region datos datos MAP: Mayores Al Promedio 
        int[] LUsMAP = new int[100];
        string[] NombresMAP = new string[100];
        double[] NotasMAP = new double[100];
        int contadorMAP = 0;
        #endregion

        void RegistrarAlumno(int lu, string nombre, double nota)
        {
            LUs[contador] = lu;
            Nombres[contador] = nombre;
            Notas[contador] = nota;
            contador++;
        }

        double CalcularPromedio()
        {
            double promedio = 0;
            for (int n = 0; n < contador; n++)
            {
                promedio += Notas[n];
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
                if (Notas[n] >= promedioGeneral)
                {
                    AgregarAlumnoMayorAlPromedio(n);
                }
            }
        }

        void AgregarAlumnoMayorAlPromedio(int idx)
        {
            LUsMAP[idx] = LUs[idx];
            NombresMAP[idx] = Nombres[idx];
            NotasMAP[idx] = Notas[idx];

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
                if (LUs[n] == numeroBuscar)
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

                if (LUs[c] == numeroBuscar)
                {
                    idx = c;
                }
                else if (numeroBuscar < LUs[c])
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
                RegistrarAlumno(lu, nombre, nota);
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

            OrdenarListadoPorLU(LUs, Nombres, Notas, contador);
            idx = BusquedaBinaria(luBuscar);

            lbxResultadoVer.Items.Clear();

            if (idx > -1)
            {
                lbxResultadoVer.Items.Add($"{LUs[idx]}");
                lbxResultadoVer.Items.Add($"{Nombres[idx]}");
                lbxResultadoVer.Items.Add($"{Notas[idx]}:f2");
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
                OrdenarListadoPorLU(LUsMAP, NombresMAP, NotasMAP, contadorMAP);

                for (int n = 0; n < contadorMAP; n++)
                {
                    lbxResultadoListado.Items.Add($"{LUsMAP[n]:00000} - {NombresMAP[n]} - {NotasMAP[n]:f2}");
                }
            }
            else if (rbTodos.Checked == true)
            {
                OrdenarListadoPorLU(LUs, Nombres, Notas, contador);

                for (int n = 0; n < contador; n++)
                {
                    lbxResultadoListado.Items.Add($"{LUs[n]:00000} - {Nombres[n]} - {Notas[n]:f2}");
                }
            }
        }
    }
}
