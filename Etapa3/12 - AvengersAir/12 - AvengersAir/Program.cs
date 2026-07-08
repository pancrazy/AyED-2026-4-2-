using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___AvengersAir
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int fila = 81;
            int columna = 6;
            int asientos_disponibles = 80;
            int asientos_ocupados = 0;
            int totalNumeros = 80;
            int columnas = 5;
            int numero_asiento = 0;

            Random random = new Random();
            bool menu_activo = true;
            string[,] pasajeros = new string[fila, columna];
            while (menu_activo == true)
            {
                Console.Clear();
                Console.WriteLine(" \n\n  ==== MENU AIRLINES 67 ====");
                


                Console.WriteLine($"\n Asientos Disponibles: {asientos_disponibles} ");
                Console.WriteLine($" Asientos Ocupados: {asientos_ocupados}");


                Console.Write("\n 1 - Comprar asientos");
                Console.Write("\n\n 2 - Vender asientos");
                Console.Write("\n\n 3 - salir");
                Console.Write("\n\n ");
    
                int opcion = int.Parse(Console.ReadLine());


                switch (opcion)
                {

                    case 1:

                        Console.Clear();
                        Console.WriteLine("\nLos asientos del 1 al 40 pertenen a la clase economica");
                        Console.WriteLine("41 al 70 son clase estandar y del 71 al 80 clase premium ");
                        Console.WriteLine("");

                        //puedo mostar la matriz y asi tambien puedo sacar los asientos ocupados no mala.
                        for (int i = 1; i <= totalNumeros; i++)
                        {

                            // 1. Validar si es salida de emergencia (del 40 al 43)
                            if (i >= 40 && i <= 43)
                            {

                                Console.Write($"[S.E. {i:D2} \t"); // S.E. = Salida de Emergencia

                            }
                            else
                            {
                                // 2. Número normal (el :D2 hace que se vea 01, 02, etc.)
                                Console.Write($"Asiento {i:D2} \t");
                            }

                            // 3. Salto de línea automático cada 5 columnas
                            if (i % columnas == 0)
                            {
                                Console.WriteLine();
                            }

                        }
                        Console.Write("\nElija el asiento que desea reservar: ");
                        numero_asiento = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (numero_asiento == 40 || numero_asiento == 41 || numero_asiento == 42 || numero_asiento == 43)
                        { 
                            Console.WriteLine("\nHa elegido la clase S.E el monto es igual a $74,99.");
                        }
                        else if (numero_asiento >= 1 && numero_asiento <= 40)
                        {
                            Console.WriteLine("\nHa elegido la clase económica el monto es igual a $80.");
                        }


                        else if (numero_asiento >= 41 && numero_asiento <= 70)
                        {
                            Console.WriteLine("\nHa elegido la clase estándar el monto es igual a $100.");
                        }
                        else if (numero_asiento >= 71 && numero_asiento <= 80)
                        {
                            Console.WriteLine("\nHa elegido la clase premium el monto es igual a $200.");
                        }
                        else
                        {
                            Console.WriteLine("\nEl número de asiento ingresado no es válido.");
                            Console.WriteLine("\nPresione una tecla para volver al menú...");
                            Console.ReadKey();
                            break;
                        }

                        // Solo se ejecuta si el asiento es válido
                        asientos_disponibles--;
                        asientos_ocupados++;

                        Console.WriteLine("\nAsiento reservado correctamente.");
                        Console.WriteLine("Presione una tecla para volver al MENU");
                        Console.ReadKey();

                        break;
                    case 2:





                        break;


                }





            }
            Console.ReadKey();
        }
    }
}
