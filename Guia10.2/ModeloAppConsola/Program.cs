using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ModeloAppConsola
{
    internal class Program
    {
        #region variables y métodos del dominio
        static double[] recorridosEncs = new double[100];
        static int[] tipoVehiculoEncs = new int[100];
        static int[] zonas = new int[100];
        static int contador=0;
        
        public static void RegistrarEncuesta(int zona, int tipo, double distancia)
        {
            recorridosEncs[contador] = distancia;
            tipoVehiculoEncs[contador] = tipo;
            zonas[contador] = zona;
            contador++;
        }

        
        static int CalcularPoblacionSegun(int tipo, int zona)
        {
            int cantidad = 0;
            for (int n = 0; n < contador; n++)
            {
                if (zonas[n] == zona && tipoVehiculoEncs[n] == tipo)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }
        static int CalcularPoblacionZona(int zona)
        {
            int encuestados = CalcularPoblacionSegun(1, zona)+
                                    CalcularPoblacionSegun(2, zona) +
                                    CalcularPoblacionSegun(3, zona) +
                                    CalcularPoblacionSegun(4, zona);
            return encuestados;
            
        }

        static double CalcularPromedioDistanciaSegun(int tipo, int zona)
        {
            double promedio = 0;
            double distancia = 0;
            for (int n = 0; n < contador; n++)
            {
                if (zonas[n] == zona && tipoVehiculoEncs[n] == tipo)
                {
                    distancia+=recorridosEncs[n];
                }
            }
            int cantidad = CalcularPoblacionZona(zona);
            if(cantidad>0)
                promedio=distancia/cantidad;
            return promedio;

        }

        #endregion

        #region  metodos y variable de la vista
        static void MostrarFormularioEncuesta(int zona)
        {
            #region solicitar tipo de transporte (el primer encuestado)
            Console.WriteLine("Tipo de transporte a usar 1 bicicleta");
            Console.WriteLine("(1) bicicleta- (2) motocicletas - (3) automovil - (4) transporte público");
            int tipo = Convert.ToInt32(Console.ReadLine());
            #endregion

            #region solicitar km recorridos
            Console.WriteLine("Distancia recorrida en km?");
            double distancia = Convert.ToDouble(Console.ReadLine());

            RegistrarEncuesta(zona, tipo, distancia);

            #endregion
            Console.WriteLine("presione una tecla para volver al menu del encuestador");
            Console.ReadKey();
        }

        static void MostrarEstadisticaZona(int zona)
        {
            Console.WriteLine("\tInforme final por encuestador");

            #region mostrar resultados
            Console.WriteLine("\t Cantidad de encuestados: {0}", CalcularPoblacionZona(zona));
            Console.WriteLine("\t Promedio de distancias en bicicleta recorridas por usuario de la misma: {0:f2}", CalcularPromedioDistanciaSegun(1,zona));
            Console.WriteLine("\t Promedio de distancias en motocicletas recorridas por usuario de la misma: {0:f2}", CalcularPromedioDistanciaSegun(2, zona));
            #endregion

            Console.WriteLine("presione una tecla para volver al menu del encuestador");
            Console.ReadKey();
        }

        static void MostrarIngresoEncuestador()
        {
            Console.Clear();

            Console.WriteLine("Ingrese el número de zona a encuestar");
            int zona=Convert.ToInt32(Console.ReadLine());

            MostrarMenuEncuestador(zona);
        }

        static int MostrarMenuYSolicitudEncuestador()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t\tSistemas de encuestas sobre el uso de transportes\n\n");

            Console.WriteLine("\t\t1- Relevar encuestado");
            Console.WriteLine("\t\t2- Mostrar estatisticas de la zona");
            Console.WriteLine("\t\t3- Volver al menú principal\n\n");

            Console.Write("Elija una opción:");
            int op = Convert.ToInt32(Console.ReadLine());

            return op;
        }

        static void MostrarMenuEncuestador(int zona)
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t\tEncuesta en la zona: {0}\n\n\n", zona);


            int op = MostrarMenuYSolicitudEncuestador();
            while (op!=0)
            {
                switch (op)
                {
                    case 1:
                        {
                            MostrarFormularioEncuesta(zona);
                        }
                        break;
                    case 2:
                        {
                            MostrarEstadisticaZona(zona);
                        }
                        break;
                    default:
                        {
                            op = 0;
                        }break;
                }
                if(op!=0)
                    op = MostrarMenuYSolicitudEncuestador();
            }
        }
        static int MostrarMenuYSolicitud()
        {
            Console.Clear();
            Console.WriteLine(" \t\t\t\tSistemas de encuestas sobre el uso de transportes\n\n");

            Console.WriteLine("\t\t1- Entrar al sistema de encuestas");
            Console.WriteLine("\t\t2- Mostrar estatisticas");
            Console.WriteLine("\t\totro- Salir\n\n\n");

            Console.Write("Elija una opción: ");
            int op = Convert.ToInt32(Console.ReadLine());

            return op;
        }
        #endregion

        static void Main(string[] args)
        {
            int op = MostrarMenuYSolicitud();
            while (op != 0)
            {
                switch (op)
                {
                    case 1: 
                        {
                            MostrarIngresoEncuestador();
                        } break;
                    case 2: 
                        { 
                        } break;
                }
                op = MostrarMenuYSolicitud();
            }
        }
    }
}
