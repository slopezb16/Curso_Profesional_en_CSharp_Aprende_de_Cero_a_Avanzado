using System;

namespace EjerciciosArrays
{
    internal class Ejercicio7
    {
        static void Main7(string[] args)
        {
            int[][] jagged = new int[][]
            {
                new int[] {1, 2, 3},
                new int[] {4, 5},
                new int[] {6, 7, 8, 9}
            };

            int suma = 0;

            foreach (int[] subArray in jagged)
            {
                foreach (int num in subArray)
                {
                    suma += num;
                }
            }

            Console.WriteLine($"La suma de todos los elementos del array jagged es: {suma}");
            Console.ReadKey();
        }
    }
}
