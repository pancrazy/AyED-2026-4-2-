using System;

class Program
{
    static int mayor(int[] numeros)
    {
        int mayor = numeros[0];

        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > mayor)
            {
                mayor = numeros[i];
            }
        }

        return mayor;
    }

    static int menor(int[] numeros)
    {
        int menor = numeros[0];

        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] < menor)
            {
                menor = numeros[i];
            }
        }

        return menor;
    }

    static double valor_medio(int[] numeros)
    {
        int suma = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            suma += numeros[i];
        }

        return (double)suma / numeros.Length;
    }

    static int suma_positivos(int[] numeros)
    {
        int suma = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] > 0)
            {
                suma += numeros[i];
            }
        }

        return suma;
    }

    static void Main(string[] args)
    {
        int[] numeros = new int[10];

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write("ingrese un numero: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("mayor: " + mayor(numeros));
        Console.WriteLine("menor: " + menor(numeros));
        Console.WriteLine("valor medio: " + valor_medio(numeros));
        Console.WriteLine("suma de positivos: " + suma_positivos(numeros));
        Console.ReadKey();
    }
}