using System;

class Program
{
    static void Main()
    {
        double edad;
        double ingresos;

        Console.WriteLine("Ingrese su edad: ");
        edad = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese sus ingresos: ");
        ingresos = Convert.ToDouble(Console.ReadLine());

        if (edad > 19 & ingresos <= 100000)
            Console.WriteLine("puede cobrar la beca");
        else
            if (edad < 19 & ingresos == 0)
            Console.WriteLine("puede cobrar la beca");
        else
            if (edad == 19 & ingresos <= 50000)
            Console.WriteLine("puede cobrar la beca");
        else
            Console.WriteLine("No puede cobrar la beca");


        Console.ReadKey();
    }
}
