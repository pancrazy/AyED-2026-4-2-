using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CentroPM
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vida = new int[6];
            int contador = 0;

            Random azar = new Random();
            bool juego_activo = true;
            while (juego_activo)
            {
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("1.Registrar un nuevo pokémon");
                Console.WriteLine("2.Mostrar la vida de todos los pokemones");
                Console.WriteLine("3.Curar un pokémon");
                Console.WriteLine("4.Dañar un pokémon");
                Console.WriteLine("5.Curar a todos los pokemones");
                Console.WriteLine("6.Mostrar pokemones debilitados");
                Console.WriteLine("7.Mostrar el pokémon con mayor vida");
                Console.WriteLine("8.Mostrar el pokémon con menor vida");
                Console.WriteLine("9.Calcular promedio de vida del equipo");
                Console.WriteLine("10.Ordenar pokemones por vida de menor a mayor");
                Console.WriteLine("11.Ordenar pokemones por vida de mayor a menor");
                Console.WriteLine("12.Simular ataque enemigo a todo el equipo");
                Console.WriteLine("13.Salir");
                Console.WriteLine(" ");
                int opcion = int.Parse(Console.ReadLine());



                switch (opcion)
                {

                    case 1:
                        Console.Clear();
                        if (contador < 6)
                        {
                            Console.WriteLine("Ingrese vida del pokemon (1-100):");
                            int salud = int.Parse(Console.ReadLine());

                            if (salud >= 1 && salud <= 100)
                            {
                                vida[contador] = salud;
                                contador++;

                                Console.WriteLine("Pokemon cargado correctamente");
                            }
                            else
                            {
                                Console.WriteLine("Vida invalida");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ya cargaste los 6 pokemones");
                        }

                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Tu equipo");
                        Console.WriteLine(" ");
                        for (int i = 0; i < vida.Length; i++)
                        {
                            Console.WriteLine($" POKEMON {i}: {vida[i]}");

                        }

                        break;

                    case 3:
                        Console.Clear();
                        Console.Write($" -Elegi el pokemon: ");

                        int pokemon_elegido1 = int.Parse(Console.ReadLine());
                        Console.Clear();

                        Console.Write($" -Cuanta vida queres agregarle :");
                        int vida_elegida1 = int.Parse(Console.ReadLine());

                        vida[pokemon_elegido1] += vida_elegida1;


                        if (vida[pokemon_elegido1] > 100)

                        { vida[pokemon_elegido1] = 100; }

                        Console.Clear();
                        Console.WriteLine($"La vida de tu pokemon {pokemon_elegido1} es {vida[pokemon_elegido1]}.");



                        break;

                    case 4:

                        Console.Clear();
                        Console.Write($" -Elegi el pokemon: ");

                        int pokemon_elegido2 = int.Parse(Console.ReadLine());
                        Console.Clear();

                        Console.Write($" -Cuanta vida queres sacarle :");
                        int vida_elegida2 = int.Parse(Console.ReadLine());

                        vida[pokemon_elegido2] -= vida_elegida2;


                        if (vida[pokemon_elegido2] < 0)

                        { vida[pokemon_elegido2] = 0; }


                        Console.Clear();
                        Console.WriteLine($"La vida de tu pokemon {pokemon_elegido2} es {vida[pokemon_elegido2]}.");
                        Console.WriteLine("");
                        break;

                    case 5:
                        Console.Clear();
                        Console.Write(" -Cuanta es la vida que queres dar?  ");
                        int pokemon_VidaDada = int.Parse(Console.ReadLine());

                        for (int i = 0; i < vida.Length; i++)
                        {
                            vida[i] += pokemon_VidaDada;

                            if (vida[i] > 100)
                            {
                                vida[i] = 100;
                            }
                        }
                        break;

                    case 6:
                        Console.Clear();

                        for (int i = 0; i < vida.Length; i++)
                        {
                            if (vida[i] == 0)
                            {
                                Console.WriteLine($"La posición {i} tiene valor 0");
                            }
                        }

                        break;

                    case 7:
                        Console.Clear();
                        Array.Sort(vida);
                        Array.Reverse(vida);
                        Console.Write($"{vida[0]}");
                        break;

                    case 8:
                        Console.Clear();
                        Array.Sort(vida);
                        Console.Write($"{vida[0]}");
                        break;

                    case 9:
                        Console.Clear();

                        int suma = 0;

                        for (int i = 0; i < vida.Length; i++)
                        {
                            suma += vida[i];
                        }
                        double promedio = (double)suma / vida.Length;
                        Console.Write(promedio);
                   
                        break;

                    case 10:
                        Console.Clear();
                        for (int i = 0; i < vida.Length; i++)
                        {
                            Console.Write("");
                            Console.Write($"  { vida[i]}");
                        }
                        break;

                    case 11:
                        Console.Clear();
                        Array.Sort(vida);

                        Console.WriteLine(string.Join(", ", vida));
                        break;

                    case 12:
                        Console.Clear();
                        Array.Sort(vida);
                        Array.Reverse(vida);
                        Console.WriteLine(string.Join(", ", vida));

                        break;

                    case 13:
                        juego_activo = false;
                        break;

                    default:
                        break;

                }
            }
           


            }


        }
   }


