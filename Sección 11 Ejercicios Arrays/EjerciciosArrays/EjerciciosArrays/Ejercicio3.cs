using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosArrays
{
    internal class Ejercicio3
    {
        static void Main3(string[] args)
        {
            int[] numeros = { 5, 10, 15, 20, 25 };

            Console.Write("Ingrese un número a buscar: ");
            int buscado = Convert.ToInt32(Console.ReadLine());

            bool encontrado = false;

            // Ciclo foreach para buscar
            foreach (int num in numeros)
            {
                if (num == buscado)
                {
                    encontrado = true;
                    break;
                }
            }

            // If para imprimir resultado
            if (encontrado)
            {
                Console.WriteLine($"El número {buscado} SÍ se encuentra en el array.");
            }
            else
            {
                Console.WriteLine($"El número {buscado} NO está en el array.");
            }

            Console.ReadKey();
        }
    }
}
