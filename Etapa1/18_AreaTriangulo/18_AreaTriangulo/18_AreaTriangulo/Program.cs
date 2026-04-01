using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la altura de su triangulo: ");
            double altura_triangulo = double.Parse(Console.ReadLine());

            Console.Write("Ingrese al base de su triangulo: ");
            double base_triangulo = double.Parse(Console.ReadLine());

            double area_triangulo = (base_triangulo * altura_triangulo) / 2; 

            Console.Write("el area del triangulo es igual a " + area_triangulo);
            Console.ReadKey();
        }
    }
}
