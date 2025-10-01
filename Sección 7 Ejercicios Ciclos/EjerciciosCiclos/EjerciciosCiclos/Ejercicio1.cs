using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCiclos
{
    internal class Ejercicio1
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("=== Suma de números pares con ciclo for ===\n");

            Console.Write("Ingrese un número entero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int suma = 0;

            Console.WriteLine("\nLos números del 1 al {0} son:", numero);

            for (int i = 1; i <= numero; i++)
            {
                Console.Write(i + " "); // mostrar todos los números
                if (i % 2 == 0) // validar pares
                {
                    suma += i;
                }
            }

            Console.WriteLine("\n\nLa suma de los números pares entre 1 y {0} es: {1}", numero, suma);

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
