using System;
using System.IO;

namespace CreacionDeArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Clase 82
            Console.WriteLine("\n=== Manejo de Archivos en C# ===");

            // 1. Pedimos un mensaje al usuario
            Console.WriteLine("Escribe el mensaje a guardar:");

            // 2. Definimos la ruta donde se creará el archivo // en bin de la solucion
            string ruta = AppDomain.CurrentDomain.BaseDirectory;
            string archivoPath = Path.Combine(ruta, "informacion.txt");

            // 3. Guardamos lo que el usuario escriba en el archivo
            using (TextWriter archivo1 = new StreamWriter(archivoPath))
            {
                string mensaje1 = Console.ReadLine();
                archivo1.WriteLine(mensaje1);
            }

            Console.Clear();
            Console.WriteLine("Archivo guardado correctamente");

            // 4. Leemos lo que se guardó en el archivo
            using (TextReader leerArchivo = new StreamReader(archivoPath))
            {
                Console.WriteLine("Contenido del archivo:");
                Console.WriteLine(leerArchivo.ReadToEnd());
            }

            // 5. Ahora pedimos otro mensaje para agregar al archivo
            Console.WriteLine("\nEscribe un mensaje extra para guardar:");
            string mensaje2 = Console.ReadLine();

            using (StreamWriter archivo2 = File.AppendText(archivoPath))
            {
                archivo2.WriteLine(mensaje2);
            }

            Console.Clear();
            Console.WriteLine("Información agregada correctamente");

            // 6. Mostramos de nuevo el contenido actualizado
            using (TextReader leerArchivo = new StreamReader(archivoPath))
            {
                Console.WriteLine("Contenido actualizado del archivo:");
                Console.WriteLine(leerArchivo.ReadToEnd());
            }

            Console.ReadKey();
        }
    }
}