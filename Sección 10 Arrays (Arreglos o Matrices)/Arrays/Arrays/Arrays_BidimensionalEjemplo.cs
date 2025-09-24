using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Arrays_BidimensionalEjemplo
    {
        static void Main(string[] args)
        {
            // Clase 45

            Console.WriteLine("\n=== Arreglos - Arrays ===");

            /* Tipos de arrays
             * Arrays de 1 dimencion
             * Arrays de 2 dimenciones - estamos en esta
             * Arrays de tipo Jagged
             * Arrays con parametros a metodos
             */

            //int[,] matriz = new int[,] { { } };
            int[,] matriz = {
                {1, 2, 3 },
                {4, 5, 6 },
                {7, 8, 9 }
            };

            int suma = 0;

            for (int i = 0; i < matriz.GetLength(0); i++) // Filas
            {
                for (int j = 0; j < matriz.GetLength(1); j++) // Columnas
                {
                    suma += matriz[i, j];
                }
            }

            Console.WriteLine("La suma de los valores de la matriz es: {0}", suma);

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
