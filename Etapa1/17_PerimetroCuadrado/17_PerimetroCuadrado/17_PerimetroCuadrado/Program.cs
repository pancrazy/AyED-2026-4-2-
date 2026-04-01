using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_PerimetroCuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el lado de su cuadrado: ");

            double lado_cuadrado = double.Parse(Console.ReadLine());
            
            double perimetro = 4 * lado_cuadrado;
            double superficie = lado_cuadrado * lado_cuadrado;
        
            Console.Write("El peremitro es " + perimetro + "  el area es " + superficie);
            Console.ReadKey();
        }
    }
}
