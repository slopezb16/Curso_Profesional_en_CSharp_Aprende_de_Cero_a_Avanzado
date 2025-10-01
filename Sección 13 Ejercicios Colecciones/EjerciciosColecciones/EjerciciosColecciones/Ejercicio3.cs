using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosColecciones
{
    internal class Ejercicio3
    {
        static void Main3()
        {
            Console.Write("Ingresa un número decimal: ");
            int numero = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            // Convertimos a binario
            int temp = numero;
            while (temp > 0)
            {
                int residuo = temp % 2;
                stack.Push(residuo);
                temp /= 2;
            }

            Console.Write($"\nEl número {numero} en binario es: ");
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
