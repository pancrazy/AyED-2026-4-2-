using System;

class program
{
    static void main()
    {
        int[] numeros = new int[10];

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write("ingrese un numero: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("numeros en orden inverso:");

        for (int i = numeros.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(numeros[i]);
        }
        Console.ReadKey();
    }
}