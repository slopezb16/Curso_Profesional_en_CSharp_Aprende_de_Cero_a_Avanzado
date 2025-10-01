using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCadenas
{
    internal class Ejercicio1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Ejercicio 1: Contador de Caracteres ===");

            // Pedir cadena al usuario
            Console.Write("Ingrese una cadena de texto: ");
            String texto = Console.ReadLine();

            // Usar la propiedad Length para contar caracteres
            int cantidad = texto.Length;

            Console.WriteLine($"La cadena ingresada tiene {cantidad} caracteres.");
        }
    }
}
