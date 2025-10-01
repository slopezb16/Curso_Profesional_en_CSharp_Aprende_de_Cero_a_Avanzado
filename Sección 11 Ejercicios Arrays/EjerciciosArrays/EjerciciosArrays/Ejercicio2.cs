using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosArrays
{
    internal class Ejercicio2
    {
        static void Main2(string[] args)
        {
            Console.Write("Ingrese el tamaño del array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] numeros = new int[n];

            // Ciclo for para ingresar valores
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Ingrese el valor {i + 1}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = numeros[0];

            // Ciclo for con if para encontrar máximo
            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > max)
                {
                    max = numeros[i];
                }
            }

            Console.WriteLine($"\nEl valor máximo es: {max}");
            Console.ReadKey();
        }
    }
}
