using System; // namespace predefinido
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables1 // namespace propio
{
    /* Inicio de la clase
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo!!");
            // Tener en cuenta las tabulaciones
            // Bloques separados
            // Codigo ordenado

            // Clase 11 - Vamos a empezar a usar variables

            string nombre = "Santiago"; // las cadenas de caracteres se deben poner entre comillas dobles ""

            int num1 = 24; // No es necesario usar comillas dobles

            Console.WriteLine("Mi nombre es: " + nombre + " y tengo: " + num1 + " años");

            // Clase 12

            //nombre se pueden usar palabras reservadas
            //string namespace = "santiago"
            //string void = "santiago"
            //string using = "santiago"

            //float estatura = 1.80; // Error
            float estatura = 1.80f; // indicamos f que es el tipo float

            bool pescado = true;

            Console.WriteLine("Mi nombre es: " + nombre + " y tengo: " + num1 + " años" + " y mido: " + estatura + " metros" + " y el pescado me gusta?: " + pescado);

            // Clase 13
            Console.WriteLine("Clase 13");

            //decimal numero = 1.5; // Error
            decimal numero = 1.5m; // indicamos m que es el tipo decimal

            double numero2 = 2.5d; // indicamos d que es el tipo double

            Console.WriteLine("Mi nombre es: {0}, y tengo {1} años y mido {2} metros", nombre, num1, estatura);

            // Para que no se cierre
            Console.ReadKey();
        }
    }
}
