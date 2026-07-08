class Program
{
    static void Main()

    {
        // 1. Declaración e inicialización del tablero (Matriz de 3x3)
        // Llenamos el tablero con guiones &#39;-&#39; para indicar que está vacío
        char[,] tablero = {
{ &#39;-&#39;, &#39;-&#39;, &#39;-&#39; },
{ &#39;-&#39;, &#39;-&#39;, &#39;-&#39; },
{ &#39;-&#39;, &#39;-&#39;, &#39;-&#39; }
};

        Console.WriteLine(&quot; ---TABLERO INICIAL(VACÍO)-- - &quot;);
        MostrarTablero(tablero);
        Console.WriteLine();

        // 2. Simulación de jugadas (Modificando posiciones específicas)
        // Recordá que los índices van de 0 a 2
        tablero[1, 1] = &#39;X&#39;; // El Jugador 1 juega en el centro
tablero[0, 2] = &#39;O&#39;; // El Jugador 2 juega en la esquina superior derecha
tablero[2, 0] = &#39;X&#39;; // El Jugador 1 juega en la esquina inferior izquierda
tablero[0, 0] = &#39;O&#39;; // El Jugador 2 juega en la esquina superior izquierda

Console.WriteLine(&quot; ---TABLERO DESPUÉS DE ALGUNAS JUGADAS ---&quot;);
        MostrarTablero(tablero);
    }



    static void MostrarTablero(char[,] matriz)
    {
       
        for (int i = 0; i & lt; matriz.GetLength(0); i++)
{
            
            for (int j = 0; j & lt; matriz.GetLength(1); j++)
{
             
                Console.Write(matriz[i, j] + &quot; &quot;);
            }

            
            Console.WriteLine();
        }
    }
}