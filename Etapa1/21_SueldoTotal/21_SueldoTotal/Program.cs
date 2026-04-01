using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_SueldoTotal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese el valor de sus horas trabajadas: ");

              int valor_hora = int.Parse(Console.ReadLine());
            Console.Write("ingrese sus horsa totales: ");

              int horas_totoales = int.Parse(Console.ReadLine());
              int sueldo_total = (horas_totoales * valor_hora);
           
            Console.WriteLine("su sueldo por horas es igual a: " + sueldo_total+ "$");
            Console.ReadKey();
        }
    }
}
