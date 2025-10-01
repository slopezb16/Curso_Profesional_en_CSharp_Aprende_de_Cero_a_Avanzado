using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePractica
{
    internal class Ejercicio7
    {
        // Tabla de Multiplicación mediante for (sencillo)
        static void Main7(string[] args)
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

        //// Tablas de Multiplicación del 1 al 10 (avanzado con for anidados)
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("\n=== Ejercicio: Tablas de Multiplicación (avanzado) ===");

        //    for (int numero = 1; numero <= 10; numero++)
        //    {
        //        Console.WriteLine($"\nTabla del {numero}:");

        //        for (int i = 1; i <= 10; i++)
        //        {
        //            Console.WriteLine($"{numero} x {i} = {numero * i}");
        //        }
        //    }

        //    Console.WriteLine("\nPresiona cualquier tecla para salir...");
        //    Console.ReadKey();
        //}
    }
}
