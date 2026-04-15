using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Cumplidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("decime tu edad");
            int edad = int.Parse(Console.ReadLine());
            int contador_edad = 0;
            while (edad >= contador_edad)
            {
                Console.Write(" " + contador_edad);
                contador_edad += 1;


            }
            Console.ReadKey();
        }

    }
}
