using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0__CargandoEdades
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] edades = new int[5];


            for (int i = 0; i < edades.Length; i++)
            {
                Console.Write("Ingrese la edad del estudiante " + (i + 1) + ": ");
                edades[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Edades cargadas:");

                for (int i = 0; i < edades.Length; i++)
                {
                    Console.WriteLine("Edad " + (i + 1) + ": " + edades[i]);
                }

                Console.ReadKey();

            }


        }

    }
}
