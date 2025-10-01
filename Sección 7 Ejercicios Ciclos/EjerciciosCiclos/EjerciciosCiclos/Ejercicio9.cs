using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCiclos
{
    internal class Ejercicio9
    {
        static void Main9()
        {
            string passwordCorrecta = "1234";
            string passwordIngresada;

            do
            {
                Console.Write("Ingresa la contraseña: ");
                passwordIngresada = Console.ReadLine();

                if (passwordIngresada != passwordCorrecta)
                {
                    Console.WriteLine("Contraseña incorrecta, intenta de nuevo.");
                }

            } while (passwordIngresada != passwordCorrecta);

            Console.WriteLine("¡Contraseña correcta, acceso concedido!");
        }
    }
}
