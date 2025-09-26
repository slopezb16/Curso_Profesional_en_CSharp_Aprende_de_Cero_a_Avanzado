using System;
using System.Collections;

namespace Coleccion_Hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            decimal precio = 0;
            string producto = "";
            bool encontrado = false;

            // Declaramos nuestro hashtable
            Hashtable miTabla = new Hashtable();

            do
            {
                Console.WriteLine("===== MENÚ HASH TABLE =====");
                Console.WriteLine("1. Agregar elemento (Add)");
                Console.WriteLine("2. Obtener elemento por clave (object)");
                Console.WriteLine("3. Limpiar tabla (Clear)");
                Console.WriteLine("4. Verificar si existe clave (ContainsKey)");
                Console.WriteLine("5. Verificar si existe valor (ContainsValue)");
                Console.WriteLine("6. Eliminar elemento (Remove)");
                Console.WriteLine("7. Mostrar todos los elementos");
                Console.WriteLine("8. Salir");
                Console.Write("👉 Escoge una opción: ");

                // Control de error si ingresan algo no válido
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("⚠️ Opción inválida, intenta de nuevo.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingresa nombre del producto: ");
                        producto = Console.ReadLine();

                        if (miTabla.ContainsKey(producto))
                        {
                            Console.WriteLine("⚠️ Ya existe un producto con ese nombre.");
                        }
                        else
                        {
                            Console.Write("Ingresa precio del producto: ");
                            if (decimal.TryParse(Console.ReadLine(), out precio))
                            {
                                miTabla.Add(producto, precio);
                                Console.WriteLine($"✅ Producto '{producto}' agregado con precio {precio:C}.");
                            }
                            else
                            {
                                Console.WriteLine("⚠️ Precio inválido.");
                            }
                        }
                        break;

                    case 2:
                        // Sensilla
                        object valorGuardado = miTabla[producto];
                        Console.WriteLine($"📌 El precio de '{producto}' es: {miTabla[producto]:C}");
                        // Mas Completa
                        //Console.Write("Ingresa el nombre del producto: ");
                        //producto = Console.ReadLine();
                        //if (miTabla.ContainsKey(producto))
                        //{
                        //    // 1️⃣ Recuperamos el valor como object (tal cual lo hace el Hashtable)
                        //    object valorGuardado = miTabla[producto];

                        //    // 2️⃣ Lo mostramos directamente como object
                        //    Console.WriteLine($"📌 El valor guardado como object es: {valorGuardado}");

                        //    // 3️⃣ Si sabemos que es un decimal, podemos mapearlo/castearlo
                        //    precio = (decimal)valorGuardado;

                        //    // 4️⃣ Ahora lo mostramos ya convertido con formato de moneda
                        //    Console.WriteLine($"💲 El precio de '{producto}' es: {precio:C}");

                        //    Console.WriteLine("Uso 2 ⬇️");

                        //    Console.WriteLine($"📌 El precio de '{producto}' es: {miTabla[producto]:C}");
                        //}
                        //else
                        //{
                        //    Console.WriteLine("⚠️ Producto no encontrado.");
                        //}
                        break;

                    case 3:
                        miTabla.Clear();
                        Console.WriteLine("🗑️ Todos los elementos fueron eliminados.");
                        break;

                    case 4:
                        Console.Write("Ingresa el nombre a verificar: ");
                        producto = Console.ReadLine();
                        encontrado = miTabla.ContainsKey(producto);
                        Console.WriteLine($"🔎 Clave encontrada: {encontrado}");
                        break;

                    case 5:
                        Console.Write("Ingresa el precio a verificar: ");
                        if (decimal.TryParse(Console.ReadLine(), out precio))
                        {
                            encontrado = miTabla.ContainsValue(precio);
                            Console.WriteLine($"🔎 Precio encontrado: {encontrado}");
                        }
                        else
                        {
                            Console.WriteLine("⚠️ Precio inválido.");
                        }
                        break;

                    case 6:
                        // Sensilla
                        miTabla.Remove(producto);
                        Console.WriteLine($"🗑️ Producto '{producto}' eliminado.");
                        // Mas Completa
                        //Console.Write("Ingresa el nombre del producto a eliminar: ");
                        //producto = Console.ReadLine();
                        //if (miTabla.ContainsKey(producto))
                        //{
                        //    miTabla.Remove(producto);
                        //    Console.WriteLine($"🗑️ Producto '{producto}' eliminado.");
                        //}
                        //else
                        //{
                        //    Console.WriteLine("⚠️ No existe un producto con ese nombre.");
                        //}
                        break;

                    case 7:
                        Console.WriteLine("\n📋 Elementos en la tabla:");
                        foreach (DictionaryEntry item in miTabla)
                        {
                            Console.WriteLine($"➡️ Producto: {item.Key}, Precio: {item.Value:C}");
                        }
                        if (miTabla.Count == 0)
                        {
                            Console.WriteLine("⚠️ No hay elementos en la tabla.");
                        }
                        Console.WriteLine("_________________________\n");
                        break;

                    case 8:
                        Console.WriteLine("👋 Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("⚠️ Opción inválida.");
                        break;
                }

                // mostrar la información del Stack 
                //Console.WriteLine("");
                //foreach (DictionaryEntry tabla in miTabla)
                //{
                //    Console.WriteLine("key = {0}, value= {1}", tabla.Key, tabla.Value);
                //    Console.WriteLine("");
                //    Console.WriteLine(" _____");

                //}

            } while (opcion != 8);

            Console.ReadKey();
        }
    }
}
