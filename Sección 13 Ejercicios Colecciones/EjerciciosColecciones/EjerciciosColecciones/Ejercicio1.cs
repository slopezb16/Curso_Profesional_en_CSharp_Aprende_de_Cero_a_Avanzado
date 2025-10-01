using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosColecciones
{
    internal class Ejercicio1
    {
        static void Main1()
        {
            // ArrayList predefinido
            ArrayList palabras = new ArrayList { "hola", "mundo", "csharp", "programacion", "practica" };

            Console.Write("Ingresa una palabra: ");
            string palabra = Console.ReadLine();

            Console.WriteLine("\nLista de palabras:");
            foreach (string p in palabras)
            {
                Console.WriteLine($"- {p}");
            }

            // Verificamos si existe
            if (palabras.Contains(palabra))
                Console.WriteLine($"\n✅ La palabra '{palabra}' fue encontrada en la lista.");
            else
                Console.WriteLine($"\n❌ La palabra '{palabra}' NO se encuentra en la lista.");
        }
    }
}
