using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EjerciciosCiclos
{
    internal class Ejercicio10
    {
        static void Main10()
        {
            Console.Write("Ingresa un número entre 1 y 20: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(500); // medio segundo de pausa

                if (i == numero)
                {
                    Console.WriteLine($"Se detuvo en el número {numero}");
                    break;
                }
            }
        }
    }
}
