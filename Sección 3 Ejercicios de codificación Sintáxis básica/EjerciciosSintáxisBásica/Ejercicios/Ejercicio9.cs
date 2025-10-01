using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Ejercicio9
    {
        static void Main9(string[] args)
        {
            Console.WriteLine("Cálculo del área de un triángulo\n");

            // Solicitar la base
            Console.Write("Ingresa la base del triángulo: ");
            double baseTriangulo = Convert.ToDouble(Console.ReadLine());

            // Solicitar la altura
            Console.Write("Ingresa la altura del triángulo: ");
            double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

            // Calcular el área
            double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

            // Mostrar el resultado
            Console.WriteLine($"\nEl área del triángulo es: {areaTriangulo}");

            // Esperar tecla antes de salir
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
