using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_CelciusFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su temperatura en celcius: ");

               double celcius = double.Parse(Console.ReadLine());
               double farenheit = celcius * 1.8 + 32;
               double celvin = celcius * 273.15;

            Console.Write( "sus " + celcius + " grados celcius a farenheit son  " + farenheit + " y a kelvin son " + kelvin);
            Console.ReadKey();
        } 
    }
}
