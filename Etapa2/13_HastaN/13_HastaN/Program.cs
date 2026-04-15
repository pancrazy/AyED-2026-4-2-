using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_HastaN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("decime tu numero maximo y yo te doy todos los pares");
            int numero = int.Parse(Console.ReadLine());
            int contador_numero = 0;
            while (contador_numero <= numero)
            {

                if (contador_numero % 2 == 0)
                {
                    Console.Write(" " + contador_numero);

                }

                contador_numero = contador_numero + 1;
// esto me ayuda a resolver el trabajo numero 12
            }
            Console.ReadKey();
        }
    }
}
