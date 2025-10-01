using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Ejercicio6
    {
        static void Main6(string[] args)
        {
            // Solicitar nombre
            Console.WriteLine("Ingresa tu nombre: ");
            string nombre = Console.ReadLine();

            // Mostrar el nombre
            Console.WriteLine("Tu nombre es: " + nombre);

            // Esperar tecla para cerrar
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
