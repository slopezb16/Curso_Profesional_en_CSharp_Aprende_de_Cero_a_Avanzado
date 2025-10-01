using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCiclos
{
    internal class Ejercicio11
    {
        static void Main11()
        {
            Console.Write("Ingresa un número entre 1 y 20: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 20; i++)
            {
                if (i == numero)
                {
                    Console.WriteLine("Número omitido");
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
