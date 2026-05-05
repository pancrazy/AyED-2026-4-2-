using System;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {

            double edad;
            string nombre;
            string apellido;
            int prestacion;
            int menores = 0;
            int mayores = 0;
            int odontologia = 0;
            int pediatria = 0;
            int clinica_medica = 0;

            do
            {
                Console.WriteLine("ingrese la prestacion por la que viene por favor por favor");
                Console.WriteLine("1. clinica medica");
                Console.WriteLine("2. odontologia");
                Console.WriteLine("3. pediatria");
                Console.WriteLine("0. salir de la pagina");
                prestacion = int.Parse(Console.ReadLine());
                if (prestacion != 0)
                {

                    switch (prestacion)
                    {
                        case 1:
                            clinica_medica++;
                            break;
                        case 2:
                            odontologia++;
                            break;
                        case 3:
                            pediatria++;
                            break;

                        default:
                            Console.WriteLine("prestacion no valida");
                            break;
                    }
                    Console.WriteLine("ingrese su edad por favor");
                    edad = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("ingrese su nombre por favor");
                    nombre = Console.ReadLine();
                    Console.WriteLine("ingrese su apellido por favor");
                    apellido = Console.ReadLine();

                    if (edad >= 18)
                        mayores++;
                    else
                        menores++;
                }
            }
            while (prestacion != 0) ;
            Console.WriteLine("cantidad de menores: " + menores);
            Console.WriteLine("cantidad de mayores: " + mayores);
            Console.WriteLine("pacientes en clinica medica: " + clinica_medica);
            Console.WriteLine("pacientes en odontologia: " + odontologia);
            Console.WriteLine("pacientes en pediatria: " + pediatria);
            Console.ReadKey();
        }
    }
}
