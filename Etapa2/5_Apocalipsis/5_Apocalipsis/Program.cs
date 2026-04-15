using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Apocalipsis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("usted tiene un arma?: ");
            bool arma = Console.ReadLine().ToLower() == "si";

            Console.Write("usted tiene un refugio?: ");
            bool refugio = Console.ReadLine().ToLower() == "si";

            Console.Write("usted tiene comida?: ");
            bool comida = Console.ReadLine().ToLower() == "si";

            if (comida && arma)
            { Console.Write("sobrevive"); }

            else
            { Console.Write("no sobrevivis papi") }


            Console.ReadKey();
        }
    }
}
