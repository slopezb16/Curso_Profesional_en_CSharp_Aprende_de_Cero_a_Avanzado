using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosArrays
{
    internal class Ejercicio1
    {
        static void Main1(string[] args)
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

            int suma = 0;

            // Ciclo foreach para sumar valores
            foreach (int num in numeros)
            {
                suma += num;
            }

            Console.WriteLine($"\nLa suma de los números es: {suma}");
            Console.ReadKey();
        }
    }
}
