using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadenas_String
{
    internal class Cadenas1
    {
        static void Main1(string[] args)
        {
            // ===============================
            // CLASE 60 - MANEJO DE CADENAS EN C#
            // ===============================
            Console.WriteLine("\n=== Manejo de Cadenas en C# ===");

            // ===============================
            // 1. Declaración y uso de cadenas
            // ===============================
            Console.WriteLine("\n--- Ejemplo Básico de String ---");

            String miCadena = "Hola a todos";
            String dato = " y bienvenidos";

            // Concatenación básica con String.Concat
            String mensaje = String.Concat(miCadena, dato);
            Console.WriteLine("Concatenación simple: " + mensaje);
            Console.WriteLine("\n--------------------------");

            // ====================================
            // 2. Conversión de otros tipos a texto - Metodo ToString()
            // ====================================
            Console.WriteLine("\n--- Ejemplo con ToString() ---");

            int valor = 10;
            String cadena = valor.ToString(); // Convierte el número a texto
            Console.WriteLine("Número convertido a cadena: " + cadena);
            Console.WriteLine("\n--------------------------");

            // ================================
            // 3. Formato de Fechas y Horas - Clase especial DateTime
            // ================================
            Console.WriteLine("\n--- Ejemplo con DateTime y String.Format ---");

            // 🔑 Principales especificadores de formato de fecha/hora:
            // {0:d}    → Fecha corta (ej: 26/09/2025)
            // {0:dddd} → Nombre del día (ej: viernes)
            // {0:dddd d} → Día con nombre (ej: viernes 26)
            // {0:m}    → Mes y día (ej: 26 de septiembre)
            // {0:MMMM} → Mes completo (ej: septiembre)
            // {0:y}    → Mes y año (ej: septiembre 2025)
            // {0:yyyy} → Año completo (ej: 2025)
            // {0:dddd d MMMM m yyyy y} → Día, número, mes, año (ej: viernes 26 septiembre 09 2025 2025)
            // {0:h}    → Hora en formato 12 (1–12)
            // {0:H}    → Hora en formato 24 (0–23)
            // {0:m}    → Minutos
            // {0:s}    → Segundos
            // {0:t}    → AM/PM en forma corta (ej: a. m.)
            // {0:tt}   → AM/PM en forma completa (ej: AM o PM)

            String formato = String.Format(
                "Hoy es: {0:dddd, d 'de' MMMM yyyy - hh:mm:ss tt}",
                DateTime.Now
            );

            Console.WriteLine(formato);
            Console.WriteLine("\n--------------------------");

            // =================================
            // 4. Formato numérico
            // =================================
            Console.WriteLine("\n--- Ejemplo de Formato Numérico ---");

            int numero = 10000;
            Console.WriteLine(String.Format("Sin formato: {0}", numero));   // 10000
            Console.WriteLine(String.Format("Con formato moneda (C): {0:C}", numero)); // $10,000.00
            Console.WriteLine(String.Format("Formato personalizado 1: {0:$#,##0.00}", numero)); // $10,000.00
            Console.WriteLine(String.Format("Formato personalizado 2: {0:$#,####0.00}", numero)); // $10,000.00
            Console.WriteLine("\n--------------------------");

            // =================================
            // 5. Concatenación avanzada
            // =================================
            Console.WriteLine("\n--- Ejemplo Concatenación Avanzada ---");

            String info = String.Concat(miCadena, dato);
            String mensaje2 = String.Format("Imprimir mensaje: {0}", info);
            Console.WriteLine(mensaje2);

            // Otra forma con nombre y apellido
            string nombre = "Santiago";
            string apellido = "Lopez";

            String nombreCompleto = String.Concat(nombre, " ", apellido);
            String mensaje3 = String.Format("Nombre completo: {0}", nombreCompleto);

            Console.WriteLine(mensaje3);

            // ===============================
            // Final del programa
            // ===============================
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
