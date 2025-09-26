using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coleccion_Stack
{
    internal class Ejemplo1
    {
        static void Main1(string[] args)
        {
            // Clase 53

            Console.WriteLine("=== Ejemplo de Stack (Pila) ===\n");

            // variables
            int opcion = 0;
            int numero = 0;
            bool encontrado = false;

            // Crear la pila
            Stack pila = new Stack();

            // Agregar elementos con Push
            pila.Push(10);
            pila.Push(20);
            pila.Push(30);

            Console.WriteLine("👉 Elementos en la pila:");
            Imprimir(pila);

            // Peek: ver el último elemento agregado
            Console.WriteLine($"\nEl último elemento es: {pila.Peek()}");

            // Pop: quitar el último elemento
            Console.WriteLine($"\nSacamos un elemento: {pila.Pop()}");

            Console.WriteLine("\n👉 Pila después de usar Pop:");
            Imprimir(pila);

            // Count: cantidad de elementos
            Console.WriteLine($"\nLa pila tiene {pila.Count} elementos.");

            // Vaciar la pila
            pila.Clear();
            Console.WriteLine("\n👉 Pila después de vaciarla:");
            Imprimir(pila);

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        private static void Imprimir(Stack pila)
        {
            if (pila.Count == 0)
            {
                Console.WriteLine("(Pila vacía)");
                return;
            }

            foreach (var item in pila)
            {
                Console.WriteLine(item);
            }
        }
    }
}
