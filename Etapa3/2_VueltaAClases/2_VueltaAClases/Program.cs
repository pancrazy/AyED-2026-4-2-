using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_VueltaAClases
{
    class Program
    {
        static void Main(string[] args)
        {
            int total_examenes = 0;
            int promedio_examenes = 0;

            int tps_aprobados = 0;
            float porcentaje_tps = 0;

            Console.WriteLine("¿Cantidad de examenes?:");
            int examenes = int.Parse(Console.ReadLine());
            int[] lista_examenes = new int[examenes];

            Console.Clear();
            Console.WriteLine("¿Cantidad de tps?:");
            int tps = int.Parse(Console.ReadLine());
            int[] lista_tps = new int[tps];




            for (int contador = 0; contador < lista_examenes.Length; contador++)
            {
                Console.Write("Nota del examen  " + (contador + 1) + ": ");
                lista_examenes[contador] = int.Parse(Console.ReadLine());
                if (lista_examenes[contador] > 10)
                {
                    Console.Clear();
                    Console.WriteLine("Error , reinicie el programa.");
                }

            }

            for (int contador = 0; contador < lista_tps.Length; contador++)
            {
                Console.WriteLine(" ");
                Console.Write("Nota del trabajo practico " + (contador + 1) + ": ");
                lista_tps[contador] = int.Parse(Console.ReadLine());
                if (lista_tps[contador] > 10)
                {
                    Console.Clear();
                    Console.WriteLine("Error , reinicie el programa.");
                }

            }



            for (int contador = 0; contador < lista_examenes.Length; contador++)
            {
                total_examenes = total_examenes + lista_examenes[contador];

            }

            promedio_examenes = total_examenes / lista_examenes.Length;

            for (int contador = 0; contador < lista_tps.Length; contador++)
            {

                if (lista_tps[contador] >= 6)
                {
                    tps_aprobados++;
                }
            }

            Console.Clear();
            porcentaje_tps = (tps_aprobados * 100) / lista_tps.Length;

            if (promedio_examenes > 6 || porcentaje_tps > 75)
            {
                Console.Clear();
                Console.Write("Por medio de la presente se informa que los estudiantes Phineas Flynn y Ferb Fletcher han aprobado satisfactoriamente la evaluación correspondiente ");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine($"console Promedio obtenido: {promedio_examenes} ");
                Console.WriteLine("");
                Console.WriteLine($"Porcentaje alcanzado: {porcentaje_tps} % ");
                Console.WriteLine("");
                Console.WriteLine("Felicitamos a los estudiantes por su desempeño y compromiso demostrado durante el período evaluado.");
                Console.WriteLine("Sin otro particular, se extiende la presente para los fines que se consideren necesarios.");
            }
            else

            {
                Console.Write("   Por medio de la presente se informa que los estudiantes Phineas Flynn y Ferb Fletcher no alcanzaron la calificación mínima requerida para aprobar la evaluación correspondiente.");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine($"Promedio obtenido: {promedio_examenes}");
                Console.WriteLine("");
                Console.WriteLine($"Porcentaje alcanzado: {porcentaje_tps} % ");
                Console.WriteLine("");
                Console.WriteLine(" Se recomienda reforzar los contenidos y continuar trabajando para mejorar el rendimiento académico en futuras evaluaciones.");
                Console.WriteLine("Sin otro particular, se extiende la presente para los fines que se consideren necesarios.");


            }

            Console.ReadKey();

        }
    }
}




