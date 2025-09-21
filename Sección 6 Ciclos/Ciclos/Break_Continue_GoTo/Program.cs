using System;
using System.Threading;

namespace Break_Continue_GoTo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Clase 35

            // Ejemplo 1 - Break
            //Console.WriteLine("\n=== Ejemplo con Break ===");
            //Console.WriteLine("Imprimir números hasta encontrar el 5");
            //for (int i = 1; i <= 10; i++)
            //{
            //    Thread.Sleep(500);

            //    if (i == 5)
            //    {
            //        Console.WriteLine("Se encontró el número 5, se detiene el ciclo con break");
            //        break; // rompe el ciclo
            //    }
            //    Console.WriteLine("Número: " + i);
            //}

            // Ejemplo 2 - Continue
            //Console.WriteLine("\n=== Ejemplo con Continue ===");
            //Console.WriteLine("Imprimir números del 1 al 20, pero saltar los pares");
            //for (int i = 1; i <= 20; i++)
            //{
            //    Thread.Sleep(500);

            //    if (i % 2 == 0)
            //    {
            //        continue; // salta esta iteración si el número es par
            //    }
            //    Console.WriteLine("Número impar: " + i);
            //}

            // Ejemplo 3 - Go To
            //    Console.WriteLine("\n=== Ejemplo con Go To ===");
            //    //Console.WriteLine("Ir a una etiqueta específica");

            //    //int numero = 1;

            //    //Inicio: // etiqueta
            //    //Console.WriteLine("Número actual: " + numero);
            //    //numero++;

            //    //if (numero <= 5)
            //    //{
            //    //    goto Inicio; // vuelve a la etiqueta
            //    //}
            //    //Console.WriteLine("Se terminó el ciclo con GoTo");

            //    for (int i = 1; i <= 20; i++)
            //    {
            //        Thread.Sleep(500);

            //        if (i == 9)
            //        {
            //            Console.WriteLine("");
            //            goto retirados;
            //        }
            //        Console.WriteLine("Afiliado: " + i);
            //    }
            //retirados:
            //    Console.WriteLine("El afiliado 9 se reporto como retirado");

            // Ejemplo 4
            Console.WriteLine("=== Ejemplo combinado: Break, Continue y GoTo ===\n");

            for (int i = 1; i <= 20; i++)
            {
                Thread.Sleep(500);

                // Ejemplo de Continue -> saltar los números pares
                if (i % 2 == 0)
                {
                    continue;
                }

                // Ejemplo de Break -> detener el ciclo si se encuentra el 15
                if (i == 15)
                {
                    Console.WriteLine("Se encontró el número 15. Se detiene el ciclo con break.");
                    break;
                }

                // Ejemplo de GoTo -> si el número es 9, ir a una etiqueta especial
                if (i == 9)
                {
                    goto Retirados;
                }

                Console.WriteLine("Número válido: " + i);
            }

        // Etiqueta GoTo
        Retirados:
            Console.WriteLine("\nEl número 9 se reporta como retirado (GoTo activado).");



            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}