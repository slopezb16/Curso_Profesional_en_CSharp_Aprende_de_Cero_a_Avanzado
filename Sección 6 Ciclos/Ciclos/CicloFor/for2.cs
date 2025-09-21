using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicloFor
{
    internal class for2
    {
        static void Main2(string[] args)
        {
            // Clase 31

            // Ejemplo 1
            Console.WriteLine("\n=== Ejemplo con ciclo for ===");

            /*
            int n;
            int contador = 0;
            int acumulador = 0;

            for (n = 1; n <= 10; n = n + 1)
            {
                contador = contador + 1;
                acumulador = acumulador + contador;
                Console.WriteLine("N: {0},Contador: {1}, Acumulador: {2}", n, contador, acumulador);
            }

            // Ejemplo 2 - Operadores de incremento y de decremento

            for (n = 1; n <= 10; n = n++)
            {
                contador++;
                acumulador = acumulador + contador;
                Console.WriteLine("N: {0},Contador: {1}, Acumulador: {2}", n, contador, acumulador);
            }
            */

            // Ejemplo 3

            /*
            int n, cantidad;
            float calif;
            float suma = 0.0f;
            float promedio = 0.0f;

            Console.Write("¿Cuántas alumnos desea ingresar? ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            for (n = 1; n <= cantidad; n++)
            {
                Console.Write("Ingrese calificaciones de los alumnos ");

                Console.Write($"Ingrese la calificación del alumno: {n}: ");
                calif = Convert.ToSingle(Console.ReadLine());
                suma += calif;
            }

            promedio = suma / cantidad;
            Console.WriteLine("El promedio de los {0} alumnos es: {1}", cantidad, promedio);
            */


            // Ejemplo 4

            Console.WriteLine("Calcular el factorial de un número");
            Console.WriteLine("");
            // factoriales
            //5 = 5*4*3*2*1 = 120
            // Conteo regresivo con For

            // Pedir número al usuario
            Console.Write("Ingrese un número entero positivo: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Validar que el número no sea negativo
            if (numero < 0)
            {
                Console.WriteLine("Error: El número debe ser mayor o igual a cero.");
            }
            else
            {
                long factorial = 1;

                // Ciclo For en conteo regresivo
                for (int i = numero; i >= 1; i--)
                {
                    factorial *= i;
                }

                Console.WriteLine($"El factorial de {numero} es: {factorial}");
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
