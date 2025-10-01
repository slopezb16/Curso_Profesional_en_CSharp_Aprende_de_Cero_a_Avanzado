using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Ejercicio8
    {
        static void Main8(string[] args)
        {
            // Solicitar los 3 valores al usuario
            Console.Write("Ingresa el primer valor: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa el segundo valor: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa el tercer valor: ");
            double valor3 = Convert.ToDouble(Console.ReadLine());

            // Calcular promedio
            double promedio = (valor1 + valor2 + valor3) / 3;

            // Imprimir resultado
            Console.WriteLine($"\nEl promedio de los 3 valores es: {promedio}");

            // Esperar tecla antes de cerrar
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
