using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCiclos
{
    internal class Ejercicio2
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("=== Tabla de multiplicar con ciclo for ===\n");

            Console.Write("Ingrese un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nTabla de multiplicar del {0}:", numero);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", numero, i, numero * i);
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
