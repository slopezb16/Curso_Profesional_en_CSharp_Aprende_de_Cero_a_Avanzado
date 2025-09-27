using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras
{
    internal class Program
    {
        // Definición de la estructura Agenda
        public struct Agenda
        {
            public String Nombre;
            public String Telefono;
            public int Edad;

            // Sobreescribimos ToString para mostrar los datos de forma clara
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Nombre: {0}, Teléfono: {1}, Edad: {2}", Nombre, Telefono, Edad);
                return sb.ToString();
            }
        }

        static void Main(string[] args)
        {
            // Creamos un arreglo de 5 amigos
            Agenda[] amigos = new Agenda[5];

            // Asignamos valores al primer amigo
            amigos[0].Edad = 25;
            amigos[0].Nombre = "David";
            amigos[0].Telefono = "(+57) 5522-888-555";

            // Asignamos valores al segundo amigo
            amigos[1].Edad = 34;
            amigos[1].Nombre = "Santiago";
            amigos[1].Telefono = "(+57) 3421-098-523";

            // Mostramos los datos

            Console.WriteLine("Llamandolos uno a uno");
            Console.WriteLine(amigos[0].ToString());
            Console.WriteLine(amigos[1].ToString());

            Console.WriteLine("Llamandolos todos a la vez");
            Console.WriteLine(amigos.ToString());

            Console.ReadKey();
        }
    }
}
