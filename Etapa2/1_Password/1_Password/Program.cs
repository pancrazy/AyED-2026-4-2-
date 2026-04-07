using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            const string CONSTRASEÑA  = "hola";
            Console.Write("Ingrese su contraseña: ");
            string verificacion_contraseña = Console.ReadLine();
            string verificacion = verificacion_contraseña.ToLower();

            if (verificacion == CONSTRASEÑA)
            { Console.Write("Su contraseña esta bien");}
            else
            {   Console.Write("Su contraseña  está para el hoyo");}




            Console.ReadKey();
        }
    }
}
