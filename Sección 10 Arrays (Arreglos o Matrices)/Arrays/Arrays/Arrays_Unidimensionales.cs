using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Arrays_Unidimensionales
    {
        static void Main1(string[] args)
        {
            // Clase 42 y 43

            Console.WriteLine("\n=== Arreglos - Arrays ===");

            /* Tipos de arrays
             * Arrays de 1 dimencion - estamos en esta
             * Arrays de 2 dimenciones
             * Arrays de tipo Jagged
             * Arrays con parametros a metodos
             */

            /* Calificaciones de un colegio */

            // Ejemplo 1: Array de 1 dimensión
            Console.WriteLine("\n--- Array de 1 dimensión ---");

            Console.Write("Ingrese la cantidad de alumnos: ");
            int cantidad = int.Parse(Console.ReadLine());

            float[] calificaciones = new float[cantidad]; // array de notas
            float suma = 0.0f;
            float promedio = 0.0f;
            float minima = 10.0f;
            float maxima = 0.0f;

            // Pedir datos al usuario - Calificación de los alumnos 
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"Ingrese la calificación del alumno {i + 1}: ");
                float nota = float.Parse(Console.ReadLine());

                calificaciones[i] = nota;
                suma += nota;

                if (nota < minima)
                    minima = nota;

                if (nota > maxima)
                    maxima = nota;
            }

            promedio = suma / cantidad;

            // Mostrar resultados
            Console.WriteLine("\n=== Resultados ===");
            Console.WriteLine("Calificaciones ingresadas: ");
            foreach (float nota in calificaciones)
            {
                Console.Write(nota + " - ");
            }

            Console.WriteLine($"\nSuma de calificaciones: {suma}");
            Console.WriteLine($"Promedio: {promedio}");
            Console.WriteLine($"Calificación mínima: {minima}");
            Console.WriteLine($"Calificación máxima: {maxima}");

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
