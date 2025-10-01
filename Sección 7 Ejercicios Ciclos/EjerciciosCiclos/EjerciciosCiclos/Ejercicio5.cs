using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCiclos
{
    internal class Ejercicio5
    {
        static void Main5()
        {
            Console.Write("Ingresa un número entero: ");
            int numero = int.Parse(Console.ReadLine());

            int suma = 0;

            foreach (char digito in numero.ToString())
            {
                suma += int.Parse(digito.ToString());
            }

            Console.WriteLine($"La suma de los dígitos de {numero} es: {suma}");
        }
    }
}
