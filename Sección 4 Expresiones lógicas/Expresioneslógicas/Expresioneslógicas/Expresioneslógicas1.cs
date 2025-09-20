using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expresioneslógicas
{
    internal class Expresioneslógicas1
    {
        static void Main1(string[] args)
        {

            // Clase 25
            Console.WriteLine("Aplicacion de tanque");
            Console.WriteLine("");

            // Ejemplo 1

            int tanque = 60; // Tanque debe estar en menos del 50% / 40 true / 60 false
            int recorrido = 250; // Debe ser mas de 200 km

            if (tanque < 50 && recorrido > 200)
            {
                Console.WriteLine("Las expresiones son verdaderas,Tanquear el vehiculo");
            }
            else
            {
                Console.WriteLine("Las expresiones son se cumplen, No Tanquear el vehiculo");
            }

            Console.ReadKey();
        }
    }
}
