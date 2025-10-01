using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Ejercicio2
    {
        static void Main2(string[] args)
        {
            // Declaración y asignación de variables
            int num1 = 1;
            decimal num2 = 0.5m;   // el sufijo m indica que es decimal
            float num3 = 1.5f;     // el sufijo f indica que es float
            double num4 = 5.5;     // double no necesita sufijo
            string nombre = "Estudiante";

            // Impresión en consola usando {0}
            Console.WriteLine("El entero es: {0}", num1);
            Console.WriteLine("El decimal es: {0}", num2);
            Console.WriteLine("El float es: {0}", num3);
            Console.WriteLine("El double es: {0}", num4);
            Console.WriteLine("El string es: {0}", nombre);

            Console.ReadKey();
        }

    }
}
