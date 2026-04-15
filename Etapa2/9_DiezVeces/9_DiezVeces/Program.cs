using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_DiezVeces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("decime tu nombre");
            string nombre = Console.ReadLine();
            int contador_nombre = 0;
            while (contador_nombre < 10)
            {
                Console.Write(" " + nombre);
                contador_nombre += 1; 
                    
                    }

            Console.ReadKey();
        }
    }
}
