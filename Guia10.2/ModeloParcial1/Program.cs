using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial1
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            #region declaraciones
            double distanciaB, distanciaM, distanciaA, distanciaTp;
            int bicicletas, motocicletas, automoviles, transportes;
            int encuestados;
            double promedioBici, promedioMoto;

            double distanciabT = 0;
            int bicicletasT = 0;
            double distanciamT = 0;
            int motocicletasT = 0;
            double distanciaaT = 0;
            int automovilesT = 0;
            double distanciatpT = 0;
            int transportesT = 0;

            int poblacion;

            double porcentajeB=0;
            double porcentajeM = 0;
            double porcentajeA = 0;
            double porcentajeTp = 0;
            #endregion


            int encs;
            Console.WriteLine("Inicio del proceso de encuestado");

            #region solicitud de la cantidad de encuestadores
            Console.WriteLine("ingrese la cantidad de encuestadores ");
            encs=Convert.ToInt32(Console.ReadLine());
            #endregion

            for (int n = 1; n <= encs; n++)
            {
                Console.WriteLine("Inicio de encuestas en zona {0}", n);

                distanciaB = 0;
                bicicletas=0;
                distanciaM = 0;
                motocicletas = 0;
                distanciaA = 0;
                automoviles = 0;
                distanciaTp = 0;
                transportes = 0;

                #region solicitar tipo de transporte (el primer encuestado)
                Console.WriteLine("Tipo de transporte a usar 1 bicicleta");
                Console.WriteLine("(1) bicicleta- (2) motocicletas - (3) automovil - (4) transporte público - (otro) termina carga" );
                int tipo=Convert.ToInt32(Console.ReadLine());
                #endregion

                while (tipo > 0)
                {
                    #region solicitar km recorridos
                    Console.WriteLine("Distancia recorrida en km?");
                    double distancia=Convert.ToDouble(Console.ReadLine());
                    #endregion

                    #region verificar tipo de vehículo
                    switch (tipo)
                    {
                        case 1: 
                            {
                                distanciaB += distancia;
                                bicicletas++;
                            }
                            break;
                        case 2:
                            {
                                distanciaM += distancia;
                                motocicletas++;
                            }
                            break;
                        case 3:
                            {
                                distanciaA += distancia;
                                automoviles++;
                            }
                            break;
                        case 4:
                            {
                                distanciaTp += distancia;
                                transportes++;
                            }
                            break;
                    }
                    #endregion

                    #region solicitar tipo de vehículo (siguiente)
                    Console.WriteLine("Tipo de transporte a usar 1 bicicleta");
                    Console.WriteLine("(1) bicicleta- (2) motocicletas - (3) automovil - (4) transporte público - (otro) termina carga");
                    tipo = Convert.ToInt32(Console.ReadLine());
                    #endregion
                }

                Console.WriteLine("\tInforme final por encuestador");

                #region calcular cantidades de personas
                encuestados = bicicletas + motocicletas + transportes;
                #endregion

                #region calcular promedio bidi y moto
                promedioBici = 0;
                if (bicicletas>0)
                    promedioBici = distanciaB / bicicletas;

                promedioMoto = 0;
                if (motocicletas > 0)
                    promedioMoto = distanciaM / motocicletas;
                #endregion
                                
                #region mostrar resultados
                Console.WriteLine("\t Cantidad de encuestados: {0}", encuestados);
                Console.WriteLine("\t Promedio de distancias en bicicleta recorridas por usuario de la misma: {0:f2}", promedioBici);
                Console.WriteLine("\t Promedio de distancias en motocicletas recorridas por usuario de la misma: {0:f2}", promedioMoto);
                #endregion

                #region salvar cantidades y distancias
                distanciabT += distanciaB;
                bicicletasT += bicicletas;
                distanciamT += distanciaM;
                motocicletasT += motocicletas;
                distanciaaT += distanciaA;
                automovilesT += automoviles;
                distanciatpT += distanciaTp;
                transportesT += transportes;
                #endregion
            }

            Console.WriteLine("Informe final de la encuesta");

            #region calcular cantidad de encuestados
            poblacion = bicicletasT + motocicletasT + automovilesT + transportesT;
            #endregion

            #region calcular porcentajes
            if (poblacion > 0)
            {
                porcentajeB = 1d * bicicletasT / poblacion * 100;
                porcentajeM = 1d * bicicletasT / poblacion * 100;
                porcentajeA = 1d * bicicletasT / poblacion * 100;
                porcentajeTp = 1d * bicicletasT / poblacion * 100;
            }
            #endregion

            #region mostrar cantidad de encuestados y porcentajes
            Console.WriteLine("Cantidad de encuestados: {0}", poblacion);
            Console.WriteLine("Porcentaje de uso de bicicletas: {0:f2}", porcentajeB);
            Console.WriteLine("Porcentaje de uso de motocicletas: {0:f2}", porcentajeM);
            Console.WriteLine("Porcentaje de uso de automoviles: {0:f2}", porcentajeA);
            Console.WriteLine("Porcentaje de uso de transportes publico: {0:f2}", porcentajeTp);
            #endregion

            Console.ReadKey();
        }
    }
}
