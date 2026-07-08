using System;

class Program
{
    static void Main()
    {
        string[,] basesdedatos = new string[5, 8];

        for (int i = 0; i < basesdedatos.GetLength(0); i++)
        {
            Console.WriteLine("Ingrese los datos de la base de datos " + (i + 1));

            Console.Write("Nombre: ");
            basesdedatos[i, 0] = Console.ReadLine();

            Console.Write("Creador: ");
            basesdedatos[i, 1] = Console.ReadLine();

            Console.Write("Desarrollador actual: ");
            basesdedatos[i, 2] = Console.ReadLine();

            Console.Write("Version inicial: ");
            basesdedatos[i, 3] = Console.ReadLine();

            Console.Write("Modelo: ");
            basesdedatos[i, 4] = Console.ReadLine();

            Console.Write("Lenguaje: ");
            basesdedatos[i, 5] = Console.ReadLine();

            Console.Write("Sistemas operativos soportados: ");
            basesdedatos[i, 6] = Console.ReadLine();

            Console.Write("Licencia: ");
            basesdedatos[i, 7] = Console.ReadLine();

            Console.WriteLine("-----------------------");
        }



        for (int i = 0; i < basesdedatos.GetLength(0); i++)
        {
            Console.WriteLine("Base de datos: " + basesdedatos[i, 0]);
            Console.WriteLine("Creador: " + basesdedatos[i, 1]);
            Console.WriteLine("Desarrollador actual: " + basesdedatos[i, 2]);
            Console.WriteLine("Version inicial: " + basesdedatos[i, 3]);
            Console.WriteLine("Modelo: " + basesdedatos[i, 4]);
            Console.WriteLine("Lenguaje: " + basesdedatos[i, 5]);
            Console.WriteLine("SO soportados: " + basesdedatos[i, 6]);
            Console.WriteLine("Licencia: " + basesdedatos[i, 7]);
            Console.WriteLine("-----------------------");
        }

        Console.ReadKey();
    }
}