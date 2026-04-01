using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_CuadradoCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su numero entero: ");

            double numero_entero = double.Parse(Console.ReadLine());

            double numero_cuadrado = Math.Pow(numero_entero, 2);
            double numero_cubo = Math.Pow(numero_entero, 3);

            Console.WriteLine("el " + numero_entero + " al cuadrado es igual a " + numero_cuadrado + " y al cubo " + numero_cubo);
            Console.ReadKey();
        }
    }

}
