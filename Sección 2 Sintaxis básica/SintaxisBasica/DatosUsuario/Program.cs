using System;

namespace DatosUsuario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Clase 17
            /*
            string nombre;
            int edad;
            double estatura;

            // Nombre
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Su nombre es: {0}", nombre);

            // Edad
            Console.WriteLine("Ingrese su edad");
            edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Su edad es: {0}", edad);

            // Estatura
            Console.WriteLine("Ingrese su estatura");
            estatura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Su estatura es: {0}", estatura);
            */

            // Clase 18
            string nombre;
            int num1, num2; // para las operaciones

            int suma;

            Console.WriteLine("APLICACION DE SUMAS");

            // Nombre
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Bienvenido: {0}", nombre);
            Console.WriteLine("");

            // Suma
            Console.WriteLine("Ingrese los numeros a sumar");

            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            suma = num1 + num2;
            Console.WriteLine("La suma de {0} + {1} es igual a: {2}", num1, num2, suma);

            Console.ReadKey();
        }
    }
}
