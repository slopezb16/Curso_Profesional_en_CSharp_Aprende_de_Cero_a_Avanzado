using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeraciones
{
    internal class Program
    {
        // Declaracion de enumeraciones
        // Dias de la semana
        enum semana { Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, domingo }
        enum colores { Rojo = 1, Verde, Azul, Amarillo }

        static void Main(string[] args)
        {
            // Clase 72
            Console.WriteLine("\n=== Enumeraciones en C# ===");

            // =======================================
            // 1. Enumeraciones
            // =======================================
            Console.WriteLine("\n--- Ejemplo Enumeraciones ---");

            int numerico = 0;

            //Declaramos variable de tipo semana
            semana miDia;

            //Asignamos un valor a miDia
            miDia = semana.Lunes;

            //Pasamos de enumeración a entero
            numerico = (int)miDia;

            //mostrar información
            Console.WriteLine("El día es {0} con valor {1}", miDia, numerico);

            Console.WriteLine("\n--- Listado de días de la semana ---");
            foreach (semana dia in Enum.GetValues(typeof(semana)))
            {
                Console.WriteLine($"{dia} = {(int)dia}");
            }

            Console.WriteLine("\n--------------------------");

            Console.WriteLine("\n--- Ejemplo 2 Enumeraciones ---");

            //crear una variable de tipo color 
            colores miColor = colores.Rojo;

            //pasamos de enumeración a entero 
            numerico = (int)miColor;

            //mostrar información para colores
            Console.WriteLine("El color es {0} con valor {1}", miColor, numerico);

            Console.WriteLine("\n--- Listado de colores ---");
            foreach (colores c in Enum.GetValues(typeof(colores)))
            {
                Console.WriteLine($"{c} = {(int)c}");
            }

            Console.WriteLine("\n--------------------------");

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
