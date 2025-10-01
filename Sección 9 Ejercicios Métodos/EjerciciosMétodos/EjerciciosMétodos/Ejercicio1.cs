using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosMétodos
{
    internal class Ejercicio1
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("===== CALCULADORA BÁSICA =====");

            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Seleccione una operación (+, -, *, /): ");
            ConsoleKeyInfo tecla = Console.ReadKey(); // Captura la tecla
            char operacion = tecla.KeyChar;

            Console.WriteLine(); // Salto de línea para ordenar

            double resultado = 0;

            switch (operacion)
            {
                case '+':
                    resultado = Suma(num1, num2);
                    break;
                case '-':
                    resultado = Resta(num1, num2);
                    break;
                case '*':
                    resultado = Multiplicacion(num1, num2);
                    break;
                case '/':
                    if (num2 != 0)
                        resultado = Division(num1, num2);
                    else
                    {
                        Console.WriteLine("Error: División por cero.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Operación no válida.");
                    return;
            }

            Console.WriteLine($"Resultado: {resultado}");

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        static double Suma(double a, double b) => a + b;
        static double Resta(double a, double b) => a - b;
        static double Multiplicacion(double a, double b) => a * b;
        static double Division(double a, double b) => a / b;
    }
}
