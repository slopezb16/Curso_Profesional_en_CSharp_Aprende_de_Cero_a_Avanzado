using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraSwitch
{
    internal class EstructuraSwitch
    {
        static void Main3(string[] args)
        {
            // Clase 28 // EstructuraSwitch
            Console.WriteLine("Aplicación que haga operaciones matemáticas");
            Console.WriteLine("");

            float a, b, resultado = 0;
            int opcion;

            // Mostrar el menú de opciones
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("Escoge una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            // Pedir números al usuario
            Console.Write("Ingresa el primer número: ");
            a = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            b = Convert.ToSingle(Console.ReadLine());

            // Usar switch para operaciones
            switch (opcion)
            {
                case 1:
                    resultado = a + b;
                    Console.WriteLine($"La suma de {a} + {b} es = {resultado}");
                    break;
                case 2:
                    resultado = a - b;
                    Console.WriteLine($"La resta de {a} - {b} es = {resultado}");
                    break;
                case 3:
                    resultado = a * b;
                    Console.WriteLine($"La multiplicación de {a} * {b} es = {resultado}");
                    break;
                case 4:
                    if (b != 0)
                    {
                        resultado = a / b;
                        Console.WriteLine($"La división de {a} / {b} es = {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir entre 0");
                    }
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        static void Main4(string[] args)
        {
            // Clase 28 // EstructuraSwitch
            int opcion;
            float a, b, resultado = 0;

            do
            {
                Console.Clear(); // limpia la pantalla en cada vuelta
                Console.WriteLine("=== Calculadora ===");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Salir");
                Console.Write("Escoge una opción: ");

                opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 5)
                {
                    Console.WriteLine("\nSaliendo del programa...");
                    break;
                }

                // Pedir números al usuario
                Console.Write("Ingresa el primer número: ");
                a = Convert.ToSingle(Console.ReadLine());

                Console.Write("Ingresa el segundo número: ");
                b = Convert.ToSingle(Console.ReadLine());

                // Usar switch para operaciones
                switch (opcion)
                {
                    case 1:
                        resultado = a + b;
                        Console.WriteLine($"La suma de {a} + {b} es = {resultado}");
                        break;
                    case 2:
                        resultado = a - b;
                        Console.WriteLine($"La resta de {a} - {b} es = {resultado}");
                        break;
                    case 3:
                        resultado = a * b;
                        Console.WriteLine($"La multiplicación de {a} * {b} es = {resultado}");
                        break;
                    case 4:
                        if (b != 0)
                        {
                            resultado = a / b;
                            Console.WriteLine($"La división de {a} / {b} es = {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("Error: No se puede dividir entre 0");
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }

                Console.WriteLine("\nPresiona una tecla para continuar...");
                Console.ReadKey();

            } while (true);
        }

    }
}
