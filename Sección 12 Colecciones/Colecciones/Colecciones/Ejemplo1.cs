using System;
using System.Collections;

namespace Colecciones
{
    internal class Ejemplo1
    {
        static void Main1(string[] args)
        {
            // Clase 50

            // Arrays List
            Console.WriteLine("\n=== Arrays List ===");

            // Ejemplo 1
            Console.WriteLine("\n--- Ejemplo Array List ---");

            ArrayList datos = new ArrayList();

            datos.Add(7);
            datos.Add(5);
            datos.Add(1);

            Console.WriteLine("Estos son los datos del Ejemplo 1 de arraylist");

            Imprimir(datos);

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        private static void Imprimir(ArrayList datos)
        {
            foreach (int i in datos)
            {
                Console.WriteLine(i);
                Console.WriteLine("\n------------------");
            }
        }
    }
}
