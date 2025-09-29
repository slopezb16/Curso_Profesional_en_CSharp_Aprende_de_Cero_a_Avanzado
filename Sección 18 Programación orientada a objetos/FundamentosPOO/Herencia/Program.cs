using System;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Clase 78
            Console.WriteLine("\n=== Herencia en C# ===");

            // =======================================
            // 1. Ejemplo 2 Herencia
            // =======================================
            Console.WriteLine("\n--- Ejemplo 1: Clase Padre e Hijo ---");

            Console.WriteLine("\n--- Ejemplo Padre ---");
            Padre Raiz = new Padre();

            Raiz.Altura();
            Raiz.Ojos();

            Console.WriteLine("\n--- Ejemplo Hijo ---");
            Hijo herenciaFisiologica = new Hijo();

            herenciaFisiologica.Altura();
            herenciaFisiologica.Ojos();

            Console.WriteLine("\n--------------------------");
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
