using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasSelectivas
{
    internal class EstructuraIfElse_Clase21
    {
        static void Main3(string[] args)
        {
            // Validacion de 2 numeros

            Console.WriteLine("APLICACION DE ESTRUCTURAS SELECTIVAS");

            // Clase 21

            // Ejemplo 1
            // Datos de entrada al usuario

            //int n1, n2;

            //Console.WriteLine("Ingrese el primer numero");
            //n1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("");

            //Console.WriteLine("Ingrese el segundo numero");
            //n2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("");

            //if (n1 < n2)
            //{
            //    Console.WriteLine("El primer numero ({0}) es menor que el segundo numero ({1}), la condicion se cumple", n1, n2);
            //}
            //else
            //{
            //    Console.WriteLine("El primer numero ({0}) es mayor que el segundo numero ({1}), la condicion se cumple", n1, n2);
            //}

            // Ejemplo 2
            // Datos de entrada al usuario

            double n1, n2;

            Console.WriteLine("Ingrese el primer numero");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Ingrese el segundo numero");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            double promedio = (n1 + n2) / 2;

            if (promedio > 3.5)
            {
                Console.WriteLine("Aprobo el semestre, la condicion se cumple");
                Console.WriteLine("Tu promedio fue de {0}, la condicion se cumple", promedio);
            }
            else
            {
                Console.WriteLine("Reprobo el semestre, la condicion se cumple");
                Console.WriteLine("Tu promedio fue de {0}, la condicion se cumple", promedio);
            }

            Console.ReadKey();
        }
    }
}
