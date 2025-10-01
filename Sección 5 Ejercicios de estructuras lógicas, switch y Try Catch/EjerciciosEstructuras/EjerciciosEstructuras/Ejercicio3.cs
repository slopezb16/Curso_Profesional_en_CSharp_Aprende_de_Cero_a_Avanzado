using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosEstructuras
{
    internal class Ejercicio3
    {
        static void Main3()
        {
            // Solicitar si tiene boleto
            Console.Write("¿Tiene boleto? (Sí/No): ");
            string respuestaBoleto = Console.ReadLine();

            // Solicitar edad
            Console.Write("Ingresa tu edad: ");
            int edad = int.Parse(Console.ReadLine());

            // Variables booleanas
            bool tieneBoleto = (respuestaBoleto.ToLower() == "sí");
            bool esMayorDeEdad = (edad >= 18);

            // Validación con AND (&&)
            if (tieneBoleto && esMayorDeEdad)
            {
                Console.WriteLine("¡Bienvenido! Disfruta de la película.");
            }
            else
            {
                Console.WriteLine("Lo siento, no cumples los requisitos de acceso.");
            }
        }
    }
}
