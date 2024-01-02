namespace practicasVacaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*for(int i=1; i<=100;i++)
            {
                if(i%3==0 && i%5==0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else  
                {
                    if(i % 3 == 0)
                    { 
                    Console.WriteLine("fizz");
                    }
                    else
                    {
                        if(i%5==0)
                        {
                            Console.WriteLine("buzz");
                        }
                        else
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
                
            }*/
            /*
 * Escribe un programa que reciba un texto y transforme lenguaje natural a
 * "lenguaje hacker" (conocido realmente como "leet" o "1337"). Este lenguaje
 *  se caracteriza por sustituir caracteres alfanuméricos.
 * - Utiliza esta tabla (https://www.gamehouse.com/blog/leet-speak-cheat-sheet/) 
 *   con el alfabeto y los números en "leet".
 *   (Usa la primera opción de cada transformación. Por ejemplo "4" para la "a")
 */
            string[] abcLeet = {"4","I3","[",")",
            "3","|=","&","#","1",",_|",">|","£","[V]",
            "^/","0","|*","(_,)","I2","5","7","(_)",
            "|/","VV","><","j","2","L","R","E","A","S",
            "b","T","B","g","o"};
            char[] abcNormal = { 'A', 'B', 'C','D','E',
            'F','G','H','I','J','K','L','M','N','O','P',
            'Q','R','S','T','U','V','W','X','Y','Z','1',
            '2','3','4','5','6','7','8','9','0'};
            Console.WriteLine("Ingrese la cadena que desea cambiar a lenguaje hacker:");
            string cadena=(Console.ReadLine()!).ToUpper();
            string nuevaCadena = "";
            for(int i = 0; i < cadena.Length; i++)
            {
                char hackeado = char.Parse(cadena.Substring(i,1));
                for(int j = 0;j < abcNormal.Length;j++)
                {
                    if (hackeado == abcNormal[j])
                    {
                        nuevaCadena += abcLeet[j];
                        break;
                    }
                }
            }
            Console.WriteLine("La nueva cadena es:");
            Console.WriteLine(nuevaCadena);
        }
    }
}