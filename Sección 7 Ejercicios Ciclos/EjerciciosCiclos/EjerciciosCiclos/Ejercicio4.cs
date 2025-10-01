using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCiclos
{
    internal class Ejercicio4
    {
        static void Main4()
        {
            string texto = "Hola, mundo!";

            Console.WriteLine("Recorriendo cadena con foreach:");
            foreach (char caracter in texto)
            {
                Console.WriteLine(caracter);
            }
        }
    }
}
