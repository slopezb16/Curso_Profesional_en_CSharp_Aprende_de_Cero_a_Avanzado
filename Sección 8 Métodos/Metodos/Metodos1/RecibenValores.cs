using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos1
{
    internal class RecibenValores
    {
        static void Main3(string[] args)
        {
            int opcion;

            Console.WriteLine("===== MENÚ DE OPERACIONES =====");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("Escoge una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            Console.Clear(); // Limpia la pantalla para más orden

            Console.WriteLine("Ingrese el primer número:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            double b = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;

            switch (opcion)
            {
                case 1:
                    resultado = Suma(a, b);
                    Console.WriteLine($"La suma es: {resultado}");
                    break;
                case 2:
                    resultado = Resta(a, b);
                    Console.WriteLine($"La resta es: {resultado}");
                    break;
                case 3:
                    resultado = Multiplicacion(a, b);
                    Console.WriteLine($"La multiplicación es: {resultado}");
                    break;
                case 4:
                    resultado = Division(a, b);
                    if (!double.IsNaN(resultado)) // validación de división por cero
                        Console.WriteLine($"La división es: {resultado}");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        // Método de Suma
        static double Suma(double a, double b)
        {
            return a + b;
        }

        // Método de Resta
        static double Resta(double a, double b)
        {
            return a - b;
        }

        // Método de Multiplicación
        static double Multiplicacion(double a, double b)
        {
            return a * b;
        }

        // Método de División
        static double Division(double a, double b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                Console.WriteLine("Error: No se puede dividir entre 0.");
                return double.NaN; // valor especial para indicar error
            }
        }
    }
}
