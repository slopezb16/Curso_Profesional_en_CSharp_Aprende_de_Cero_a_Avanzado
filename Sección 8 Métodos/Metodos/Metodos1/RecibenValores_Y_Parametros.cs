using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos1
{
    internal class RecibenValores_Y_Parametros
    {
        static void Main4(string[] args)
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
                    RecibirValores_Y_Suma();
                    break;
                case 2:
                    RecibirValores_Y_Resta();
                    break;
                case 3:
                    RecibirValores_Y_Multiplicacion();
                    break;
                case 4:
                    RecibirValores_Y_Division();
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        // Métodos que reciben valores y luego llaman al cálculo

        static void RecibirValores_Y_Suma()
        {
            Console.WriteLine("Ingrese el primer número:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            double b = Convert.ToDouble(Console.ReadLine());

            double resultado = Suma(a, b);
            Console.WriteLine($"La suma es: {resultado}");
        }

        static void RecibirValores_Y_Resta()
        {
            Console.WriteLine("Ingrese el primer número:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            double b = Convert.ToDouble(Console.ReadLine());

            double resultado = Resta(a, b);
            Console.WriteLine($"La resta es: {resultado}");
        }

        static void RecibirValores_Y_Multiplicacion()
        {
            Console.WriteLine("Ingrese el primer número:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            double b = Convert.ToDouble(Console.ReadLine());

            double resultado = Multiplicacion(a, b);
            Console.WriteLine($"La multiplicación es: {resultado}");
        }

        static void RecibirValores_Y_Division()
        {
            Console.WriteLine("Ingrese el primer número:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            double b = Convert.ToDouble(Console.ReadLine());

            double resultado = Division(a, b);
            if (!double.IsNaN(resultado))
                Console.WriteLine($"La división es: {resultado}");
        }

        // Métodos de operaciones (reciben parámetros)
        static double Suma(double a, double b) => a + b;
        static double Resta(double a, double b) => a - b;
        static double Multiplicacion(double a, double b) => a * b;
        static double Division(double a, double b)
        {
            if (b != 0)
                return a / b;
            else
            {
                Console.WriteLine("Error: No se puede dividir entre 0.");
                return double.NaN;
            }
        }
    }
}
