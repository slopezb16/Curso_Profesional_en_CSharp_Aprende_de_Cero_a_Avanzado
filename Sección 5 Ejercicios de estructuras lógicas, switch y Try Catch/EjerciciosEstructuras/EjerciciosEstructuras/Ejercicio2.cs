using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosEstructuras
{
    internal class Ejercicio2
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("Ejercicio de evaluación de condiciones combinadas");
            Console.WriteLine("");

            // Declarar variables booleanas
            bool tienePremium, haRealizadoCompras;

            // Preguntar si tiene cuenta premium
            Console.Write("¿Tiene una cuenta premium? (Sí/No): ");
            string respuestaPremium = Console.ReadLine().ToLower();

            tienePremium = (respuestaPremium == "sí" || respuestaPremium == "si");

            // Preguntar si ha realizado más de 5 compras
            Console.Write("¿Ha realizado más de 5 compras? (Sí/No): ");
            string respuestaCompras = Console.ReadLine().ToLower();

            haRealizadoCompras = (respuestaCompras == "sí" || respuestaCompras == "si");

            // Evaluar condiciones con OR
            if (tienePremium || haRealizadoCompras)
            {
                Console.WriteLine("✅ Usted es elegible para un descuento especial.");
            }
            else
            {
                Console.WriteLine("❌ Lo siento, no es elegible para el descuento.");
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
