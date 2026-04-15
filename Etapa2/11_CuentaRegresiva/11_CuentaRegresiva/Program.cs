using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CuentaRegresiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dame un numero");
            int numero = int.Parse(Console.ReadLine());
         
            while (numero != -1)
            {
                Console.Write(" " + numero);
                numero -= 1;


            }
            Console.ReadKey();
        }
    }
    
}
