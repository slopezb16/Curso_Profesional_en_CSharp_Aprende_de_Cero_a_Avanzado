using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasSelectivas
{
    internal class Ejercicio
    {
        static void Main5(string[] args)
        {
            Console.WriteLine("APLICACION PARA ENCONTRAR EL NUMERO MAYOR");
            Console.WriteLine("");

            // Pedimos los 3 números
            Console.Write("Ingrese el primer número: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el tercer número: ");
            int n3 = Convert.ToInt32(Console.ReadLine());

            // Variable para guardar el mayor
            int mayor;

            // Comparación usando if
            if (n1 >= n2 && n1 >= n3)
            {
                mayor = n1;
            }
            else if (n2 >= n1 && n2 >= n3)
            {
                mayor = n2;
            }
            else
            {
                mayor = n3;
            }

            Console.WriteLine("");
            Console.WriteLine("El número mayor es: {0}", mayor);

            Console.ReadKey();
        }
    }
}
