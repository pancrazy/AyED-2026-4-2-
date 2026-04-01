using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_PresupuestoHospitalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese el presuspuesto anual: ");

            double presupuesto_anual = double.Parse(Console.ReadLine());

            double presupuesto_ginecologia = (presupuesto_anual / 10) * 4;
            double presupuesto_traumatologia = (presupuesto_anual / 10) * 3;
            double presupuesto_pediatria = (presupuesto_anual / 10) * 3;

            Console.Write("los presupuestos para cada area son: ginecologia = " + presupuesto_ginecologia + "$" + " presupuesto de trauamatologia = " + presupuesto_traumatologia +"$" + " y el presupuesto de pediatria es = " + presupuesto_pediatria + "$");
            Console.ReadKey();
        }
    }
}
