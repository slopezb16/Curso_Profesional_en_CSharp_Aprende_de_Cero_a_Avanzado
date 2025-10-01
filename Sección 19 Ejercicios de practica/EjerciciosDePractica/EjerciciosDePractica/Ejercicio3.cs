using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePractica
{
    internal class Ejercicio3
    {
        // Sacarle operaciones para un numero
        static void Main3(string[] args)
        {
            // Clase 86
            Console.WriteLine("\n=== Ejercicio Sacarle operaciones para un numero en C# ===");
            /** Valor apsoluto
             * Potencia
             * raiz cuadrada
             * seno
             * coseno
             * numero maximo
             * numero minimo
             * etc
             */

            Console.WriteLine("Ingrese un número:");
            float numero = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"\nNúmero ingresado: {numero}");
            Console.WriteLine($"Valor absoluto: {Math.Abs(numero)}");
            Console.WriteLine($"Potencia (número^2): {Math.Pow(numero, 2)}");
            Console.WriteLine($"Potencia (número^3): {Math.Pow(numero, 3)}");
            Console.WriteLine($"Raíz cuadrada: {Math.Sqrt(numero):F2}");
            Console.WriteLine($"Seno: {Math.Sin(numero):F4}");
            Console.WriteLine($"Seno 2: {Math.Sin(numero * Math.PI / 180)}");
            Console.WriteLine($"Coseno: {Math.Cos(numero):F4}");
            Console.WriteLine($"Coseno 2: {Math.Cos(numero * Math.PI / 180)}");
            Console.WriteLine($"Número máximo entre {numero} y 100: {Math.Max(numero, 100)}");
            Console.WriteLine($"Número mínimo entre {numero} y 100: {Math.Min(numero, 100)}");
            Console.WriteLine($"Parte entera (truncada): {Math.Truncate(numero)}");
            Console.WriteLine($"Número redondeado (π * número): {Math.Round(numero)}");
            Console.WriteLine($"Número redondeado (π * número) 2: {Math.Round(Math.PI * numero, 2)}");

            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        //// Sacar operaciones para un número
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("\n=== Ejercicio Operaciones con un número en C# ===");

        //    Console.WriteLine("Ingrese un número:");
        //    int numero = int.Parse(Console.ReadLine());

        //    int opcion;
        //    do
        //    {
        //        Console.WriteLine("\nElige una operación:");
        //        Console.WriteLine("1. Valor absoluto");
        //        Console.WriteLine("2. Potencia (número^2)");
        //        Console.WriteLine("3. Raíz cuadrada");
        //        Console.WriteLine("4. Seno");
        //        Console.WriteLine("5. Coseno");
        //        Console.WriteLine("6. Máximo con 100");
        //        Console.WriteLine("7. Mínimo con 100");
        //        Console.WriteLine("0. Salir");
        //        Console.Write("Opción: ");
        //        opcion = int.Parse(Console.ReadLine());

        //        switch (opcion)
        //        {
        //            case 1: Console.WriteLine($"Valor absoluto: {Math.Abs(numero)}"); break;
        //            case 2: Console.WriteLine($"Potencia (número^2): {Math.Pow(numero, 2)}"); break;
        //            case 3: Console.WriteLine($"Raíz cuadrada: {Math.Sqrt(numero)}"); break;
        //            case 4: Console.WriteLine($"Seno: {Math.Sin(numero)}"); break;
        //            case 5: Console.WriteLine($"Coseno: {Math.Cos(numero)}"); break;
        //            case 6: Console.WriteLine($"Máximo entre {numero} y 100: {Math.Max(numero, 100)}"); break;
        //            case 7: Console.WriteLine($"Mínimo entre {numero} y 100: {Math.Min(numero, 100)}"); break;
        //            case 0: Console.WriteLine("Saliendo..."); break;
        //            default: Console.WriteLine("Opción inválida"); break;
        //        }

        //    } while (opcion != 0);

        //    Console.WriteLine("\n--------------------------");
        //    Console.WriteLine("Presiona cualquier tecla para salir...");
        //    Console.ReadKey();
        //}
    }
}
