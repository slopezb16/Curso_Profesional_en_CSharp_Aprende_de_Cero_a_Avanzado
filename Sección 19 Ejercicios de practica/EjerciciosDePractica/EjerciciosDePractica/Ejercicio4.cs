using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePractica
{
    internal class Ejercicio4
    {
        static void Main4(string[] args)
        {
            // Clase 87
            Console.WriteLine("\n=== Ejercicio: Operaciones con un número en C# ===");

            Console.WriteLine("Ingrese un número:");
            double numero = Convert.ToDouble(Console.ReadLine());

            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine($"\nNúmero ingresado: {numero}");
                Console.WriteLine("Seleccione la operación que desea realizar:");
                Console.WriteLine("1. Valor absoluto");
                Console.WriteLine("2. Potencia (número^2)");
                Console.WriteLine("3. Potencia (número^3)");
                Console.WriteLine("4. Raíz cuadrada");
                Console.WriteLine("5. Seno (en radianes)");
                Console.WriteLine("6. Coseno (en radianes)");
                Console.WriteLine("7. Número máximo con 100");
                Console.WriteLine("8. Número mínimo con 100");
                Console.WriteLine("9. Parte entera (Truncar)");
                Console.WriteLine("10. Redondear (π * número)");
                Console.WriteLine("0. Salir");
                Console.Write("\nOpción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"Valor absoluto: {Math.Abs(numero)}");
                        break;
                    case 2:
                        Console.WriteLine($"Potencia (número^2): {Math.Pow(numero, 2)}");
                        break;
                    case 3:
                        Console.WriteLine($"Potencia (número^3): {Math.Pow(numero, 3)}");
                        break;
                    case 4:
                        Console.WriteLine($"Raíz cuadrada: {Math.Sqrt(numero):F2}");
                        break;
                    case 5:
                        Console.WriteLine($"Seno: {Math.Sin(numero):F4}");
                        break;
                    case 6:
                        Console.WriteLine($"Coseno: {Math.Cos(numero):F4}");
                        break;
                    case 7:
                        Console.WriteLine($"Número máximo entre {numero} y 100: {Math.Max(numero, 100)}");
                        break;
                    case 8:
                        Console.WriteLine($"Número mínimo entre {numero} y 100: {Math.Min(numero, 100)}");
                        break;
                    case 9:
                        Console.WriteLine($"Parte entera (truncada): {Math.Truncate(numero)}");
                        break;
                    case 10:
                        Console.WriteLine($"Número redondeado (π * número): {Math.Round(Math.PI * numero, 2)}");
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

                if (opcion != 0)
                {
                    Console.WriteLine("\nPresiona cualquier tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 0);
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("\n=== Ejercicio: Operaciones avanzadas con un número en C# ===");

        //    Console.WriteLine("Ingrese un número:");
        //    double numero = Convert.ToDouble(Console.ReadLine());

        //    int opcion;
        //    do
        //    {
        //        Console.Clear();
        //        Console.WriteLine($"\nNúmero ingresado: {numero}");
        //        Console.WriteLine("Seleccione la operación que desea realizar:");
        //        Console.WriteLine("1. Valor absoluto");
        //        Console.WriteLine("2. Potencia (número^x)");
        //        Console.WriteLine("3. Raíz n-ésima");
        //        Console.WriteLine("4. Seno (en radianes)");
        //        Console.WriteLine("5. Coseno (en radianes)");
        //        Console.WriteLine("6. Número máximo con otro valor");
        //        Console.WriteLine("7. Número mínimo con otro valor");
        //        Console.WriteLine("8. Parte entera (Truncar)");
        //        Console.WriteLine("9. Redondear (a x decimales)");
        //        Console.WriteLine("0. Salir");
        //        Console.Write("\nOpción: ");

        //        opcion = int.Parse(Console.ReadLine());

        //        switch (opcion)
        //        {
        //            case 1:
        //                Console.WriteLine($"Valor absoluto: {Math.Abs(numero)}");
        //                break;

        //            case 2: // Potencia
        //                Console.Write("Ingrese el exponente: ");
        //                double exp = Convert.ToDouble(Console.ReadLine());
        //                Console.WriteLine($"{numero}^{exp} = {Math.Pow(numero, exp)}");
        //                break;

        //            case 3: // Raíz n-ésima
        //                Console.Write("Ingrese el índice de la raíz (ej: 2 para raíz cuadrada, 3 para cúbica): ");
        //                double indice = Convert.ToDouble(Console.ReadLine());
        //                if (indice != 0)
        //                {
        //                    Console.WriteLine($"Raíz {indice}-ésima de {numero}: {Math.Pow(numero, 1.0 / indice):F4}");
        //                }
        //                else
        //                {
        //                    Console.WriteLine("El índice no puede ser 0.");
        //                }
        //                break;

        //            case 4:
        //                Console.WriteLine($"Seno: {Math.Sin(numero):F4}");
        //                break;

        //            case 5:
        //                Console.WriteLine($"Coseno: {Math.Cos(numero):F4}");
        //                break;

        //            case 6: // Máximo
        //                Console.Write("Ingrese otro número para comparar: ");
        //                double otroMax = Convert.ToDouble(Console.ReadLine());
        //                Console.WriteLine($"Máximo entre {numero} y {otroMax}: {Math.Max(numero, otroMax)}");
        //                break;

        //            case 7: // Mínimo
        //                Console.Write("Ingrese otro número para comparar: ");
        //                double otroMin = Convert.ToDouble(Console.ReadLine());
        //                Console.WriteLine($"Mínimo entre {numero} y {otroMin}: {Math.Min(numero, otroMin)}");
        //                break;

        //            case 8:
        //                Console.WriteLine($"Parte entera (truncada): {Math.Truncate(numero)}");
        //                break;

        //            case 9: // Redondear con decimales
        //                Console.Write("¿A cuántos decimales quieres redondear?: ");
        //                int decimales = int.Parse(Console.ReadLine());
        //                Console.WriteLine($"Número redondeado: {Math.Round(numero, decimales)}");
        //                break;

        //            case 0:
        //                Console.WriteLine("Saliendo del programa...");
        //                break;

        //            default:
        //                Console.WriteLine("Opción no válida. Intente de nuevo.");
        //                break;
        //        }

        //        if (opcion != 0)
        //        {
        //            Console.WriteLine("\nPresiona cualquier tecla para continuar...");
        //            Console.ReadKey();
        //        }

        //    } while (opcion != 0);
        //}
    }
}
