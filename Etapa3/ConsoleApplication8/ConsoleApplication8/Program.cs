using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
               string[] apellidos = new string[10];

                for (int i = 0; i < apellidos.Length; i++)
                {
                    Console.Write("ingrese un apellido: ");
                    apellidos[i] = Console.ReadLine();
                }

              
                Array.Sort(apellidos);

                Console.WriteLine("Apellidos ordenados:");
                foreach (string apellido in apellidos)
                {
                    Console.WriteLine(apellido + " ");
                }

                string opcion;
                int posicion;

                do
                {
                    Console.WriteLine("  Ingrese un apellido para buscar: ");
                    string buscado = Console.ReadLine();

                    bool encontrado = false;

                    for (int i = 0; i < apellidos.Length; i++)
                    {
                        if (apellidos[i].Equals(buscado))
                        {
                            encontrado = true;
                            break;
                        }
                    }
                if (encontrado)
                {
                    Console.WriteLine("El apellido está en la lista " + buscado);
                    break;
                }
                else
                {
                    Console.WriteLine("El apellido " + buscado + " NO está en la lista.");
                    Console.Write("¿Desea ingresar otro apellido? (S/N): ");
                    opcion = Console.ReadLine().ToUpper();
                }

            } while (opcion == "S");
            {
                Console.WriteLine("Programa finalizado.");
            }
            Console.ReadKey();
        }
      }
   }
    
