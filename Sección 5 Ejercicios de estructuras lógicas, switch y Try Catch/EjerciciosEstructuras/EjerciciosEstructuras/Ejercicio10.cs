using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosEstructuras
{
    internal class Ejercicio10
    {
        static void Main10()
        {
            Console.WriteLine("=== División de Números con Try-Catch ===");

            try
            {
                // Solicitar primer número (numerador)
                Console.Write("Ingrese el numerador: ");
                double numerador = Convert.ToDouble(Console.ReadLine());

                // Validar si el numerador es cero
                if (numerador == 0)
                {
                    Console.WriteLine("Error: No se puede dividir por cero.");
                }
                else
                {
                    // Solicitar segundo número (denominador)
                    Console.Write("Ingrese el denominador: ");
                    double denominador = Convert.ToDouble(Console.ReadLine());

                    // Validar que el denominador no sea cero
                    if (denominador == 0)
                    {
                        Console.WriteLine("Error: No se puede dividir entre cero.");
                    }
                    else
                    {
                        double resultado = numerador / denominador;

                        // Validar que el resultado sea mayor a 0.1
                        if (resultado <= 0.1)
                        {
                            Console.WriteLine("Error: El resultado de la división debe ser mayor a 0.1");
                        }
                        else
                        {
                            Console.WriteLine($"El resultado de {numerador} / {denominador} es = {resultado}");
                        }
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Entrada inválida, asegúrate de ingresar números.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inesperado: {0}", ex.Message);
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
