using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionDeArchivos
{
    internal class Ejemplo1
    {
        static void Main2(string[] args)
        {
            // Clase 80
            Console.WriteLine("\n=== Manejo de Archivos en C# ===");

            // 1. Pedimos un mensaje al usuario
            Console.WriteLine("Escribe el mensaje a guardar:");

            // 2. Creamos un archivo nuevo "informacion.txt"
            TextWriter archivo1 = new StreamWriter("informacion.txt");

            // 3. Guardamos lo que el usuario escriba en el archivo
            string mensaje1 = Console.ReadLine();
            archivo1.WriteLine(mensaje1);

            // 4. Cerramos para guardar los datos
            archivo1.Close();
            Console.Clear();
            Console.WriteLine("Archivo guardado correctamente");

            Console.ReadKey();
        }
    }
}
