using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6___MiPrimerMatriz
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

            int[,] matriz = new int[fila, columna];

            for (int i = 0; i < fila; i++)
            {
                for(int j = 0; j< columna; j++)
                {
                    Console.Write(matriz[i,j]);
                }
                Console.ReadKey();
            } 
        }
        
    }
}
