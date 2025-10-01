using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EjerciciosCiclos
{
    internal class Ejercicio6
    {
        static void Main6()
        {
            Console.Write("Ingresa un número para la cuenta regresiva: ");
            int numero = int.Parse(Console.ReadLine());

            while (numero > 0)
            {
                Console.WriteLine(numero);
                Thread.Sleep(1000); // espera de 1 segundo
                numero--;
            }

            Console.WriteLine("¡Despegue!");
        }
    }
}
