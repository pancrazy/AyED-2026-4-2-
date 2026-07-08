using System;
namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] mapa =
            {
                {"llanura", "llanura", "bosque", "agua" },
                { "bosque", "bosque", "agua", "agua" },
                {"bosuqe", "bosque", "bosque", "llanura" },
                {"agua", "llanura", "llanura", "desierto" },
                {"ciudad", "ciudad", "montañas", "montañas" }

        };
            Console.WriteLine("Mapa original: ");
            MostrarMapa(mapa);
            Console.WriteLine();

            mapa[1, 1] = "jugador";

            mapa[2, 2] = "lluvia";

            mapa[4, 1] = "guerra";

            mapa[3, 3] = "ruinas";

            Console.WriteLine("Mapa actualizado: ");
            MostrarMapa(mapa);
            Console.WriteLine();
        }
            static void MostrarMapa(string[,] matriz)
            {
                for (int i = 0; i< matriz.GetLength(0); i++)
            {

                    for (int j = 0; j < matriz.GetLength(1); j++)
                {

                        Console.Write(matriz[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            Console.ReadKey();            }
        
        }
    }

