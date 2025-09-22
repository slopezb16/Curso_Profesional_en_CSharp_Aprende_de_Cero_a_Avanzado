using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos1
{
    internal class EjecutarSoloCodigo
    {
        static void Main1(string[] args)
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

            switch (opcion)
            {
                case 1:
                    Suma();
                    break;
                case 2:
                    Resta();
                    break;
                case 3:
                    Multiplicacion();
                    break;
                case 4:
                    Division();
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        // Método de Suma
        static void Suma()
        {
            Console.WriteLine("Ingrese el primer número:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            double b = Convert.ToDouble(Console.ReadLine());

            double resultado = a + b;
            Console.WriteLine($"La suma es: {resultado}");
        }

        // Método de Resta
        static void Resta()
        {
            Console.WriteLine("Ingrese el primer número:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            double b = Convert.ToDouble(Console.ReadLine());

            double resultado = a - b;
            Console.WriteLine($"La resta es: {resultado}");
        }

        // Método de Multiplicación
        static void Multiplicacion()
        {
            Console.WriteLine("Ingrese el primer número:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            double b = Convert.ToDouble(Console.ReadLine());

            double resultado = a * b;
            Console.WriteLine($"La multiplicación es: {resultado}");
        }

        // Método de División
        static void Division()
        {
            Console.WriteLine("Ingrese el primer número:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            double b = Convert.ToDouble(Console.ReadLine());

            if (b != 0)
            {
                double resultado = a / b;
                Console.WriteLine($"La división es: {resultado}");
            }
            else
            {
                Console.WriteLine("Error: No se puede dividir entre 0.");
            }
        }
    }
}
