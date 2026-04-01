using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_DatosPersonales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrewse su nombre: ");

            string nombre = Console.ReadLine();
            Console.Write("ingrewse su apellido: ");

            string apellido = Console.ReadLine();
            Console.Write("ingrese su edad: ");

            int edad = int.Parse(Console.ReadLine());
            Console.Write("ingrese su ciudad: ");

            string ciudad = Console.ReadLine();

            Console.Write("su nombre completo es " + nombre + " " + apellido + " su edada es " + edad + " y vive en " + ciudad);
            Console.ReadKey();

        }
    }
}
