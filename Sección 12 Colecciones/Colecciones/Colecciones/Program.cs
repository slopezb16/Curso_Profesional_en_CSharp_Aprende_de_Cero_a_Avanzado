using System;
using System.Collections;

namespace ArraysList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Clase 50
            Console.WriteLine("\n=== Arrays List ===");

            // Ejemplo completo de ArrayList
            Console.WriteLine("\n--- Ejemplo ArrayList ---");

            int indice, cantidad;

            // Crear el ArrayList
            ArrayList datos = new ArrayList();

            // Agregar datos
            datos.Add(7);
            datos.Add(5);
            datos.Add(1);

            Console.WriteLine("Elementos iniciales:");
            Imprimir(datos);

            // Agregar más elementos
            datos.Add(4);
            datos.Add(9);
            datos.Add(3);

            // Agregar un elemento y obtener su índice
            indice = datos.Add(10);

            Console.WriteLine("\nDespués de agregar más elementos:");
            Imprimir(datos);

            Console.WriteLine("El último elemento tiene el índice: {0}", indice);
            Console.WriteLine("\n------------------");

            // Imprimir un elemento en particular
            Console.WriteLine("El valor en el índice 2 es: {0}", datos[2]);
            Console.WriteLine("\n------------------");

            // Modificar un dato en una posición específica
            datos[3] = 20;
            Console.WriteLine("Dato modificado en el índice 3 (ahora es 20):");
            Imprimir(datos);

            // Obtener cantidad de elementos
            cantidad = datos.Count;
            Console.WriteLine("La cantidad de elementos es: {0}", cantidad);
            Console.WriteLine("\n------------------");

            // Insertar un elemento en una posición específica
            datos.Insert(2, 50);
            Console.WriteLine("Después de insertar el 50 en la posición 2:");
            Imprimir(datos);

            // Eliminar un elemento por índice
            datos.RemoveAt(6);
            Console.WriteLine("Después de eliminar el elemento en el índice 6:");
            Imprimir(datos);

            // Encontrar el indice donde se encuentra el 5
            indice = datos.IndexOf(5);
            Console.WriteLine("El primer 5 se encuentra en: {0}", indice);
            Console.WriteLine("\n------------------");

            // Buscar un elemento
            int buscar = 20;
            if (datos.Contains(buscar))
                Console.WriteLine($"El número {buscar} SÍ está en el ArrayList.");
            else
                Console.WriteLine($"El número {buscar} NO está en el ArrayList.");
            Console.WriteLine("\n------------------");

            // Ordenar los elementos
            datos.Sort();
            Console.WriteLine("ArrayList ordenado:");
            Imprimir(datos);

            // Invertir los elementos
            datos.Reverse();
            Console.WriteLine("ArrayList en orden inverso:");
            Imprimir(datos);

            // Limpiar todos los elementos
            datos.Clear();
            Console.WriteLine("ArrayList después de limpiarlo:");
            Console.WriteLine($"Cantidad de elementos: {datos.Count}");

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        // Método para imprimir el contenido de un ArrayList
        private static void Imprimir(ArrayList datos)
        {
            foreach (var i in datos)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n------------------");
        }
    }
}
