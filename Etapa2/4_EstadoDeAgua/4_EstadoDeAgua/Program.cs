using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_EstadoDeAgua
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Console.Write("Ingrese sus grados celcius: ");
            double grados_celsius = double.Parse(Console.ReadLine());
           
        
            if (grados_celsius <= 0)
            { Console.Write("el agua se congela"); }
            if (grados_celsius >= 100)
            { Console.Write("el agua hierve"); }
            if (grados_celsius >= 1 && grados_celsius <= 99)
            { Console.Write("esta en estado liquido aaaaa");}


                Console.ReadKey();
            




            Console.ReadKey();
        }
    }
}
