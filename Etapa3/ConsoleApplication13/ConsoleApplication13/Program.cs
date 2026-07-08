using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese la cantidad de filas: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Ingrese la cantidad de columnas: ");
        int m = int.Parse(Console.ReadLine());

        int[,] matriz = new int[n, m];

        Console.WriteLine("Ingrese los elementos de la matriz:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("Elemento [" + i + "," + j + "]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("matriz normal:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("valor maximo de cada columna:");

        for (int j = 0; j < m; j++)
        {
            int minimo = matriz[0, j];
            int posicion = matriz[0, 0];
            for (int i = 1; i < n; i++)
            {
                if (matriz[i, j] <minimo)
                {
                    minimo = matriz[i, j];
                    posicion = matriz[i, j];
                }
            }

            Console.WriteLine("columna " + j + ": " + minimo);
        }

        Console.ReadKey();
    }
}