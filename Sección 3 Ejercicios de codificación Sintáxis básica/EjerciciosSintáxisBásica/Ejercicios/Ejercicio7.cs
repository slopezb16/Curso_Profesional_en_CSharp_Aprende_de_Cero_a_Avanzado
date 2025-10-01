using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Ejercicio7
    {
        static void Main7(string[] args)
        {
            // Solicitar el primer número
            Console.Write("Ingresa el primer número entero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            // Solicitar el segundo número
            Console.Write("Ingresa el segundo número entero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Realizar la suma
            int suma = num1 + num2;

            // Imprimir resultado
            Console.WriteLine($"La suma de {num1} + {num2} es: {suma}");

            // Esperar tecla para cerrar
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
