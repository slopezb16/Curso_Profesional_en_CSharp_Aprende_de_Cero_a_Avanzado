using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Ejercicios12
    {
        static void Main12(string[] args)
        {
            Console.WriteLine("Programa que determina si un número es positivo o negativo\n");

            // Solicitar número al usuario
            Console.Write("Ingresa un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Verificar si es positivo o negativo
            if (numero > 0)
            {
                Console.WriteLine($"✅ El número {numero} es positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine($"❌ El número {numero} es negativo.");
            }
            else
            {
                Console.WriteLine("El número ingresado es cero (0), no es positivo ni negativo.");
            }

            // Esperar antes de salir
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
