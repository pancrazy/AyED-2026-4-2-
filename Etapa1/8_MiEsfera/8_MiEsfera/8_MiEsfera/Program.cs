using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_MiEsfera
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su radio: ");

              double radio = double.Parse(Console.ReadLine());
              double pi = 3.14;
              double volumen = 4 / 3 * pi * radio * radio * radio;
              double superficie = 4 * pi * radio * radio;

            Console.WriteLine("su volumen es igual a: " + volumen + " y tu superficie es igual a: " + superficie);
            Console.ReadKey();
        }
    }
}
