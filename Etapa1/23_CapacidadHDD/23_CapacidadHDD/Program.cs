using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_CapacidadHDD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese la cantidad de cilindros:  ");
            double cantidad_cilindros = double.Parse(Console.ReadLine());
            Console.Write("ingrese la cantidad de pistas: ");
            double cantidad_de_pistas_cilindro = double.Parse(Console.ReadLine());
            Console.Write("ingrese la cantidad de sectores ");
            double cantidad_de_sectores = double.Parse(Console.ReadLine());
            double bytes = 512;
            double KB = bytes / 1024;
            double MB = KB / 1024;
            double GB = MB / 1024;

            
            double capacidad_hdd = cantidad_cilindros * cantidad_de_pistas_cilindro * bytes * cantidad_de_sectores; 
             


            

           


            Console.Write("la capacidad total de tu disco es = " + capacidad_hdd );
            Console.Write("la capacidad en MB" + MB);
            Console.Write("la capacidad en gb" + GB);
            Console.Write("la capacidad en kb" + KB);
            Console.ReadKey();
        }
    }
    

