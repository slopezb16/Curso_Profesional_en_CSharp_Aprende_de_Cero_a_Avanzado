using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Ejercicio5
    {
        static void Main5(string[] args)
        {
            // Variables
            double celsius, fahrenheit;

            // Pedir datos al usuario
            Console.WriteLine("Conversión de Celsius a Fahrenheit");
            Console.Write("Ingresa los grados Celsius: ");
            celsius = Convert.ToDouble(Console.ReadLine());

            // Conversión
            fahrenheit = (celsius * 9 / 5) + 32;

            // Mostrar resultado
            Console.WriteLine($"Los {celsius}°C equivalen a {fahrenheit}°F");

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
