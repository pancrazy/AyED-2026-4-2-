using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_MonedasDelNivel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("cuantas moendas doradas agarraste wachin:  ");
            int monedas_doradas = int.Parse(Console.ReadLine());

            Console.Write("cuantas moendas plateadas agarraste wachin:  ");
            int monedas_plateadas = int.Parse(Console.ReadLine());

            int total_doradas = monedas_doradas * 10;
            int total_plateada = monedas_plateadas * 2;
            int puntaje_total = total_doradas + total_plateada ;

            if (puntaje_total < 50)
            { Console.Write("tenes  puntos insuficentes" + " "+ "(" + puntaje_total + ")"); }
                else if (puntaje_total > 50 && puntaje_total < 99)
                { Console.Write(" nivel superado !!!" + " " + "(" + puntaje_total + ")"); }
                    else if (puntaje_total > 100)
                    { Console.Write("nivel superado mas bonus !!!!!! "  + " " + "(" + puntaje_total + ")" ); }

            // menor de 50 = insuficiente    50 a 99 = superado               100 o mas = nivel superado bonus
            Console.ReadKey();
            
             

            

           

           
        }
    }
}
