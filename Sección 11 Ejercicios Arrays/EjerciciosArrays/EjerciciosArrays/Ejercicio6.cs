using System;

namespace EjerciciosArrays
{
    internal class Ejercicio6
    {
        static void Main6(string[] args)
        {
            // Definir un jagged array (arreglo de arreglos)
            int[][] jagged = new int[][]
            {
                new int[] {1, 2, 3},
                new int[] {4, 5},
                new int[] {6, 7, 8, 9}
            };

            // Contar elementos en cada subarray
            for (int i = 0; i < jagged.Length; i++)
            {
                Console.WriteLine($"Subarray {i + 1} tiene {jagged[i].Length} elementos.");
            }

            Console.ReadKey();
        }
    }
}