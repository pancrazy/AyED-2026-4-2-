using System;
namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int aux;
            int buscador;
            int contador = 0;
            string opcion;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Ingrese el número: ");
                numeros[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (numeros[i] > numeros[j])
                    {
                        aux = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = aux;
                    }
                }
            }

            Console.WriteLine("Números ordenados:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(numeros[i] + " ");
            }
            do
            {
                contador = 0;

                Console.WriteLine("Ingrese el número a buscar:");
                buscador = int.Parse(Console.ReadLine());

                for (int i = 0; i < numeros.Length; i++)
                {
                    if (numeros[i] == buscador)
                    {
                        Console.WriteLine("Número encontrado en la posición: " + i);
                        contador++;
                    }
                }

                if (contador == 0)
                {
                    Console.WriteLine("Número no encontrado.");
                }

                Console.WriteLine("¿Desea buscar otro número?");
                opcion = Console.ReadLine();

            } while (opcion == "S");

            Console.ReadKey();
        }

    }
  }

