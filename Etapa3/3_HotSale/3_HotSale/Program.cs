using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_HotSale
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("¿Cantidad de productso vendidos?:");
            int productos_vendidos = int.Parse(Console.ReadLine());
            int[] lista_productos = new int[productos_vendidos];

            int productos_menor = 0;
            int producto_mayor = 0;

            for (int contador = 0; contador < lista_productos.Length; contador++)
            {
                Console.Write("Precio por el producto " + (contador + 1) + ": ");
                lista_productos[contador] = int.Parse(Console.ReadLine());  
            }

            Console.Clear();
            Array.Sort(lista_productos);
            productos_menor = lista_productos[0];
            Array.Reverse(lista_productos);
            producto_mayor = lista_productos[0];

            Console.Write($"El producto con el mayor precio fue {producto_mayor} y el producto con el menor precio es {productos_menor} ");
            

            Console.ReadKey();

    }
    }
 }
