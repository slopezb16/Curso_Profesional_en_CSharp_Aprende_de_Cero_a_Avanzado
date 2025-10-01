using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosEstructuras
{
    internal class Ejercicio11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Conversión de cadena a número ===");
            Console.Write("Ingrese un número en letras (uno, dos, tres, cuatro, cinco): ");

            // Capturar entrada del usuario
            string num = Console.ReadLine();

            try
            {
                // usa esta sentencia dentro de la estructura Try 
                int numero = ConvertNumber(num);

                Console.WriteLine($"El número convertido es: {numero}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        // No borres este subprograma. Te permite realizar la conversión
        static int ConvertNumber(string numeroEnLetras)
        {
            switch (numeroEnLetras.ToLower()) // ToLower para evitar problemas con mayúsculas
            {
                case "uno":
                    return 1;
                case "dos":
                    return 2;
                case "tres":
                    return 3;
                case "cuatro":
                    return 4;
                case "cinco":
                    return 5;
                // Este default pertenece a la estructura Switch Case que escribas
                default:
                    throw new ArgumentException("Número en letras no reconocido.");
            }

            // Ten cuidado con los corchetes de apertura y cierre
        }
    }
}
