using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosUsuario
{
    internal class Operaciones
    {
        public Operaciones() 
        {
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
            Console.WriteLine("La suma de {0} + {1} es igual a: {3}", num1, num2, suma);

            Console.ReadKey();
        }
    }
}
