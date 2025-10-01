using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Ejercicios13
    {
        static void Main13(string[] args)
        {
            // Indicar al inicio la contraseña
            Console.WriteLine("La contraseña es: \"secreto123\"\n");

            // Solicitar contraseña
            Console.Write("Ingresa la contraseña: ");
            string entrada = Console.ReadLine();

            // Validar usando if (operador de igualdad)
            if (entrada == "secreto123")
            {
                Console.WriteLine("¡Contraseña correcta! Acceso concedido.");
            }
            else
            {
                Console.WriteLine("Contraseña incorrecta. Acceso denegado.");
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
