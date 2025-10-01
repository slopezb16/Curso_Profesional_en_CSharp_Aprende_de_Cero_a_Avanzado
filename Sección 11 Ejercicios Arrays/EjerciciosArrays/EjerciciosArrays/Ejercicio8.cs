using System;

namespace EjerciciosArrays
{
    internal class Ejercicio8
    {
        static void Main8(string[] args)
        {
            int[] numeros = { 10, 20, 30, 40, 50 };

            int suma = SumarElementos(numeros);

            Console.WriteLine($"La suma de los elementos es: {suma}");
            Console.ReadKey();
        }

        // Método que recibe un array y suma sus elementos
        static int SumarElementos(int[] arr)
        {
            int suma = 0;

            foreach (int num in arr)
            {
                suma += num;
            }

            return suma;
        }
    }
}
