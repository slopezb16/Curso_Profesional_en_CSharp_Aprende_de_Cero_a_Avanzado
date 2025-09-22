using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos1
{
    internal class Conbinado
    {
        static void Main5(string[] args)
        {
            int opcion;

            Console.WriteLine("===== MENÚ DE OPERACIONES =====");
            Console.WriteLine("1. Suma (void)");
            Console.WriteLine("2. Resta (retorna)");
            Console.WriteLine("3. Multiplicación (recibe parámetros)");
            Console.WriteLine("4. División (recibe valores y parámetros)");
            Console.WriteLine("Escoge una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            Console.Clear(); // Limpia la pantalla para más orden

            switch (opcion)
            {
                case 1:
                    Suma(); // void
                    break;
                case 2:
                    {
                        double resultado = Resta(); // retorna
                        Console.WriteLine($"La resta es: {resultado}");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Ingrese el primer número:");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número:");
                        double b = Convert.ToDouble(Console.ReadLine());

                        double resultado = Multiplicacion(a, b); // recibe parámetros
                        Console.WriteLine($"La multiplicación es: {resultado}");
                        break;
                    }
                case 4:
                    RecibirValores_Y_Division(); // recibe valores y parámetros
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        // ----------- MÉTODOS -----------

        // 1. Suma → void
        static void Suma()
        {
            Console.WriteLine("Ingrese el primer número:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"La suma es: {a + b}");
        }

        // 2. Resta → retorna valor (sin parámetros, pide datos dentro)
        static double Resta()
        {
            Console.WriteLine("Ingrese el primer número:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            double b = Convert.ToDouble(Console.ReadLine());

            return a - b;
        }

        // 3. Multiplicación → recibe parámetros
        static double Multiplicacion(double a, double b)
        {
            return a * b;
        }

        // 4. División → recibe valores y parámetros
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
