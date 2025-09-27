using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadenas_String
{
    internal class Cadenas2
    {
        static void Main2(string[] args)
        {
            // Clase 61 - Cadenas 2

            // Cadenas
            Console.WriteLine("\n=== Manejo de Cadenas 2 en C# ===");

            // ===============================
            // 1. Comparacion de cadenas
            // ===============================
            Console.WriteLine("\n--- Ejemplo Comparacion de cadenas ---");

            string nombre = "Santiago";
            string apellido = "Lopez";

            // Compare devuelve:
            //  0 si son iguales
            // <0 si 'nombre' es menor alfabéticamente
            // >0 si 'nombre' es mayor alfabéticamente
            int comparacion;
            comparacion = String.Compare(nombre, apellido);

            if (comparacion == 0)
            {
                Console.WriteLine("✅ Las cadenas son iguales");
            }
            else
            {
                Console.WriteLine("❌ Las cadenas no son iguales");
            }

            Console.WriteLine("\n--------------------------");

            // ===============================
            // 2. Encontrar una cadenas
            // ===============================
            Console.WriteLine("\n--- Ejemplo Encontrar una cadenas ---");

            String NombreCompleto = "Jose alameda villa";
            String NombreBuscar = "alameda";

            if (NombreCompleto.Contains(NombreBuscar))
            {
                Console.WriteLine("✅ El nombre a buscar existe en la cadena");
            }
            else
            {
                Console.WriteLine("❌ El nombre a buscar no existe en la cadena");
            }

            Console.WriteLine("\n--------------------------");

            // ===============================
            // 3. Obtener una subcadenas
            // ===============================
            Console.WriteLine("\n--- Ejemplo Obtener una subcadenas ---");

            String resultado = "";
            String miCadena = "Hola a todos y bienvenidos";
            Console.WriteLine("Cadena original: " + miCadena);

            // Extrae 5 caracteres a partir del índice 7
            resultado = miCadena.Substring(7, 5);

            Console.WriteLine("Subcadena obtenida: " + resultado);

            Console.WriteLine("\n--------------------------");

            // ===============================
            // 4. Determinar si una cadenas finaliza en una subcadenas
            // ===============================
            Console.WriteLine("\n--- Ejemplo Determinar si una cadenas finaliza en una subcadenas ---");

            String cadena1 = "Juan Alberto Tabarez";
            String cadena2 = "Tabarez";

            if (cadena1.EndsWith(cadena2))
            {
                Console.WriteLine($"✅ La cadena1 finaliza en \"{cadena2}\"");
            }
            else
            {
                Console.WriteLine($"❌ La cadena1 no finaliza en \"{cadena2}\"");
            }

            Console.WriteLine("\n--------------------------");

            // ===============================
            // 5. Copiar informacion de la cadena
            // ===============================
            Console.WriteLine("\n--- Ejemplo Copiar informacion de la cadena ---");

            char[] destino = new char[10];
            char[] destino2 = new char[20];

            String saludo = "Hola a todos los estudiantes";

            // 7 - donde inicia
            // destino - donde se copia
            // 0 - donde inica a contar
            // 5 - cuantos caracteres tomar

            // Parámetros de CopyTo:
            // (índiceInicialCadena, arregloDestino, índiceInicialDestino, cantidadCaracteres)
            saludo.CopyTo(7, destino, 0, 5);   // Copia "todos"
            saludo.CopyTo(17, destino2, 0, 11); // Copia "estudiantes"

            Console.WriteLine(destino);
            Console.WriteLine(destino2);

            Console.WriteLine("\n--------------------------");

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
