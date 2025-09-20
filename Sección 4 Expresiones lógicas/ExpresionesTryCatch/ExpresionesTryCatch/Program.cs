using System;

namespace ExpresionesTryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Clase 29
            Console.WriteLine("=== Aplicación Try y Catch ===\n");

            int n1, n2, resultado;

            //// Ejemplo 1 -- Sin try y catch
            //Console.WriteLine("Ejemplo 1: Sin Try-Catch");
            //Console.WriteLine("");

            //Console.Write("Ingrese el primer número: ");
            //n1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Ingrese el segundo número: ");
            //n2 = Convert.ToInt32(Console.ReadLine());

            //resultado = n1 * n2; // Aquí se rompe si n2 = 0a
            ////resultado = n1 / n2; // Aquí se rompe si n2 = 0
            //Console.WriteLine($"El resultado de {n1} * {n2} es: {resultado}\n");

            // Ejemplo 2 -- Con try y catch
            Console.WriteLine("Ejemplo 2: Con Try-Catch");
            Console.WriteLine("");
            try
            {
                Console.Write("Ingrese el primer número: ");
                n1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                n2 = Convert.ToInt32(Console.ReadLine());

                resultado = n1 * n2; // Aquí se rompe si n2 = 0a
                //resultado = n1 / n2;
                Console.WriteLine($"El resultado de {n1} * {n2} es: {resultado}\n");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("");
                Console.WriteLine("Error: No se puede dividir entre 0.");
                Console.WriteLine($"Detalles: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("");
                Console.WriteLine("Error: El valor ingresado no es un número válido.");
                Console.WriteLine($"Detalles: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("");
                Console.WriteLine("Ocurrió un error inesperado.");
                Console.WriteLine($"Detalles: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("");
                Console.WriteLine("\nEl bloque finally siempre se ejecuta (cierre de recursos, limpieza, etc.)");
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}