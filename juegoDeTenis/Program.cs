namespace Retos;
public class Jugador
{
    public string Puntos { get; set; }
}
/*
 * Escribe un programa que muestre cómo transcurre un juego de tenis y quién lo ha ganado.
 * El programa recibirá una secuencia formada por "P1" (Player 1) o "P2" (Player 2), según quien
 * gane cada punto del juego.
 * 
 * - Las puntuaciones de un juego son "Love" (cero), 15, 30, 40, "Deuce" (empate), ventaja.
 * - Ante la secuencia [P1, P1, P2, P2, P1, P2, P1, P1], el programa mostraría lo siguiente:
 *   15 - Love
 *   30 - Love
 *   30 - 15
 *   30 - 30
 *   40 - 30
 *   Deuce
 *   Ventaja P1
 *   Ha ganado el P1
 * - Si quieres, puedes controlar errores en la entrada de datos.   
 * - Consulta las reglas del juego si tienes dudas sobre el sistema de puntos.   
 */
public class RetoDos
{
    public static void Main(string[] args)
    {
        Jugador jugador1 = new Jugador();
        Jugador jugador2 = new Jugador();
        string[] puntuaciones = { "Love", "15", "30", "40", "Ganó"};
        Console.WriteLine("Set 1");
        Juego(jugador1, jugador2, puntuaciones);
    }
    public static void Juego(Jugador j1,Jugador j2, string[] puntuaciones)
    {
        Random random = new Random();
        int turno, indice1, indice2;
        turno = indice1 = indice2 = 0;
        j1.Puntos = puntuaciones[indice1];
        j2.Puntos = puntuaciones[indice2];
        while (indice1 != 4 && indice2 != 4)
        {
            turno++;
            int randomico = random.Next(0, 2);
            if(turno%2 == 0)
            {
                indice2 += randomico;
                j2.Puntos = puntuaciones[indice2];
                Console.WriteLine("Turno Jugador 2");
            }
            else
            {
                indice1 += randomico;
                j1.Puntos = puntuaciones[indice1];
                Console.WriteLine("Turno Jugador 1");
            }
            if(indice1 != 4 && indice2 !=4)
            {
                Console.ReadKey();
                Console.WriteLine($"{j1.Puntos} - {j2.Puntos}");
                Console.ReadKey();
            }  
        }
        string mensajeGanador = j1.Puntos == "Ganó" ? $"Ganador del Set: Jugador 1" : $"Ganador del Set: Jugador 2";
        Console.ReadKey();
        Console.WriteLine(mensajeGanador);
    }
}