using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp20
{
    public partial class FormPrincipal : Form
    {
        #region dominio del problema
        int[] Numeros = new int[100];
        int contador = 0;

        void AgregarNumero(int numero)
        {
            Numeros[contador++] = numero);
        }

        double CalcularPromedio()
        {
            double acum = 0, promedio = 0;
            for (int n = 0; n < contador; n++)
            {
                acum += Numeros[n];
            }
            promedio += acum / contador;
            return promedio;
        }

        int BusquedaSecuencial(int numeroBuscar)
        {
            int idx = -1;
            int n = 0;
            while (n < contador && idx == -1)
            {
                if (Numeros[n] == numeroBuscar)
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
            
            while (inf<=sup && idx==-1)
            {
                int c = (sup + inf) / 2;

                if (Numeros[c] == numeroBuscar)
                {
                    idx = c;
                }
                else if (numeroBuscar<Numeros[c])
                {
                    sup = c-1;
                }
                else
                {
                    inf = c+1;
                }
            }
            return idx;
        }

        void Ordenar()
        {
            for (int n = 0; n < contador - 1; n++)//actual
            {
                for (int m = n+1; m < contador ; m++)//siguientes
                {
                    if (Numeros[n] > Numeros[m])
                    { 
                        int aux=Numeros[n];
                        Numeros[n] = Numeros[m];
                        Numeros[m] = aux;
                    }
                }
            }
        }
        #endregion

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnAgregarNumero_Click(object sender, EventArgs e)
        {
            AgregarNumero(Numeros[contador++] = Convert.ToInt32(tbNumero.Text));

            tbNumero.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double promedio=CalcularPromedio();

            lbPromedio.Text = $"{promedio:f2}";
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            int numeroBuscar= Convert.ToInt32(tbBusqueda.Text);
            int idx = -1;

            if (rbSecuencial.Checked == true)
            {
                idx = BusquedaSecuencial(numeroBuscar);
            }
            else if (rbBinaria.Checked == true)
            {
                Ordenar();
                idx = BusquedaBinaria(numeroBuscar);
            }
            
            string resultado = "Registro no encontrado";
            if (idx > -1)
            {
                resultado = $"Registro encontrado en posición {idx}";
            }
            MessageBox.Show(resultado,"Resultado de Búsqueda"); 
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lbxResultado.Items.Clear();

            Ordenar();

            for (int n = 0; n < contador; n++)
            {
                lbxResultado.Items.Add($"{Numeros[n]:000}");
            }
        }
    }
}
