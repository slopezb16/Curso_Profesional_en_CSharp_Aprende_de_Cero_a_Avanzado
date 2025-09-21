using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClicloForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Clase 32

            // Ejemplo 1
            Console.WriteLine("\n=== Ejemplo con ciclo foreach ===");

            string nombre = "Academi Ciencia";

            //foreach (char letra in nombre)
            foreach (var letra in nombre)
            {
                Console.WriteLine(letra);
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
