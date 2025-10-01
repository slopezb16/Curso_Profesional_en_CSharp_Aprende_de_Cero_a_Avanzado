using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosMétodos
{
    internal class Ejercicio3
    {
        static void Main3(string[] args)
        {
            Console.WriteLine("===== CÁLCULO DE POTENCIA =====");

            Console.Write("Ingrese la base: ");
            double baseNum = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el exponente (entero): ");
            int exponente = Convert.ToInt32(Console.ReadLine());

            double resultado = CalcularPotencia(baseNum, exponente);

            Console.WriteLine($"{baseNum} ^ {exponente} = {resultado}");

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        // Método que calcula la potencia
        static double CalcularPotencia(double baseNum, int exponente)
        {
            double resultado = 1;

            for (int i = 1; i <= exponente; i++)
            {
                resultado *= baseNum;
            }

            return resultado;
        }
    }
}
