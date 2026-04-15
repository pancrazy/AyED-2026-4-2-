using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_AnioBisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("decime tu año bebe y yo te respondo si es bisieste o no  ");
            double año = double.Parse(Console.ReadLine());


            if ((año % 4 == 0 &&  año % 100 != 0 ) || (año % 400 == 0))
            { Console.Write("exactemente el año" + " " +  año + " es bisiesto"); }
            else
            { Console.Write("no es bisiesto"); }




            Console.ReadKey();
        }
    }
}
