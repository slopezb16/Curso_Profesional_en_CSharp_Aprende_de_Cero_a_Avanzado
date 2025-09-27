using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadenas_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Clase 62 - Cadenas 3
            Console.WriteLine("\n=== Manejo de Cadenas 3 en C# ===");

            // =======================================
            // 1. Insertar una cadena en otra
            // =======================================
            Console.WriteLine("\n--- Ejemplo Insertar una cadena ---");

            String cadena1 = "Hola como ";
            String cadena2 = "estan";

            // Insertamos "estan" a partir del índice 10
            String resultado = cadena1.Insert(10, cadena2);
            Console.WriteLine("Resultado: " + resultado);

            Console.WriteLine("\n--------------------------");

            // =======================================
            // 2. Encontrar subcadena (posición dentro de otra)
            // =======================================
            Console.WriteLine("\n--- Ejemplo Buscar subcadena con LastIndexOf ---");

            String cadena3 = "Bienvenidos a este curso";
            Console.WriteLine("Cadena original: " + cadena3);

            int indice = cadena3.LastIndexOf("Bienvenidos");
            Console.WriteLine("Índice donde inicia la palabra 'Bienvenidos': " + indice);

            Console.WriteLine("\n--------------------------");

            // =======================================
            // 3. Justificación de cadena (alineación con PadLeft / PadRight)
            // =======================================
            Console.WriteLine("\n--- Ejemplo Justificación de cadena ---");

            String cadena4 = "Hola";
            String justificada = cadena4.PadLeft(10); // Rellena a la izquierda con espacios
            Console.WriteLine("Con PadLeft(10): '" + justificada + "'");

            Console.WriteLine("\n--------------------------");

            // =======================================
            // 4. Eliminar caracteres de una cadena
            // =======================================
            Console.WriteLine("\n--- Ejemplo Eliminar caracteres ---");

            Console.WriteLine("Antes de Remove(19, 5): " + cadena3);

            // Remove elimina desde la posición indicada cierta cantidad de caracteres
            String eliminada = cadena3.Remove(19, 5); // Desde índice 19, eliminar 5 caracteres
            Console.WriteLine("Después de Remove(19, 5): " + eliminada);

            Console.WriteLine("\n--------------------------");

            // =======================================
            // 5. Reemplazar una subcadena por otra
            // =======================================
            Console.WriteLine("\n--- Ejemplo Reemplazar subcadena ---");

            Console.WriteLine("Antes de Replace: " + cadena3);

            String cadena5 = "Adios";
            String reemplazada = cadena3.Replace("Bienvenidos", cadena5);
            Console.WriteLine("Después de Replace: " + reemplazada);

            Console.WriteLine("\n--------------------------");

            // =======================================
            // 6. Convertir mayúsculas y minúsculas
            // =======================================
            Console.WriteLine("\n--- Ejemplo Mayúsculas y Minúsculas ---");

            String mayusculas = cadena5.ToUpper();
            String minusculas = cadena5.ToLower();

            Console.WriteLine("En mayúsculas: " + mayusculas);
            Console.WriteLine("En minúsculas: " + minusculas);

            Console.WriteLine("\n--------------------------");

            // =======================================
            // 7. Podar (quitar espacios al inicio y/o al final)
            // =======================================
            Console.WriteLine("\n--- Ejemplo Trim, TrimStart, TrimEnd ---");

            String cadena6 = "      Hola a todos     ";

            String trimTotal = cadena6.Trim();        // Quita espacios al inicio y final
            String trimInicio = cadena6.TrimStart();  // Quita solo los del inicio
            String trimFinal = cadena6.TrimEnd();     // Quita solo los del final

            Console.WriteLine("Original: '" + cadena6 + "'");
            Console.WriteLine("Trim(): '" + trimTotal + "'");
            Console.WriteLine("TrimStart(): '" + trimInicio + "'");
            Console.WriteLine("TrimEnd(): '" + trimFinal + "'");

            cadena6 = cadena6.Trim();     // Quita solo los del final
            Console.WriteLine("Trim cadena6(): '" + cadena6 + "'");

            Console.WriteLine("\n--------------------------");

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}