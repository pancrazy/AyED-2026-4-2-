using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_ConversorMetrosCentimetros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una medida en metros: ");

            double metros = double.Parse(Console.ReadLine());

            double metros_a_centimetros = metros * 100;
            double metros_a_milimetros = metros * 1000;

            Console.Write("los metros a cm son "+ metros_a_centimetros + " y a milimetros son " + metros_a_milimetros);
            Console.ReadKey(); 
        }
    }
}
