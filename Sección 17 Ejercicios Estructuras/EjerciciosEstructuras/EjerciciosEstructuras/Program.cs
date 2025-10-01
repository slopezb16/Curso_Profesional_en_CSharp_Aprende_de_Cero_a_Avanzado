using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosEstructuras
{
    struct Contacto
    {
        public string Nombre;
        public string Telefono;
        public string Email;

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Teléfono: {Telefono}, Email: {Email}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Datos quemados directamente
            Contacto[] contactos = new Contacto[3];

            contactos[0].Nombre = "Jonathan";
            contactos[0].Telefono = "523";
            contactos[0].Email = "jom@jk.com";

            contactos[1].Nombre = "David";
            contactos[1].Telefono = "6523";
            contactos[1].Email = "kjas@jhas.com";

            contactos[2].Nombre = "Pedro";
            contactos[2].Telefono = "545";
            contactos[2].Email = "plas@das.com";

            Console.WriteLine("\nLista de contactos:");
            foreach (var contacto in contactos)
            {
                Console.WriteLine(contacto.ToString());
            }

            Console.ReadKey();
        }
    }
}
