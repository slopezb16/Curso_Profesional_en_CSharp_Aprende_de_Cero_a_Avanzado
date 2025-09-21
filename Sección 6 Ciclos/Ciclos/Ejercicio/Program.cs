using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            double num1, num2, resultado;
            string respuesta;

            do
            {
                Console.Clear();
                Console.WriteLine("=== Menú de Operaciones Matemáticas ===\n");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Salir\n");

                Console.Write("Selecciona la operación que desees: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 5)
                {
                    Console.WriteLine("Saliendo del programa...");
                    break; // rompe el ciclo si elige salir
                }

                // Pedir números solo si no es la opción salir
                Console.Write("Ingrese primer número: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese segundo número: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                resultado = 0;

                switch (opcion)
                {
                    case 1:
                        resultado = num1 + num2;
                        Console.WriteLine("El resultado de la suma es: " + resultado);
                        break;
                    case 2:
                        resultado = num1 - num2;
                        Console.WriteLine("El resultado de la resta es: " + resultado);
                        break;
                    case 3:
                        resultado = num1 * num2;
                        Console.WriteLine("El resultado de la multiplicación es: " + resultado);
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                            Console.WriteLine("El resultado de la división es: " + resultado);
                        }
                        else
                        {
                            Console.WriteLine("Error: No se puede dividir entre cero.");
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida, intenta nuevamente.");
                        break;
                }

                Console.Write("\n¿Deseas hacer otra operación? (Sí/No): ");
                respuesta = Console.ReadLine().ToLower();

            } while (respuesta == "si" || respuesta == "sí");

            Console.WriteLine("\nGracias por usar el programa. Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }

    }
}
