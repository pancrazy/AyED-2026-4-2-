using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_MiPromedio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese su numero: ");

              float numero1 = float.Parse(Console.ReadLine());

            Console.Write("Ingrese otro numero: ");

              float numero2 = float.Parse(Console.ReadLine());

            Console.Write("Ingrese otro numero: ");

              float numero3 = float.Parse(Console.ReadLine());
            
              float promedio = (numero1 + numero2 + numero3) / 3; 

            Console.WriteLine("tu promedio es igual a:  " + promedio);
            Console.ReadKey();
        }
    }
}
