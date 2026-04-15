using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_TipoTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("dame un el lado 1 : ");
            int lado_1 = int.Parse(Console.ReadLine());
            
            Console.Write("dame un el lado 2 : ");
            int lado_2 = int.Parse(Console.ReadLine());

            Console.Write("dame un el lado 3 : ");
            int lado_3 = int.Parse(Console.ReadLine());

            if (lado_1 == lado_2 && lado_2 == lado_3 && lado_3 == lado_1)
                { Console.Write("tenes un triangulo equilatero"); }
                 if (lado_1 == lado_2 && lado_1 != lado_3  )
                    { Console.Write("tenes un triangulo isosceles"); }       
                   if (lado_1 != lado_2 && lado_1 != lado_3 )
                       { Console.Write("tenes un tringulo escaleno "); }    
                       


                  


            Console.ReadKey(); 
          
        }
    }
}
