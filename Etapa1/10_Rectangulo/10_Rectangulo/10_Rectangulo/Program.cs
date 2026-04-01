using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Rectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la altura de su rectangulo (X):");
               double altura_rectangulo = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la altura de su ancho (Y):");

            double ancho_rectangulo = double.Parse(Console.ReadLine());

            double perimetro = 2 * altura_rectangulo + 2 * ancho_rectangulo;
            double area = ancho_rectangulo * altura_rectangulo;
            double diagonal = Math.Sqrt(Math.Pow(altura_rectangulo, 2) + Math.Pow(ancho_rectangulo, 2));

            Console.Write("El peremitro es " + perimetro + "  el area es " + area + " la diagonal es " + diagonal);
            Console.ReadKey();
        }
    }
    }
