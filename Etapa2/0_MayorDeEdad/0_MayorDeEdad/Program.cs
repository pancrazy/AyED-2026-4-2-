using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_MayorDeEdad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("decime tu edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.Write("sos mayor de edad");
            }
            else 
            { Console.Write("NO sos mayor de edad"); }


            Console.ReadKey();
        }
    }
}
