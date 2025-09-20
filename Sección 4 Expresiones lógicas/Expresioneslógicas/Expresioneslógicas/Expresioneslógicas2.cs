using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expresioneslógicas
{
    internal class Expresioneslógicas2
    {
        static void Main2(string[] args)
        {

            // Clase 26
            Console.WriteLine("Aplicacion");
            Console.WriteLine("");

            // Ejemplo 1

            bool lluvia = true;
            bool sol = false;

            if (lluvia == true || sol == false)
            {
                Console.WriteLine("Una de las expresiones es verdadera, Usar sombrilla");
            }
            else
            {
                Console.WriteLine("Las expresiones son falsas, No usar sombrilla");
            }

            // Ejemplo 2

            bool dia = false;

            if (!dia == false) // dia = true -> !dia == false
            {
                Console.WriteLine("Negacion de una variable, true, No encender luz");
            }
            else
            {
                Console.WriteLine("Negacion de una variable, false, Encender luz");
            }

            // Ejemplo 3

            Console.WriteLine("Aplicación - Verificar si puede conducir");
            Console.WriteLine("");

            int edad;
            bool permiso = false; // inicializar en false
            string valor;

            // Solicitar edad
            Console.Write("Ingrese su edad: ");
            valor = Console.ReadLine();
            edad = Convert.ToInt32(valor);

            if (edad < 18)
            {
                // Solicitar permiso de los padres
                Console.Write("¿Tiene permiso de sus padres? (true = sí / false = no): ");
                valor = Console.ReadLine();
                permiso = Convert.ToBoolean(valor);
            }

            // Lógica para conducir
            if (edad >= 18 || (edad >= 15 && permiso == true))
            {
                Console.WriteLine("✅ Puede conducir.");
            }
            else
            {
                Console.WriteLine("❌ No puede conducir.");
            }

            // Ejemplo de negación (rango 15 a 17)
            if (!permiso && (edad >= 15 && edad < 18))
            {
                Console.WriteLine("Negación: No tiene permiso de los padres.");
            }
            else if (edad >= 18)
            {
                Console.WriteLine("Es mayor de edad.");
            }

            Console.ReadKey();
        }
    }
}
