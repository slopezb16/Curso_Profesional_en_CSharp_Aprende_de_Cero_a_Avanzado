using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Ejercicios10
    {
        static void Main10(string[] args)
        {
            Console.WriteLine("Cálculo de la edad a partir de la fecha de nacimiento\n");

            // Solicitar el año de nacimiento
            Console.Write("Ingresa tu año de nacimiento (ejemplo: 1995): ");
            int anioNacimiento = Convert.ToInt32(Console.ReadLine());

            // Obtener el año actual con DateTime
            int anioActual = DateTime.Now.Year;

            // Calcular la edad
            int edad = anioActual - anioNacimiento;

            // Mostrar el resultado
            Console.WriteLine($"\nTu edad actual es: {edad} años");

            // Esperar tecla antes de salir
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
