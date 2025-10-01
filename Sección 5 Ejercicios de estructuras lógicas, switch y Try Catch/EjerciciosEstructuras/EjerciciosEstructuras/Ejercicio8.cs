using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosEstructuras
{
    internal class Ejercicio8
    {
        static void Main8()
        {
            Console.WriteLine("=== Calculadora con Switch ===");

            // Solicitar números
            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Solicitar operación
            Console.Write("Ingrese la operación (+, -, *, /): ");
            char operacion = Convert.ToChar(Console.ReadLine());

            double resultado;

            switch (operacion)
            {
                case '+':
                    resultado = num1 + num2;
                    Console.WriteLine($"La suma es: {resultado}");
                    break;

                case '-':
                    resultado = num1 - num2;
                    Console.WriteLine($"La resta es: {resultado}");
                    break;

                case '*':
                    resultado = num1 * num2;
                    Console.WriteLine($"La multiplicación es: {resultado}");
                    break;

                case '/':
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"La división es: {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir entre 0.");
                    }
                    break;

                default:
                    Console.WriteLine("Operación inválida. Debe ser +, -, * o /.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
