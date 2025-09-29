using System;
using System.IO;

namespace CreacionDeArchivos
{
    internal class EjemploMejorado
    {
        class ArchivoTexto // Clase para manejo de archivos .txt
        {
            // Método para crear y escribir en un archivo
            public void CrearArchivo(string nombreArchivo)
            {
                Console.WriteLine("Escribe el mensaje a guardar:");
                string mensaje = Console.ReadLine();

                TextWriter escritor = new StreamWriter(nombreArchivo); // Crear archivo
                escritor.WriteLine(mensaje); // Escribir mensaje
                escritor.Close(); // Cerrar archivo para guardar cambios

                Console.WriteLine("\nArchivo guardado correctamente.");
            }

            // Método para leer el contenido completo de un archivo
            public void LeerArchivo(string nombreArchivo)
            {
                Console.WriteLine("\n=== Leyendo contenido del archivo ===");
                TextReader lector = new StreamReader(nombreArchivo);
                Console.WriteLine(lector.ReadToEnd()); // Leer todo el archivo
                lector.Close();
            }

            // Método para agregar información sin sobrescribir
            public void AgregarInformacion(string nombreArchivo)
            {
                Console.WriteLine("\nEscribe un mensaje adicional para guardar:");
                string mensajeExtra = Console.ReadLine();

                StreamWriter escritor = File.AppendText(nombreArchivo); // Agregar info al archivo
                escritor.WriteLine(mensajeExtra);
                escritor.Close();

                Console.WriteLine("\nInformación agregada correctamente.");
            }
        }

        internal class Program
        {
            static void Main1(string[] args)
            {
                // Clase 81
                Console.WriteLine("\n=== Manejo de Archivos en C# ===");

                // =======================================
                // 1. Crear y escribir en archivo
                // =======================================
                ArchivoTexto archivo = new ArchivoTexto();
                archivo.CrearArchivo("informacion.txt");

                // =======================================
                // 2. Leer archivo
                // =======================================
                archivo.LeerArchivo("informacion.txt");

                // =======================================
                // 3. Agregar información al archivo
                // =======================================
                archivo.AgregarInformacion("informacion.txt");

                Console.WriteLine("\n--------------------------");
                Console.WriteLine("Presiona cualquier tecla para salir...");
                Console.ReadKey();
            }
        }
    }
}
