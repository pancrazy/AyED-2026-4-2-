using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("BUEN DIA , COMOS ESTAS ?");
            Console.WriteLine("como es tu nombre  ");
            string nombre = Console.ReadLine();
            Console.WriteLine("como es tu segundo nombre  ");
            string nombre2 = Console.ReadLine();
            Console.WriteLine("como es tu apellido ");
            string apellido = Console.ReadLine();
            Console.WriteLine(" ESCRIBA SU DNI ");
            int dni = int.Parse(Console.ReadLine());
            Console.WriteLine("cual es tu edad ");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("su nombre es "+ nombre + " su segundo nombre es " + nombre2 + " su apellido es "+ apellido + " su DNI es " + dni + " y su edad es "+ edad);
            Console.ReadKey();
        }
    }
}
