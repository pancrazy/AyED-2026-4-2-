using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_MiPrimerMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("en caso de un robo que opciones elegirias");
            Console.WriteLine(" ");
            Console.WriteLine("opcion 1: correr");
            Console.WriteLine("opcion 2: darle todo");
            Console.WriteLine("opcion 3: cagarlo a trompadas");
            Console.Write("opcion ... ");
            bool salir_programa = true;

            while (salir_programa == true )
            {
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("muy bien maestro pero si el pibe tiene una arma medio que cagaste");
                        break;
                    case 2:
                        Console.WriteLine("muy bien maestro la verdad tenes muchas chance para sobrevivir");
                        salir_programa = false
                            ;
                        break;
                    case 3:
                        Console.WriteLine("diablo puñeta te deseo suerte");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                       
                }
                
            }
            Console.ReadKey();





        }
      
    }

    
}
