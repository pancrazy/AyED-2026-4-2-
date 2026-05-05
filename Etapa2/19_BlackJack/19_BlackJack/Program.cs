using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            int rondas_ganadas = 0;
            int rondas_perdidas = 0;
            int rondas_empatas = 0;
            int puntaje_usuario = 0;
            int puntaje_maquina = 0;
            bool plantarse = false;
            bool ronda_terminada = false;

            Random azar = new Random();
            bool juego_activo = true;

            while (juego_activo)
            {
                Console.WriteLine("======== BRASINO 67 ========");
                Console.WriteLine();
                Console.WriteLine($"Puntaje del jugador: {puntaje_usuario}");
                Console.WriteLine($"Puntaje de la máquina: {puntaje_maquina}");
                Console.WriteLine();
                Console.WriteLine("1  Pedir carta");
                Console.WriteLine("2  Plantarse");
                Console.WriteLine("3  Reglas");
                Console.WriteLine("4  Salir");
                Console.WriteLine();
                Console.WriteLine($"Ganadas {rondas_ganadas} | Empatadas {rondas_empatas} | Perdidas {rondas_perdidas}");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        int random_usuario = azar.Next(1, 12);
                        puntaje_usuario += random_usuario;
                        break;

                    case 2:
                        Console.Clear();
                        while (puntaje_maquina <= 17)
                        {
                            puntaje_maquina += azar.Next(1, 12);
                        }
                        plantarse = true;
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Tener mas que la casa para poder ganar, condiciones, no podes tener mas de 21 se considerada una perdida automatica, la casa no puede pedir despues de los 17, si ocurreun empate el ambas partes quedan de igual manera.");
                        break;

                    case 4:
                        juego_activo = false; 
                        break;

                }


                if (puntaje_usuario > 21)
                {
                    Console.WriteLine("Te pasaste de 21. Perdiste la ronda.");
                    rondas_perdidas++;
                    ronda_terminada = true;
                }


                else if (puntaje_maquina > 21)
                {
                    Console.WriteLine("La máquina se pasó. Ganaste la ronda.");
                    rondas_ganadas++;
                    ronda_terminada = true;
                }


                if (plantarse && !ronda_terminada)
                {
                    if (puntaje_usuario > puntaje_maquina)
                    {
                        Console.WriteLine("Ganaste la ronda.");
                        rondas_ganadas++;
                    }
                    else if (puntaje_usuario < puntaje_maquina)
                    {
                        Console.WriteLine("Perdiste la ronda.");
                        rondas_perdidas++;
                    }
                    else
                    {
                        Console.WriteLine("Empate.");
                        rondas_empatas++;
                    }

                    ronda_terminada = true;
                }

                // se reincia las cartas paaaaa
                if (ronda_terminada)
                {
                    Console.WriteLine("Presioná una tecla para la siguiente ronda...");
                    Console.ReadKey();
                    Console.Clear();

                    puntaje_usuario = 0;
                    puntaje_maquina = 0;
                    plantarse = false;
                    ronda_terminada = false;
                }
            }
        }
     }
}
