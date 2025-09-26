using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    internal class Ejemplo2
    {
        static void Main2(string[] args)
        {
            // Clase 50

            // Arrays List
            Console.WriteLine("\n=== Arrays List ===");

            // Ejemplo 2
            Console.WriteLine("\n--- Ejemplo Array List ---");

            int indice, cantidad;

            ArrayList datos = new ArrayList();

            datos.Add(7);
            datos.Add(5);
            datos.Add(1);

            Console.WriteLine("Estos son los datos del Ejemplo 1 de arraylist");

            Imprimir(datos);

            // mas datos

            datos.Add(4);
            datos.Add(9);
            datos.Add(3);

            // Obtenemos el indice
            indice = datos.Add(10);

            Console.WriteLine("\nDespues de hacer crecer el arrayList");
            Imprimir(datos);

            Console.WriteLine("El ultimo elemento tiene el indice: {0}", indice);
            Console.WriteLine("\n------------------");

            //Console.Write("Ingrese la cantidad de alumnos: ");
            //int cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        private static void Imprimir(ArrayList datos)
        {
            foreach (var i in datos)
            {
                Console.WriteLine(i);
                Console.WriteLine("\n------------------");
            }
        }
    }
}
