using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8___SumandoMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DECIME LA CANTIDAD DE FILAS DE TU MATRIZ: ");
            int fila = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("DECIME LA CANTIDAD DE COLUMNAS DE TU MATRIZ: ");
            int columna = int.Parse(Console.ReadLine());

            int[,] matriz_1 = new int[fila, columna];
            int[,] matriz_2 = new int[fila, columna];
            int[,] matriz_3 = new int[fila, columna];

            Random rnd = new Random();

            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    matriz_1[i, j] = rnd.Next(1, 11); 
                    matriz_2[i, j] = rnd.Next(1, 11);

                    matriz_3[i, j] = matriz_1[i, j] + matriz_2[i, j];
                }
            }

            Console.Clear();

            Console.WriteLine(" ");
            Console.WriteLine("MATRIZ 1:");
            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    Console.Write(matriz_1[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(" ");
            Console.WriteLine("MATRIZ 2:");
            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    Console.Write(matriz_2[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(" ");
            Console.WriteLine("MATRIZ RESULANTE:");
            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    Console.Write(matriz_3[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();  


        }

    }
}
