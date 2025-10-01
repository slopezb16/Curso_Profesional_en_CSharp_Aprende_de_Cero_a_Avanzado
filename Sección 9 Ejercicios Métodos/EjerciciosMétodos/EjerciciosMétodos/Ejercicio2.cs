using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosMétodos
{
    internal class Ejercicio2
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("===== CÁLCULO FACTORIAL =====");

            Console.Write("Ingrese un número entero no negativo: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("Error: No se puede calcular el factorial de un número negativo.");
            }
            else
            {
                long resultado = CalcularFactorial(numero);
                Console.WriteLine($"El factorial de {numero} es: {resultado}");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        // Método secundario que calcula el factorial
        static long CalcularFactorial(int n)
        {
            long factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
