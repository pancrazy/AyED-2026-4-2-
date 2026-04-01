using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la primera letra:");
        string letra1 = Console.ReadLine();

        Console.WriteLine("Ingrese la segunda letra:");
        string letra2 = Console.ReadLine();

        Console.WriteLine("Ingrese la tercera letra:");
        string letra3 = Console.ReadLine();

        Console.WriteLine("Las letras en orden inverso son:");
        Console.WriteLine(letra3 + " " + letra2 + " " + letra1);
        Console.ReadKey();
    }
}