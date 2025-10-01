using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosColecciones
{
    internal class Ejercicio2
    {
        static void Main2()
        {
            ArrayList numeros = new ArrayList { 15, 3, 9, 1, 20 };

            Console.WriteLine("Lista original:");
            foreach (int n in numeros)
            {
                Console.WriteLine(n);
            }

            // Ordenamos
            numeros.Sort();

            Console.WriteLine("\nLista ordenada:");
            foreach (int n in numeros)
            {
                Console.WriteLine(n);
            }
        }
    }
}
