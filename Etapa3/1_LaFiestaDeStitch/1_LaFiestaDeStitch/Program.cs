using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LaFiestaDeStitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int promedio = 0;

            Console.WriteLine("¿Cantidad de invitados?:");
            int invitados = int.Parse(Console.ReadLine());
            int[] vector = new int[invitados];

            Console.WriteLine("Atencion la comida se debe encontrar entre 0 y 100");

            for (int contador = 0; contador < vector.Length; contador++)
            {
                Console.Write("comida para invitado entre  " + (contador + 1) + ": ");
                vector[contador] = int.Parse(Console.ReadLine());
                if (vector[contador] > 100)
                {   Console.Clear();
                    Console.WriteLine("Error , reinicie el programa.");
                }
         
            }

            for (int contador = 0; contador < vector.Length; contador++)
            {
                total = total + vector[contador];

            }

            promedio = total / vector.Length;

            for (int contador = 0; contador < vector.Length; contador++)
            {
                Console.WriteLine("comida para el invitado " + (contador + 1) + ": " + promedio)    ;
                
               
            }



            Console.ReadKey();
        }
    }
}