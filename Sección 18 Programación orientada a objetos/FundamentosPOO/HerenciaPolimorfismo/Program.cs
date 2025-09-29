using System;

namespace HerenciaPolimorfismo
{
    class Rectangulo // Clase Rectangulo
    {
        public virtual void Area(int Base, int Altura)
        {
            Console.WriteLine("El área del rectángulo es: " + (Base * Altura));
        }
    }

    class Triangulo : Rectangulo // Clase Triangulo hereda de Rectangulo
    {
        // Sobrescribimos el método Area
        public override void Area(int Base, int Altura)
        {
            Console.WriteLine("El área del triángulo es: " + (Base * Altura) / 2);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Clase 79
            Console.WriteLine("\n=== Polimorfismo en C# ===");

            // =======================================
            // 1. Ejemplo Polimorfismo
            // =======================================
            Console.WriteLine("\n--- Ejemplo 2: Rectángulo y Triángulo ---");

            Rectangulo rectangulo = new Rectangulo();
            rectangulo.Area(22, 5);

            Triangulo triangulo = new Triangulo();
            triangulo.Area(4, 10);

            Console.WriteLine("\n--------------------------");
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
