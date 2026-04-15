using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_BecasJuanPedro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su edad ");
            int edad_usuario = int.Parse(Console.ReadLine());

            Console.Write("Ingrese sus ingresos mensuales: ");
            int ingresos_mensual = int.Parse(Console.ReadLine());


            if (edad_usuario > 19 && ingresos_mensual <= 100000 || edad_usuario < 19 && ingresos_mensual == 0 || edad_usuario == 19 && ingresos_mensual <= 50000  )
            { Console.Write("completado con exito"); }
            else
            { Console.Write("no cumple los requisitos"); }


            Console.ReadKey();
        }
    }
}
