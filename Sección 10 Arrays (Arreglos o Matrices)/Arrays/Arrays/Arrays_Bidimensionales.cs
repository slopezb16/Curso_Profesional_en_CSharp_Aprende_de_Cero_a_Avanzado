using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Arrays_Bidimensionales
    {
        static void Main2(string[] args)
        {
            // Clase 44

            Console.WriteLine("\n=== Arreglos - Arrays ===");

            /* Tipos de arrays
             * Arrays de 1 dimencion
             * Arrays de 2 dimenciones - estamos en esta
             * Arrays de tipo Jagged
             * Arrays con parametros a metodos
             */

            /* Calificaciones de un colegio - Cantidad de alumnos mas Salones */
            // Cantidad de Salones -- Las columnas almacenan la cantidad de salones
            // Cantidad de alumnos por salon -- Las filas almacenan la cantidad de estudiantes

            // Ejemplo 1: Array de 2 dimenciones - Bidimensionales
            Console.WriteLine("\n--- Array de 2 dimenciones - Bidimensionales ---");

            Console.Write("Ingrese la cantidad de salones: ");
            int salones = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese la cantidad de alumnos por salón: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            float[,] calificaciones = new float[salones, cantidad];

            // 1. Ingresar calificaciones
            IngresarCalificaciones(calificaciones, salones, cantidad);

            // 2. Mostrar calificaciones
            MostrarCalificaciones(calificaciones, salones, cantidad);

            // 3. Calcular y mostrar resultados
            CalcularResultados(calificaciones, salones, cantidad);

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        // Método para ingresar calificaciones
        static void IngresarCalificaciones(float[,] calificaciones, int salones, int cantidad)
        {
            for (int i = 0; i < salones; i++)
            {
                Console.WriteLine($"\n--- Ingresando notas del salón {i + 1} ---");
                for (int j = 0; j < cantidad; j++)
                {
                    Console.Write($"Ingrese la nota del alumno {j + 1}: ");
                    calificaciones[i, j] = Convert.ToSingle(Console.ReadLine());
                }
            }
        }

        // Método para mostrar calificaciones
        static void MostrarCalificaciones(float[,] calificaciones, int salones, int cantidad)
        {
            Console.WriteLine("\n=== Calificaciones ingresadas ===");
            for (int i = 0; i < salones; i++)
            {
                Console.Write($"Salón {i + 1}: ");
                for (int j = 0; j < cantidad; j++)
                {
                    Console.Write(calificaciones[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // Método para calcular resultados
        static void CalcularResultados(float[,] calificaciones, int salones, int cantidad)
        {
            float suma = 0.0f;
            float minima = 10.0f;
            float maxima = 0.0f;

            int salonMin = 0, alumnoMin = 0;
            int salonMax = 0, alumnoMax = 0;

            for (int i = 0; i < salones; i++)
            {
                for (int j = 0; j < cantidad; j++)
                {
                    float nota = calificaciones[i, j];
                    suma += nota;

                    if (nota < minima)
                    {
                        minima = nota;
                        salonMin = i + 1;
                        alumnoMin = j + 1;
                    }

                    if (nota > maxima)
                    {
                        maxima = nota;
                        salonMax = i + 1;
                        alumnoMax = j + 1;
                    }
                }
            }

            float promedio = suma / (salones * cantidad);

            Console.WriteLine("\n=== Resultados ===");
            Console.WriteLine($"Suma de calificaciones: {suma}");
            Console.WriteLine($"Promedio general: {promedio}");
            Console.WriteLine($"Calificación mínima: {minima} (Salón {salonMin}, Alumno {alumnoMin})");
            Console.WriteLine($"Calificación máxima: {maxima} (Salón {salonMax}, Alumno {alumnoMax})");
        }
    }
}
