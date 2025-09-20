using System;

namespace OperadoresAritmeticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Clase 15

            // Operaciones + - * /

            byte num1 = 20;
            byte num2 = 10;

            int suma = num1 + num2;


            Console.WriteLine("la suma es: {0}", suma);

            // Clase 16

            int resta = num1 - num2;

            int multi = num1 * num2;

            int div = num1 / num2;

            Console.WriteLine("la resta es: {0}", resta);

            Console.WriteLine("la multiplicacion es: {0}", multi);

            Console.WriteLine("la divicion es: {0}", div);

            // Para que no se cierre
            Console.ReadKey();
        }
    }
}