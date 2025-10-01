using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosEstructuras
{
    internal class Ejercicio1
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Ejercicio de Rango");
            Console.WriteLine("");

            // Declaración de variables para los límites del rango
            int rangoInicio = 10;
            int rangoFin = 50;

            // Solicitar número al usuario
            Console.Write("Ingresa un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Verificar si está dentro del rango usando operadores lógicos
            if (numero >= rangoInicio && numero <= rangoFin)
            {
                Console.WriteLine($"✅ El número {numero} está dentro del rango de {rangoInicio} a {rangoFin}.");
            }
            else
            {
                Console.WriteLine($"❌ El número {numero} está fuera del rango de {rangoInicio} a {rangoFin}.");
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
