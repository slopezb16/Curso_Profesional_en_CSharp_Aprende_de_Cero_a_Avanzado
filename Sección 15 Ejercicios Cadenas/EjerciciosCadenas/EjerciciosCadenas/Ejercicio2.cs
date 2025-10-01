using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCadenas
{
    internal class Ejercicio2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Ejercicio 2: Reversión de Cadena ===");

            // Pedir cadena al usuario
            Console.Write("Ingrese una cadena de texto: ");
            String texto = Console.ReadLine();

            // Convertir la cadena a un array de caracteres
            char[] arreglo = texto.ToCharArray();

            // Invertir el array
            Array.Reverse(arreglo);

            // Reconstruir la cadena invertida
            String textoInvertido = new String(arreglo);

            Console.WriteLine($"La cadena invertida es: {textoInvertido}");
        }
    }
}
