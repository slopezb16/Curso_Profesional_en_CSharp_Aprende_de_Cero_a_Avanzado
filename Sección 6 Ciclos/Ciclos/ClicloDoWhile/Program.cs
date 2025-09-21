using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Clase 34

            // Ejemplo 1
            Console.WriteLine("\n=== Ejemplo con ciclo do while ===");
            Console.WriteLine("");

            Console.WriteLine("Programa carpinteria - Solicitar las conversiones que desea hacer para las medidas");
            Console.WriteLine("");

            string continuar;

            do
            {
                Console.WriteLine("Seleccione una conversión:");
                Console.WriteLine("1. Pies a centímetros");
                Console.WriteLine("2. Centímetros a pies");
                Console.WriteLine("3. Pulgadas a centímetros");
                Console.WriteLine("4. Centímetros a pulgadas");
                Console.Write("Ingrese una opción: ");

                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese la medida en pies: ");
                        double pies = Convert.ToDouble(Console.ReadLine());
                        double cmDesdePies = pies * 30.48;
                        Console.WriteLine("{0} pies equivalen a {1:F2} cm\n", pies, cmDesdePies);
                        break;

                    case 2:
                        Console.Write("Ingrese la medida en centímetros: ");
                        double cm = Convert.ToDouble(Console.ReadLine());
                        double piesDesdeCm = cm / 30.48;
                        Console.WriteLine("{0} cm equivalen a {1:F2} pies\n", cm, piesDesdeCm);
                        break;

                    case 3:
                        Console.Write("Ingrese la medida en pulgadas: ");
                        double pulgadas = Convert.ToDouble(Console.ReadLine());
                        double cmDesdePulgadas = pulgadas * 2.54;
                        Console.WriteLine("{0} pulgadas equivalen a {1:F2} cm\n", pulgadas, cmDesdePulgadas);
                        break;

                    case 4:
                        Console.Write("Ingrese la medida en centímetros: ");
                        double cm2 = Convert.ToDouble(Console.ReadLine());
                        double pulgadasDesdeCm = cm2 / 2.54;
                        Console.WriteLine("{0} cm equivalen a {1:F2} pulgadas\n", cm2, pulgadasDesdeCm);
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.\n");
                        break;
                }

                Console.Write("¿Desea realizar otra conversión? (S/N): ");
                continuar = Console.ReadLine().ToUpper();

            } while (continuar == "S");

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
