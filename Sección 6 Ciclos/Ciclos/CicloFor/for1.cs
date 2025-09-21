using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicloFor
{
    internal class for1
    {
        static void Main1(string[] args)
        {
            // Clase 30

            Console.WriteLine("Aplicación de calcular el promedio - ciclos for");
            Console.WriteLine("");

            // Ejemplo 1 - Sin for - Sin flexibilidad
            //float cal1, cal2, cal3, promedio;
            //Console.WriteLine("\n=== Ejemplo sin ciclo for ===");

            //// Pedir datos
            //Console.WriteLine("Ingrese la primera calificación");
            //cal1 = Convert.ToSingle(Console.ReadLine());

            //Console.WriteLine("Ingrese la segunda calificación");
            //cal2 = Convert.ToSingle(Console.ReadLine());

            //Console.WriteLine("Ingrese la tercera calificación");
            //cal3 = Convert.ToSingle(Console.ReadLine());

            //promedio = (cal1 + cal2 + cal3) / 3;

            //Console.WriteLine("El promedio de las calificaciones (ejemplo 1) es: {0}", promedio);

            // Ejemplo 2 - Con for - Con flexibilidad
            Console.WriteLine("\n=== Ejemplo con ciclo for ===");

            Console.Write("¿Cuántas calificaciones desea ingresar? ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            float suma = 0;

            //int i; / o abajo
            for (int i = 1; i <= cantidad; i++)
            {
                Console.Write($"Ingrese la calificación {i}: ");
                float calificacion = Convert.ToSingle(Console.ReadLine());
                suma += calificacion;
            }

            float promedioFor = suma / cantidad;
            Console.WriteLine("El promedio de las {0} calificaciones es: {1}", cantidad, promedioFor);

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
