using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePractica
{
    internal class Ejercicio2
    {
        // Invertir número de 3 cifras
        static void Main2(string[] args)
        {
            // Clase 85
            Console.WriteLine("\n=== Ejercicio Invertir número en C# ===");

            int numero, centenas, decenas, unidades, numInvertido;

            Console.WriteLine("Ingrese un número de 3 cifras:");
            numero = int.Parse(Console.ReadLine());

            centenas = numero / 100;           // Parte entera de las centenas
            decenas = (numero / 10) % 10;      // Parte de las decenas
            unidades = numero % 10;            // Parte de las unidades

            numInvertido = (unidades * 100) + (decenas * 10) + centenas;
            Console.WriteLine("El número invertido es: {0}", numInvertido);

            Console.WriteLine("\n--------------------------");
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        //// Invertir número de cualquier cantidad de cifras
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("\n=== Ejercicio Invertir número en C# (Mejorado) ===");

        //    Console.WriteLine("Ingrese un número:");
        //    int numero = int.Parse(Console.ReadLine());
        //    int numeroOriginal = numero;
        //    int invertido = 0;

        //    while (numero > 0)
        //    {
        //        int residuo = numero % 10;
        //        invertido = (invertido * 10) + residuo;
        //        numero /= 10;
        //    }

        //    Console.WriteLine("El número {0} invertido es: {1}", numeroOriginal, invertido);

        //    Console.WriteLine("\n--------------------------");
        //    Console.WriteLine("\nPresiona cualquier tecla para salir...");
        //    Console.ReadKey();
        //}
    }
}
