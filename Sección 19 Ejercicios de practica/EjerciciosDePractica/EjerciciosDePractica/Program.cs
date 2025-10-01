using System;

namespace EjerciciosDePractica
{
    internal class Program
    {
        // Tabla de Multiplicación mediante for (sencillo)
        static void Main(string[] args)
        {
            Console.WriteLine("\n=== Ejercicio: Tabla de Multiplicación (sencillo) ===");

            Console.Write("Ingrese un número para mostrar su tabla de multiplicar: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nTabla de multiplicar del {numero}:");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}