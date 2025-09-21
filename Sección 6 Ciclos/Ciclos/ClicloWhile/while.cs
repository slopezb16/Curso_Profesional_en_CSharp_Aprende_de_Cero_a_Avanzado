using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClicloWhile
{
    internal class @while
    {
        static void Main1(string[] args)
        {
            // Clase 32

            // Ejemplo 1
            Console.WriteLine("\n=== Ejemplo con ciclo while ===");
            Console.WriteLine("");

            Console.WriteLine("Programa que permita enfriar un horno a 20 c");
            Console.WriteLine("");

            // Temperatura inicial del horno
            int temperatura;

            // Pedir datos
            Console.WriteLine("Ingrese la temperatura actual");
            temperatura = Convert.ToInt32(Console.ReadLine());


            // Ciclo mientras la temperatura sea mayor a 20
            while (temperatura > 20)
            {
                Console.WriteLine("La temperatura actual es: {0} °C", temperatura);

                // Disminuir la temperatura en cada iteración
                //temperatura -= 1;
                temperatura--;

                // Para simular el tiempo (opcional)
                System.Threading.Thread.Sleep(300);
            }

            Console.WriteLine("\nEl horno se ha enfriado. Temperatura final: {0} °C", temperatura);


            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
