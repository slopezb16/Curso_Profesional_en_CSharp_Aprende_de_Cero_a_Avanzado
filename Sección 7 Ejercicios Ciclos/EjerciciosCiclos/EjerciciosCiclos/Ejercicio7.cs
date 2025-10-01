using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCiclos
{
    internal class Ejercicio7
    {
        static void Main7()
        {
            Console.Write("Ingresa un número límite: ");
            int limite = int.Parse(Console.ReadLine());

            int suma = 0;
            int contador = 1;

            while (contador <= limite)
            {
                suma += contador;
                contador++;
            }

            Console.WriteLine($"La suma de los números desde 1 hasta {limite} es: {suma}");
        }
    }
}
