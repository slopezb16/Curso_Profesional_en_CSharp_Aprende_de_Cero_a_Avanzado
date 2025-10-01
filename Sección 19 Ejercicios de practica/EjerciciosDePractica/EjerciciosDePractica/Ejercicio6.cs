using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePractica
{
    internal class Ejercicio6
    {
        // Reconocimiento de tecla (sencillo)
        static void Main6(string[] args)
        {
            // Clase 89
            Console.WriteLine("\n=== Ejercicio: Reconocimiento de tecla (sencillo) ===");

            Console.WriteLine("Presiona una tecla (A, B, C o ESC para salir):");

            ConsoleKeyInfo tecla = Console.ReadKey(true);

            if (tecla.Key == ConsoleKey.A)
                Console.WriteLine("Has presionado la tecla A");
            else if (tecla.Key == ConsoleKey.B)
                Console.WriteLine("Has presionado la tecla B");
            else if (tecla.Key == ConsoleKey.C)
                Console.WriteLine("Has presionado la tecla C");
            else if (tecla.Key == ConsoleKey.Escape)
                Console.WriteLine("Has presionado ESC (salir)");
            else
                Console.WriteLine("Tecla no reconocida");

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        //// Reconocimiento de tecla (mejorado con bucle)
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("\n=== Ejercicio 89: Reconocimiento de tecla (mejorado) ===");
        //    Console.WriteLine("Presiona teclas (A, B, C). Presiona ESC para salir.\n");

        //    ConsoleKeyInfo tecla;
        //    do
        //    {
        //        tecla = Console.ReadKey(true);

        //        switch (tecla.Key)
        //        {
        //            case ConsoleKey.A:
        //                Console.WriteLine("Has presionado la tecla A");
        //                break;
        //            case ConsoleKey.B:
        //                Console.WriteLine("Has presionado la tecla B");
        //                break;
        //            case ConsoleKey.C:
        //                Console.WriteLine("Has presionado la tecla C");
        //                break;
        //            case ConsoleKey.Escape:
        //                Console.WriteLine("Saliendo del programa...");
        //                break;
        //            default:
        //                Console.WriteLine("Tecla no reconocida");
        //                break;
        //        }
        //    } while (tecla.Key != ConsoleKey.Escape);
        //}
    }
}
