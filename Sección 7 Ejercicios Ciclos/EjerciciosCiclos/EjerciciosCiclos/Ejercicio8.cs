using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCiclos
{
    internal class Ejercicio8
    {
        static void Main8()
        {
            int suma = 0;
            string opcion;

            do
            {
                Console.Write("Ingresa un número: ");
                int numero = int.Parse(Console.ReadLine());
                suma += numero;

                Console.Write("¿Quieres ingresar otro número? (si/no): ");
                opcion = Console.ReadLine().ToLower();

            } while (opcion == "si");

            Console.WriteLine($"La suma total de los números ingresados es: {suma}");
        }
    }
}
