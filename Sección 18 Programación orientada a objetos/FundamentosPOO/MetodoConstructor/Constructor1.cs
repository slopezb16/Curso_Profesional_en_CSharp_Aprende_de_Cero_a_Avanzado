using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstructor
{
    internal class Constructor1
    {
        // Definición de la estructura Agenda
        public struct Agenda
        {
            public string Nombre;
            public string Telefono;
            public int Edad;

            // 👉 Constructor
            public Agenda(string nombre, string telefono, int edad)
            {
                Nombre = nombre;
                //Telefono = telefono;
                Edad = edad;

                // Validar si el telefono es mayor a 8 caracteres
                if (telefono.Length > 8)
                {
                    Telefono = telefono;
                }
                else
                {
                    Telefono = "Telefono no valido, verifique nuevamente.";
                }
            }

            // Sobreescribimos ToString para mostrar los datos de forma clara
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Nombre: {0}, Teléfono: {1}, Edad: {2}", Nombre, Telefono, Edad);
                return sb.ToString();
            }
        }

        static void Main1(string[] args)
        {
            // Creamos un arreglo de 5 amigos
            Agenda[] amigos = new Agenda[5];

            // Ahora instanciamos con el constructor 👇
            amigos[0] = new Agenda("David", "(+57) 5522-888-555", 25);
            amigos[1] = new Agenda("Santiago", "(+57) 3421-098-523", 34);
            amigos[2] = new Agenda("Pedro", "3421", 55);

            // Mostramos los datos
            Console.WriteLine("Llamándolos uno a uno");
            Console.WriteLine(amigos[0].ToString());
            Console.WriteLine(amigos[1].ToString());
            Console.WriteLine(amigos[2].ToString());

            Console.WriteLine("Llamándolos todos a la vez:");
            foreach (var amigo in amigos)
            {
                if (!string.IsNullOrEmpty(amigo.Nombre)) // para evitar imprimir vacíos
                {
                    Console.WriteLine(amigo.ToString());
                }
            }

            Console.ReadKey();
        }
    }
}
