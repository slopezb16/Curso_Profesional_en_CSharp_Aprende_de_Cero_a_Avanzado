using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos1
{
    internal class RegresarValores
    {
        static void Main2(string[] args)
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

            double resultado = 0;

            switch (opcion)
            {
                case 1:
                    resultado = Suma();
                    Console.WriteLine($"La suma es: {resultado}");
                    break;
                case 2:
                    resultado = Resta();
                    Console.WriteLine($"La resta es: {resultado}");
                    break;
                case 3:
                    resultado = Multiplicacion();
                    Console.WriteLine($"La multiplicación es: {resultado}");
                    break;
                case 4:
                    resultado = Division();
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
        static double Suma()
        {
            Console.WriteLine("Ingrese el primer número:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            double b = Convert.ToDouble(Console.ReadLine());

            return a + b;
        }

        // Método de Resta
        static double Resta()
        {
            Console.WriteLine("Ingrese el primer número:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            double b = Convert.ToDouble(Console.ReadLine());

            return a - b;
        }

        // Método de Multiplicación
        static double Multiplicacion()
        {
            Console.WriteLine("Ingrese el primer número:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            double b = Convert.ToDouble(Console.ReadLine());

            return a * b;
        }

        // Método de División
        static double Division()
        {
            Console.WriteLine("Ingrese el primer número:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            double b = Convert.ToDouble(Console.ReadLine());

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
