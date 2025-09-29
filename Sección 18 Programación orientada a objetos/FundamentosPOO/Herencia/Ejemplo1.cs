using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Ejemplo1
    {
        class Padre // Clase Padre
        {
            public void Ojos()
            {
                Console.WriteLine("Tiene los ojos de color Azul");
            }

            public void Altura()
            {
                Console.WriteLine("Mide 1.80 metros");
            }
        }

        class Hijo : Padre // Clase Hijo que hereda de Padre
        {
        }

        internal class Program
        {
            static void Main1(string[] args)
            {
                // Clase 78
                Console.WriteLine("\n=== Herencia en C# ===");

                // =======================================
                // 1. Ejemplo Herencia
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
}
