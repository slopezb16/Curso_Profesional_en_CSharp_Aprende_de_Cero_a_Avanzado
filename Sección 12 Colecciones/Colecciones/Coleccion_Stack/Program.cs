using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coleccion_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Clase 53
            Console.WriteLine("=== Ejemplo dinámico de Stack (Pila) ===\n");

            int opcion;
            int numero;
            bool encontrado;

            // Crear la pila
            Stack miPila = new Stack();

            do
            {
                // Menú de opciones
                Console.WriteLine("\n--- Menú de opciones ---");
                Console.WriteLine("1. Push (Agregar)");
                Console.WriteLine("2. Pop (Eliminar último)");
                Console.WriteLine("3. Clear (Vaciar pila)");
                Console.WriteLine("4. Contains (Buscar elemento)");
                Console.WriteLine("5. Mostrar pila");
                Console.WriteLine("6. Salir");
                Console.Write("👉 Escoge una opción: ");

                // Leer opción
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("⚠️ Ingresa un número válido.");
                    continue;
                }

                switch (opcion)
                {
                    case 1: // Push
                        Console.Write("Ingrese un número para agregar: ");
                        if (int.TryParse(Console.ReadLine(), out numero))
                        {
                            miPila.Push(numero);
                            Console.WriteLine($"✅ Se agregó {numero} a la pila.");
                        }
                        else
                        {
                            Console.WriteLine("⚠️ Valor no válido.");
                        }
                        break;

                    case 2: // Pop
                        if (miPila.Count > 0)
                        {
                            numero = (int)miPila.Pop();
                            Console.WriteLine($"✅ Se eliminó {numero} de la pila.");
                        }
                        else
                        {
                            Console.WriteLine("⚠️ La pila está vacía.");
                        }
                        break;

                    case 3: // Clear
                        miPila.Clear();
                        Console.WriteLine("✅ La pila fue vaciada.");
                        break;

                    case 4: // Contains
                        Console.Write("Ingrese un número para buscar: ");
                        if (int.TryParse(Console.ReadLine(), out numero))
                        {
                            encontrado = miPila.Contains(numero);
                            Console.WriteLine(encontrado
                                ? $"✅ El número {numero} está en la pila."
                                : $"❌ El número {numero} no se encuentra en la pila.");
                        }
                        else
                        {
                            Console.WriteLine("⚠️ Valor no válido.");
                        }
                        break;

                    case 5: // Mostrar pila
                        Console.WriteLine("👉 Elementos en la pila:");
                        Imprimir(miPila);
                        break;

                    case 6: // Salir
                        Console.WriteLine("👋 Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("⚠️ Opción no válida. Intente de nuevo.");
                        break;
                }

                // Mostrar la informacion del Stack
                Console.WriteLine("El Stack tiene {0} elementos", miPila.Count);

            } while (opcion != 6);

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
