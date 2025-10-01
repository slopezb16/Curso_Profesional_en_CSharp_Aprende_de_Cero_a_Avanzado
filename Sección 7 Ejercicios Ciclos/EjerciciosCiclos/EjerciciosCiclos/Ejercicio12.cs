using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EjerciciosCiclos
{
    internal class Ejercicio12
    {
        static void Main12()
        {
            Console.Write("Ingresa un número entre 1 y 20: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 20; i++)
            {
                if (i == numero)
                {
                    goto Binario;
                }
                Console.WriteLine(i);
                continue;

            Binario:
                Console.WriteLine($"Número en binario: {Convert.ToString(numero, 2)}");
            }
        }
    }
}
