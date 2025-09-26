using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coleccion_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Ejemplo dinámico de Queue (Cola) ===\n");

            int opcion;
            int numero;
            bool encontrado;

            // Crear la cola
            Queue miCola = new Queue();

            do
            {
                // Menú de opciones
                Console.WriteLine("\n--- Menú de opciones ---");
                Console.WriteLine("1. Enqueue (Agregar)");
                Console.WriteLine("2. Dequeue (Eliminar primero)");
                Console.WriteLine("3. Clear (Vaciar cola)");
                Console.WriteLine("4. Contains (Buscar elemento)");
                Console.WriteLine("5. Mostrar cola");
                Console.WriteLine("6. Peek (Ver el primero)");
                Console.WriteLine("7. Salir");
                Console.Write("👉 Escoge una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("⚠️ Ingresa un número válido.");
                    continue;
                }

                switch (opcion)
                {
                    case 1: // Enqueue
                        Console.Write("Ingrese un número para agregar: ");
                        if (int.TryParse(Console.ReadLine(), out numero))
                        {
                            miCola.Enqueue(numero);
                            Console.WriteLine($"✅ Se agregó {numero} a la cola.");
                        }
                        else
                        {
                            Console.WriteLine("⚠️ Valor no válido.");
                        }
                        break;

                    case 2: // Dequeue
                        if (miCola.Count > 0)
                        {
                            numero = (int)miCola.Dequeue();
                            Console.WriteLine($"✅ Se eliminó {numero} de la cola.");
                        }
                        else
                        {
                            Console.WriteLine("⚠️ La cola está vacía.");
                        }
                        break;

                    case 3: // Clear
                        miCola.Clear();
                        Console.WriteLine("✅ La cola fue vaciada.");
                        break;

                    case 4: // Contains
                        Console.Write("Ingrese un número para buscar: ");
                        if (int.TryParse(Console.ReadLine(), out numero))
                        {
                            encontrado = miCola.Contains(numero);
                            Console.WriteLine(encontrado
                                ? $"✅ El número {numero} está en la cola."
                                : $"❌ El número {numero} no se encuentra en la cola.");
                        }
                        else
                        {
                            Console.WriteLine("⚠️ Valor no válido.");
                        }
                        break;

                    case 5: // Mostrar cola
                        Console.WriteLine("👉 Elementos en la cola:");
                        Imprimir(miCola);
                        break;

                    case 6: // Peek
                        if (miCola.Count > 0)
                        {
                            Console.WriteLine($"👀 El primer elemento es: {miCola.Peek()}");
                        }
                        else
                        {
                            Console.WriteLine("⚠️ La cola está vacía.");
                        }
                        break;

                    case 7: // Salir
                        Console.WriteLine("👋 Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("⚠️ Opción no válida.");
                        break;
                }

                // Mostrar info de la cola
                Console.WriteLine("La cola tiene {0} elementos.", miCola.Count);

            } while (opcion != 7);

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        private static void Imprimir(Queue cola)
        {
            if (cola.Count == 0)
            {
                Console.WriteLine("(Cola vacía)");
                return;
            }

            foreach (var item in cola)
            {
                Console.WriteLine(item);
            }
        }
    }
}
