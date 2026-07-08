using System;

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

        for (int i = 0; i < apellidos.Length - 1; i++)
        {
            for (int j = i + 1; j < apellidos.Length; j++)
            {
                if (apellidos[i].CompareTo(apellidos[j]) > 0)
                {
                    string auxiliar = apellidos[i];
                    apellidos[i] = apellidos[j];
                    apellidos[j] = auxiliar;
                }
            }
        }

        Console.WriteLine("apellidos ordenados alfabeticamente:");

        for (int i = 0; i < apellidos.Length; i++)
        {
            Console.WriteLine(apellidos[i]);
        }
        Console.ReadKey();
    }
}
