using System;

namespace ArraysJagged
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Clase 46

            Console.WriteLine("\n=== Arreglos - Arrays ===");

            /* Tipos de arrays
             * Arrays de 1 dimensión
             * Arrays de 2 dimensiones 
             * Arrays de tipo Jagged - estamos en esta
             * Arrays con parámetros a métodos
             */

            Console.Write("Ingrese la cantidad de salones: ");
            int salones = Convert.ToInt32(Console.ReadLine());

            // Crear arreglo jagged (arreglo de arreglos)
            float[][] calificaciones = new float[salones][];

            // 1. Ingresar calificaciones
            IngresarCalificaciones(calificaciones, salones);

            // 2. Mostrar calificaciones
            MostrarCalificaciones(calificaciones);

            // 3. Calcular y mostrar resultados
            CalcularResultados(calificaciones);

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        // Método para ingresar calificaciones
        static void 
            IngresarCalificaciones(float[][] calificaciones, int salones)
        {
            for (int i = 0; i < salones; i++)
            {
                Console.WriteLine("");
                Console.Write($"** Ingrese la cantidad de alumnos en el salón {i + 1}: ");
                int cantidad = Convert.ToInt32(Console.ReadLine());

                calificaciones[i] = new float[cantidad];

                Console.WriteLine($"\n--- Ingresando notas del salón {i + 1} ---");
                for (int j = 0; j < cantidad; j++)
                {
                    Console.Write($"Ingrese la nota del alumno {j + 1}: ");
                    calificaciones[i][j] = Convert.ToSingle(Console.ReadLine());
                }
            }
        }

        // Método para mostrar calificaciones
        static void MostrarCalificaciones(float[][] calificaciones)
        {
            Console.WriteLine("\n=== Calificaciones ingresadas ===");
            for (int i = 0; i < calificaciones.Length; i++)
            {
                Console.Write($"Salón {i + 1}: ");
                for (int j = 0; j < calificaciones[i].Length; j++)
                {
                    Console.Write(calificaciones[i][j] + " - ");
                }
                Console.WriteLine();
            }
        }

        // Método para calcular resultados
        static void CalcularResultados(float[][] calificaciones)
        {
            float suma = 0.0f;
            float minima = 10.0f;
            float maxima = 0.0f;

            int salonMin = 0, alumnoMin = 0;
            int salonMax = 0, alumnoMax = 0;

            int totalNotas = 0;

            for (int i = 0; i < calificaciones.Length; i++)
            {
                for (int j = 0; j < calificaciones[i].Length; j++)
                {
                    float nota = calificaciones[i][j];
                    suma += nota;
                    totalNotas++;

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

            float promedio = suma / totalNotas;

            Console.WriteLine("\n=== Resultados ===");
            Console.WriteLine($"Suma de calificaciones: {suma}");
            Console.WriteLine($"Promedio general: {promedio}");
            Console.WriteLine($"Calificación mínima: {minima} (Salón {salonMin}, Alumno {alumnoMin})");
            Console.WriteLine($"Calificación máxima: {maxima} (Salón {salonMax}, Alumno {alumnoMax})");
        }
    }
}