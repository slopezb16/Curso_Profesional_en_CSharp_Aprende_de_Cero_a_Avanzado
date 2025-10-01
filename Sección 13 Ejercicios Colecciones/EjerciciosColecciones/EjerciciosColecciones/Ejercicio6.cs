using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosColecciones
{
    internal class Ejercicio6
    {
        static void Main6()
        {
            Console.Write("Ingresa un texto: ");
            string texto = Console.ReadLine();

            // Dividimos en palabras
            string[] palabras = texto.Split(' ');

            Hashtable contador = new Hashtable();

            foreach (string palabra in palabras)
            {
                if (contador.ContainsKey(palabra))
                {
                    contador[palabra] = (int)contador[palabra] + 1;
                }
                else
                {
                    contador.Add(palabra, 1);
                }
            }

            Console.WriteLine("\n📌 Palabras únicas y sus frecuencias:");
            foreach (DictionaryEntry entry in contador)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }
}
