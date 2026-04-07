using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ParOlmpar
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Console.Write("Ingrese su numero: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
            { Console.Write("el numero es par"); }
            else
            { Console.Write("el numero es impar"); }
            Console.ReadKey();
        }
    }
}
