using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EjerciciosCiclos
{
    internal class Ejercicio3
    {
        static void Main3(string[] args)
        {
            Console.WriteLine("=== Cuenta regresiva con ciclo for ===\n");

            Console.Write("Ingrese un número entero para la cuenta regresiva: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nIniciando cuenta regresiva...\n");

            for (int i = numero; i >= 1; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000); // 1 segundo entre cada número
            }

            Console.WriteLine("\n¡Cuenta regresiva finalizada!");

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
