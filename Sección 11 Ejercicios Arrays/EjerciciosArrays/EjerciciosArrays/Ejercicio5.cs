using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosArrays
{
    internal class Ejercicio5
    {
        static void Main5(string[] args)
        {
            int[,] matriz = {
                {10, 20, 30},
                {40, 50, 60},
                {70, 80, 90}
            };

            int max = matriz[0, 0];

            // For anidado con GetLength
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] > max)
                    {
                        max = matriz[i, j];
                    }
                }
            }

            Console.WriteLine($"El valor máximo en la matriz es: {max}");
            Console.ReadKey();
        }
    }
}
