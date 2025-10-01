using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Ejercicio4
    {
        static void Main4(string[] args)
        {
            // Variables
            int num1 = 10;
            int num2 = 2;
            int suma, resta, multiplicacion, division;

            // Operaciones
            suma = num1 + num2;
            resta = num1 - num2;
            multiplicacion = num1 * num2;
            division = num1 / num2;

            // Impresiones en pantalla
            Console.WriteLine("La suma de los números es: " + suma);
            Console.WriteLine("La resta de los números es: " + resta);
            Console.WriteLine("La multiplicacion de los números es: " + multiplicacion);
            Console.WriteLine("La división de los números es: " + division);

            // Finaliza el programa
            Console.WriteLine("\nPresiona cualquier tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
