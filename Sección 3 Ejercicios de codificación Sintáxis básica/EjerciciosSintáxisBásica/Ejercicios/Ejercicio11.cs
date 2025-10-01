using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Ejercicios11
    {
        static void Main11(string[] args)
        {
            Console.WriteLine("Verificación de mayoría de edad\n");

            // Solicitar la edad
            Console.Write("Ingresa tu edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            // Verificar si es mayor de edad
            if (edad >= 18)
            {
                Console.WriteLine("✅ Eres mayor de edad.");
            }
            else
            {
                Console.WriteLine("❌ Eres menor de edad.");
            }

            // Esperar antes de salir
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
