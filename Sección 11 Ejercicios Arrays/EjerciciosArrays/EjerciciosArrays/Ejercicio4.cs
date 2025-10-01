using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosArrays
{
    internal class Ejercicio4
    {
        static void Main4(string[] args)
        {
            int[,] matriz = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            int suma = 0;

            // For anidado con GetLength
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    suma += matriz[i, j];
                }
            }

            Console.WriteLine($"La suma de los elementos de la matriz es: {suma}");
            Console.ReadKey();
        }
    }
}
