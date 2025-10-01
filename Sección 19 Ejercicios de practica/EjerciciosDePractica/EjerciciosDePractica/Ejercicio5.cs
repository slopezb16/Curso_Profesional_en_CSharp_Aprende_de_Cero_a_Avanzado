using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePractica
{
    internal class Ejercicio5
    {
        // Mayor de 3 numeros y Cual es el menor
        static void Main5(string[] args)
        {
            // Clase 88
            Console.WriteLine("\n=== Ejercicio: Mayor y Menor de 3 números ===");

            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el tercer número: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            double mayor, menor;

            // Encontrar el mayor
            if (num1 >= num2 && num1 >= num3)
                mayor = num1;
            else if (num2 >= num1 && num2 >= num3)
                mayor = num2;
            else
                mayor = num3;

            // Encontrar el menor
            if (num1 <= num2 && num1 <= num3)
                menor = num1;
            else if (num2 <= num1 && num2 <= num3)
                menor = num2;
            else
                menor = num3;

            Console.WriteLine($"\nEl número mayor es: {mayor}");
            Console.WriteLine($"El número menor es: {menor}");

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        //// Mayor y menor de 3 números
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("\n=== Ejercicio: Mayor y Menor de 3 números ===");

        //    Console.Write("Ingrese el primer número: ");
        //    double num1 = Convert.ToDouble(Console.ReadLine());

        //    Console.Write("Ingrese el segundo número: ");
        //    double num2 = Convert.ToDouble(Console.ReadLine());

        //    Console.Write("Ingrese el tercer número: ");
        //    double num3 = Convert.ToDouble(Console.ReadLine());

        //    double mayor = Math.Max(num1, Math.Max(num2, num3));
        //    double menor = Math.Min(num1, Math.Min(num2, num3));

        //    Console.WriteLine($"\nEl número mayor es: {mayor}");
        //    Console.WriteLine($"El número menor es: {menor}");

        //    Console.WriteLine("\nPresiona cualquier tecla para salir...");
        //    Console.ReadKey();
        //}

        //// Mayor, menor, promedio, suma y ordenamiento de 3 números
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("\n=== Ejercicio: Operaciones con 3 números ===");

        //    double[] numeros = new double[3];

        //    for (int i = 0; i < 3; i++)
        //    {
        //        Console.Write($"Ingrese el número {i + 1}: ");
        //        numeros[i] = Convert.ToDouble(Console.ReadLine());
        //    }

        //    double mayor = numeros.Max();
        //    double menor = numeros.Min();
        //    double suma = numeros.Sum();
        //    double promedio = numeros.Average();

        //    Console.WriteLine($"\nEl número mayor es: {mayor}");
        //    Console.WriteLine($"El número menor es: {menor}");
        //    Console.WriteLine($"La suma de los números es: {suma}");
        //    Console.WriteLine($"El promedio es: {promedio:F2}");

        //    Console.WriteLine("\nNúmeros ordenados de menor a mayor:");
        //    foreach (var n in numeros.OrderBy(x => x))
        //    {
        //        Console.WriteLine(n);
        //    }

        //    Console.WriteLine("\nNúmeros ordenados de mayor a menor:");
        //    foreach (var n in numeros.OrderByDescending(x => x))
        //    {
        //        Console.WriteLine(n);
        //    }

        //    Console.WriteLine("\nPresiona cualquier tecla para salir...");
        //    Console.ReadKey();
        //}
    }
}
