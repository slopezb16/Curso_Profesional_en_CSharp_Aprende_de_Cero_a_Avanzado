using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionDeArchivos
{
    internal class Ejemplo2
    {
        static void Main3(string[] args)
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

            // 5. Leemos lo que se guardó en el archivo
            TextReader leerArchivo = new StreamReader("informacion.txt");
            Console.WriteLine("Contenido del archivo:");
            Console.WriteLine(leerArchivo.ReadToEnd()); // Lee todo el archivo
            leerArchivo.Close();

            // 6. Ahora pedimos otro mensaje para agregar al archivo
            Console.WriteLine("\nEscribe un mensaje extra para guardar:");
            StreamWriter archivo2 = File.AppendText("informacion.txt");
            string mensaje2 = Console.ReadLine();
            archivo2.WriteLine(mensaje2);

            // 7. Cerramos y confirmamos
            archivo2.Close();
            Console.Clear();
            Console.WriteLine("Información agregada correctamente");
            Console.ReadKey();
        }
    }
}
