using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_MinutosAHoras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una medida en metros: ");

            int minutos = int.Parse(Console.ReadLine());

            int horas = minutos / 60;
            int minutos_sobrantes = minutos % 60;

            Console.Write(horas + " " + minutos_sobrantes);
            Console.ReadKey();
        }
    }
}
