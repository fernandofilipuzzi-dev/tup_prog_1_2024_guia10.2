using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_ConClaseControladora_Modal.Models
{
    public class Controlador
    {
        

        #region datos de alumnos
        public int[] LUs = new int[100];
        public string[] Nombres = new string[100];
        public double[] Notas = new double[100];
        public int Contador = 0;
        #endregion

        #region datos MAP: Mayores Al Promedio 
        public int[] LUsMAP = new int[100];
        public string[] NombresMAP = new string[100];
        public double[] NotasMAP = new double[100];
        public int ContadorMAP = 0;
        #endregion

        public void RegistrarAlumno(int lu, string nombre, double nota)
        {
            LUs[Contador] = lu;
            Nombres[Contador] = nombre;
            Notas[Contador] = nota;
            Contador++;
        }

        public double CalcularPromedio()
        {
            double promedio = 0;
            for (int n = 0; n < Contador; n++)
            {
                promedio += Notas[n];
            }
            if (Contador > 0)
                promedio /= Contador;
            return promedio;
        }

        public void DeterminarAlumnosMayoresAlPromedio()
        {
            double promedioGeneral = CalcularPromedio();
            for (int n = 0; n < Contador; n++)
            {
                if (Notas[n] >= promedioGeneral)
                {
                    AgregarAlumnoMayorAlPromedio(n);
                }
            }
        }

        public void AgregarAlumnoMayorAlPromedio(int idx)
        {
            LUsMAP[idx] = LUs[idx];
            NombresMAP[idx] = Nombres[idx];
            NotasMAP[idx] = Notas[idx];

            ContadorMAP++;
        }

        public void OrdenarListadoPorLU(int[] lus, string[] nombres, double[] notas, int contador)
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

        public int BusquedaSecuencial(int numeroBuscar)
        {
            int idx = -1;
            int n = 0;
            while (n < Contador && idx == -1)
            {
                if (LUs[n] == numeroBuscar)
                {
                    idx = n;
                }
                n++;
            }
            return idx;
        }

        public int BusquedaBinaria(int numeroBuscar)
        {
            int idx = -1;
            int inf = 0;
            int sup = Contador;

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
    }
}
