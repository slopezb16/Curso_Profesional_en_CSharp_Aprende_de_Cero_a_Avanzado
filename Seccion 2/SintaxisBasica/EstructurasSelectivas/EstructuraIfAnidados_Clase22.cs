using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasSelectivas
{
    internal class EstructuraIfAnidados_Clase22
    {
        static void Main4(string[] args)
        {
            // Validacion de 2 numeros

            Console.WriteLine("APLICACION DE ESTRUCTURAS SELECTIVAS");

            Console.WriteLine("Bienvenido a la aplicacion de operaciones");
            Console.WriteLine("");

            // Clase 22

            // Ejemplo 1
            // Datos de entrada al usuario

            //int n1, n2, n3;

            //Console.WriteLine("Ingrese el primer numero");
            //n1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("");

            //Console.WriteLine("Ingrese el segundo numero");
            //n2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("");

            //Console.WriteLine("Ingrese el tercer numero");
            //n3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("");

            //if (n1 > n2)
            //{
            //    if (n2 > n3)
            //    {
            //        Console.WriteLine("El primer numero ({0}) es mayor que el segundo numero ({1}), y el segundo numero ({1}) es mayor que el tercer numero ({2}), la condicion se cumple", n1, n2, n3);
            //    }
            //    else
            //    {
            //        if (n2 < n3)
            //        {
            //        Console.WriteLine("El primer numero ({0}) es mayor que el segundo numero ({1}), y el segundo numero ({1}) es menor que el tercer numero ({2}), la condicion se cumple", n1, n2, n3);
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("El primer numero ({0}) es menor que el segundo numero ({1}), la condicion se cumple", n1, n2);
            //}

            // Ejemplo 2
            // Datos de entrada al usuario

            int n1, n2, n3;

            Console.WriteLine("Ingrese el primer numero");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Ingrese el segundo numero");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Ingrese el tercer numero");
            n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            int resultado = n2 + n3;

            if (n1 > resultado)
            {
                if (resultado <= 20)
                {
                    Console.WriteLine("El primer numero ({0}) es mayor que la sumatoria del segundo numero ({1}) mas el tercer numero ({2}), y es menor que 20, la condicion se cumple", n1, n2, n3);
                    Console.WriteLine("Resultado: {0}", resultado);
                }
                else
                {
                    if (resultado >= 21)
                    {
                        Console.WriteLine("El primer numero ({0}) es mayor que la sumatoria del segundo numero ({1}) mas el tercer numero ({2}), y es mayor que 21, la condicion se cumple", n1, n2, n3);
                        Console.WriteLine("Resultado: {0}", resultado);
                    }
                }
            }
            else
            {
                Console.WriteLine("El primer numero ({0}) es menor que el resultado ({1}), la condicion se cumple", n1, resultado);
            }

            Console.ReadKey();
        }
    }
}
