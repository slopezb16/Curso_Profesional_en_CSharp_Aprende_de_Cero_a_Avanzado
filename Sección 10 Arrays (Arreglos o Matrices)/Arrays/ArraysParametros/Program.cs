using System;

namespace ArraysParametros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Clase 46
            Console.WriteLine("\n=== Arreglos - Arrays ===");

            /* Tipos de arrays
             * Arrays de 1 dimensión
             * Arrays de 2 dimensiones 
             * Arrays de tipo Jagged 
             * Arrays con parámetros a métodos - estamos en esta
             */

            // Crear arreglo normal
            int[] numeros = new int[5];

            // 1. Ingresar calificaciones
            numeros = IngresarCalificaciones(numeros);

            // 2. Imprimir calificaciones
            Imprimir(numeros);

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        // Método para ingresar calificaciones
        static int[] IngresarCalificaciones(int[] numeros)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Ingrese número {i + 1}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            return numeros;
        }

        // Método para imprimir Numeros
        static void Imprimir(int[] numeros)
        {
            Console.WriteLine("\n=== Numeros ingresados ===");
            foreach (int num in numeros)
            {
                Console.WriteLine("El numero es {0}", num);
            }
        }
    }
}