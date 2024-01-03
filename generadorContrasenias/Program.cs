/*
 * Escribe un programa que sea capaz de generar contraseñas de forma aleatoria.
 * Podrás configurar generar contraseñas con los siguientes parámetros:
 * - Longitud: Entre 8 y 16.
 * - Con o sin letras mayúsculas.
 * - Con o sin números.
 * - Con o sin símbolos.
 * (Pudiendo combinar todos estos parámetros entre ellos)
 */
namespace generadorContrasenias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int longitud;
            bool mayus, numeros, simbolos;
            Console.WriteLine("Bienvenido al generador de contraseñas");
            longitud = pedirLongitud();
            mayus = pedirParametros("Con letras mayúsculas");
            numeros = pedirParametros("Con números");
            simbolos = pedirParametros("Con símbolos");
            Console.Write("Pulse una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("CONTRASEÑA GENERADA EXITOSAMENTE");
        }
        public static int pedirLongitud()
        {
            bool ciclo;
            int longitud = 0;
            do
            {
                ciclo = false;
                try
                {
                    Console.Write("Ingrese la cantidad de la contraseña(8-16): ");
                    longitud=int.Parse(Console.ReadLine()!);
                    if(longitud > 16 || longitud < 8)
                    {
                        throw new Exception("Ingrese una longitud valida");
                    }
                }
                catch(FormatException e)
                {
                    ciclo = true;
                    Console.WriteLine("Formato incorrecto");
                }
                catch(Exception e)
                {
                    ciclo=true;
                    Console.WriteLine(e.Message);
                }
            }while (ciclo);
            return longitud;
        }
        public static bool pedirParametros(string mensaje)
        {
            bool ciclo;
            bool parametro=true;
            char eleccion='S';
            do
            {
                ciclo = false;
                try
                {
                    Console.Write($"{mensaje}(S o N): ");
                    eleccion=char.Parse(Console.ReadLine().ToUpper());
                    if(eleccion != 'N' && eleccion!='S')
                    {
                        throw new Exception("Ingresa una letra valida");
                    }
                }
                catch(FormatException ex)
                {
                    ciclo= true;
                    Console.WriteLine("Formato invalido");
                }
                catch(Exception ex)
                {
                    ciclo=true;
                    Console.WriteLine(ex.Message);
                }
            } while (ciclo);
            parametro= eleccion=='S' ? true : false;
            return parametro;
        }
    }
}