using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePractica
{
    internal class Ejercicio1
    {
        // Invertir número de 2 cifras
        static void Main1(string[] args)
        {
            // Clase 84
            Console.WriteLine("\n=== Ejercicio Invertir número en C# ===");

            int numero, div, residuo, numAuxiliar;

            Console.WriteLine("Ingrese un número de 2 cifras:");
            numero = int.Parse(Console.ReadLine());

            div = numero / 10;       // Parte entera de las decenas
            residuo = numero % 10;   // Parte de las unidades

            numAuxiliar = (residuo * 10) + div;  // Construcción invertida
            Console.WriteLine("El número invertido es: {0}", numAuxiliar);

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
        //        int residuo = numero % 10;          // Última cifra
        //        invertido = (invertido * 10) + residuo; // Agregarla al invertido
        //        numero /= 10;                       // Reducir el número
        //    }

        //    Console.WriteLine("El número {0} invertido es: {1}", numeroOriginal, invertido);

        //    Console.WriteLine("\n--------------------------");
        //    Console.WriteLine("\nPresiona cualquier tecla para salir...");
        //    Console.ReadKey();
        //}
    }
}
