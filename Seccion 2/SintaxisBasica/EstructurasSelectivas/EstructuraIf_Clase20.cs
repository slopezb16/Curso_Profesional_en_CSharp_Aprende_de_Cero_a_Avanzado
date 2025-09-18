using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasSelectivas
{
    internal class EstructuraIf_Clase20
    {
        static void Main2(string[] args)
        {
            // Validacion de 2 numeros

            Console.WriteLine("APLICACION DE ESTRUCTURAS SELECTIVAS");

            // Clase 20
            //int a = 10;
            //int b = 15;

            //if (a != b)
            //{
            //    Console.WriteLine("Los numero son diferentes, la condicion se cumple");
            //}

            //if (a < b)
            //{
            //    Console.WriteLine("La variable a es menor que b, la condicion se cumple");
            //}

            // Datos de entrada al usuario

            int num1, num2;

            // Ejemplo 2
            //Console.WriteLine("Ingrese el primer numero");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("");

            //Console.WriteLine("Ingrese el segundo numero");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("");

            //if (num1 > num2)
            //{
            //    Console.WriteLine("El primer numero ({0}) es mayor que el segundo numero ({1}), la condicion se cumple", num1, num2);
            //}

            //if (num1 + num2 <= 20)
            //{
            //    Console.WriteLine("La suma del primer numero ({0}) mas el segundo numero ({1}) es menor a 20, la condicion se cumple", num1, num2);
            //}

            // Ejemplo 3
            double nota1, nota2;
            double resultado;

            Console.WriteLine("Ingrese el primer numero");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Ingrese el segundo numero");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            resultado = (nota1 + nota2) / 2;

            //if ((nota1 + nota2) / 2 == 5)
            if (resultado <= 5)
            {
                Console.WriteLine("La suma del primer numero ({0}) mas el segundo numero ({1}) dividido entre 2 es igual a 5, Aprobo el semestre, y tu nota final es {2}, la condicion se cumple", nota1, nota2, resultado);
            }

            Console.ReadKey();
        }
    }
}
