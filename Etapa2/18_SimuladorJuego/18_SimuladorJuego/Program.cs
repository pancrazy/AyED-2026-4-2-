using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_SimuladorJuego
{
    class Program
    {
        static void Main(string[] args)
        {
            int vida = 10;
            int hambre = 10;
            int dia = 0;
            int comida_cruda = 0;
            int comida_cocida = 0;
            bool refugio = false;
            bool fogata = false;
            
                Random azar = new Random();
            bool juego_activo = true;
                while (juego_activo)
                {
                    // si vos queres poner la varible dentro del write tenes que usar el simbolo
                    // console.writeline($" {variable}");
                    Console.WriteLine(" ");
                    Console.WriteLine($"Día {dia} | Vida: {vida} | Hambre: {hambre}");
                    Console.WriteLine(" ");
                    Console.WriteLine($"Cruda: {comida_cruda} | Cocida: {comida_cocida}");
                    Console.WriteLine($"Refugio: {refugio} | Fogata: {fogata}");
                    Console.WriteLine(" ");
                    Console.WriteLine("1.Buscar comida");
                    Console.WriteLine("2.Explorar");
                    Console.WriteLine("3.Construir refugio");
                    Console.WriteLine("4.Encender fogata");
                    Console.WriteLine("5.Cocinar");
                    Console.WriteLine("6.Comer");
                    Console.WriteLine("7.Descansar");
                    Console.WriteLine("8.Salir");
                    Console.WriteLine(" ");
                    int opcion = int.Parse(Console.ReadLine());
                    bool accion_valida = false;

                    switch (opcion)
                    {
                        case 1:
                            int random_encontrar = azar.Next(1, 101);
                            if (random_encontrar <= 60)
                            {
                                comida_cruda += 2;
                                Console.Clear();
                                Console.WriteLine("-----------------------------------------------------------");
                                Console.WriteLine("Despues de una larga tarde mastaste a un par de conejos ");
                                Console.WriteLine("-----------------------------------------------------------");
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("-----------------------------------------------------------");
                                Console.WriteLine("Una tarde completamente desperdiciada.....");
                                Console.WriteLine("-----------------------------------------------------------");
                            }

                            accion_valida = true;

                            break;

                        case 2:

                            int random_explorar = azar.Next(1, 101);
                            if (random_explorar <= 50)
                            {
                                Console.Clear();
                                Console.WriteLine("-----------------------------------------------------------");
                                Console.WriteLine("Perfecto un libro estoico");
                                Console.WriteLine("-----------------------------------------------------------");
                                accion_valida = true;
                            }
                            else if (random_explorar <= 80)
                            {
                                Console.Clear();
                                Console.WriteLine("-----------------------------------------------------------");
                                Console.WriteLine("Encontraste un par de medias (puta basura)");
                                Console.WriteLine("-----------------------------------------------------------");
                                accion_valida = true;
                            }
                            else
                            {

                                Console.Clear();
                                Console.WriteLine("-----------------------------------------------------------");
                                Console.WriteLine("tuviste la desgracia de encontrarte con un jabali pero sabes que algun que otro golpe te llevas");
                                Console.WriteLine("-----------------------------------------------------------");
                                vida -= 2;
                                accion_valida = true;
                            }
                            break;
                        case 3:
                            if (!refugio)
                            {
                                refugio = true;
                                Console.Clear();
                                Console.WriteLine("-----------------------------------------------------------");
                                Console.WriteLine("perfecto una lona con dos palitos eso si es un hogar");
                                Console.WriteLine("-----------------------------------------------------------");
                                accion_valida = true;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("-----------------------------------------------------------");
                                Console.WriteLine("papi ya tenes un lugar llamado hogar ");
                                Console.WriteLine("-----------------------------------------------------------");
                            }
                            break;
                        case 4:
                            if (refugio)
                            {
                                fogata = true;
                                Console.Clear();
                                Console.WriteLine("--------------------------------------------------------------------");
                                Console.WriteLine("un gran paso para el hombre un pequeño paso para la humanidad, fuego.");
                                Console.WriteLine("---------------------------------------------------------------------");
                                accion_valida = true;

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("-----------------------------------------------------------");
                                Console.WriteLine(" necesitaas un hogar para poner la fogata relgas son reglas ");
                                Console.WriteLine("-----------------------------------------------------------");
                            }
                            break;
                        case 5:
                            if (comida_cruda > 0 && fogata)
                            {
                                comida_cruda--;
                                comida_cocida++;
                                Console.Clear();
                                Console.WriteLine("-----------------------------------------------------------");
                                Console.WriteLine(" cocicicnaste algo no cocido sos albert esiten");
                                Console.WriteLine("-----------------------------------------------------------");
                                accion_valida = true;

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("-----------------------------------------------------------");
                                Console.WriteLine(" no podes cocinar no tenes con que maestro.");
                                Console.WriteLine("-----------------------------------------------------------");
                            }

                            break;
                        case 6:
                            if (comida_cocida > 0)
                            {
                                comida_cocida--;
                                hambre += 8;

                                if (hambre > 10)
                                    hambre = 10;

                                Console.Clear();
                                Console.WriteLine("-----------------------------------------------------------");
                                Console.WriteLine("Comiste.");
                                Console.WriteLine("-----------------------------------------------------------");
                                accion_valida = true;

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("-----------------------------------------------------------");
                                Console.WriteLine("yo que vos cocina esa comida papi.");
                                Console.WriteLine("-----------------------------------------------------------");
                            }
                            break;
                        case 7:
                            if (refugio)
                            {
                                vida += 3;
                            }
                            else
                            {
                                vida += 1;

                            }

                            if (vida > 10)
                                vida = 10;

                            Console.Clear();
                            Console.WriteLine("-----------------------------------------------------------");
                            Console.WriteLine("Linda siesta te pegaste");
                            Console.WriteLine("-----------------------------------------------------------");
                            accion_valida = true;

                            break;
                        case 8:
                            Console.Clear();
                            Console.WriteLine("-----------------------------------------------------------");
                            Console.WriteLine("Saliste del juego.");
                            Console.WriteLine("-----------------------------------------------------------");
                            juego_activo = false;

                            continue;
                    }

                    if (accion_valida)
                    {
                        dia++;
                        hambre = hambre - 2;

                    }

                    if (hambre < 0)

                    { hambre = 0; }

                    if (hambre == 0)

                    {
                        vida = vida - 2;
                    }

                if (vida <= 0)

                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("--------------------------------------------------------------------");
                    Console.WriteLine($"             TE MORISTE CABRON sobreviviste {dia} dia                  ");
                    Console.WriteLine("--------------------------------------------------------------------");
                    Console.ReadKey();
                    juego_activo = false;
                }



            }

        }
    }
}
