using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_PixelDreams
{
    class Program
    {
        static void Main(string[] args)

        {


            Console.WriteLine("¿cantidad de usuarios?:");
            int usuarios = int.Parse(Console.ReadLine());
            int[] lista_puntos = new int[usuarios];

         
      

            for (int contador = 0; contador < lista_puntos.Length; contador++)
            {
                Console.Write("puntaje por usuario " + (contador + 1) + ": ");
                lista_puntos[contador] = int.Parse(Console.ReadLine());
            }

            Console.Clear();
            Array.Sort(lista_puntos);


            Console.WriteLine("Los puntajse por usuario ordenado de mayor a menor son; ");
            Console.WriteLine(string.Join(", ", lista_puntos));


            Console.ReadKey();

        }
    }
}
