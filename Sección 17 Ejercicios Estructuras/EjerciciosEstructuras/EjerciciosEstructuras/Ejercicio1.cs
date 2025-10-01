using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosEstructuras
{
    internal class Ejercicio1
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

        class Program1
        {
            static void Main(string[] args)
            {
                Contacto[] contactos = new Contacto[3];

                for (int i = 0; i < contactos.Length; i++)
                {
                    Console.WriteLine($"\nIngrese los datos del contacto {i + 1}:");

                    Console.Write("Nombre: ");
                    contactos[i].Nombre = Console.ReadLine();

                    Console.Write("Teléfono: ");
                    contactos[i].Telefono = Console.ReadLine();

                    Console.Write("Email: ");
                    contactos[i].Email = Console.ReadLine();
                }

                Console.WriteLine("\nLista de contactos:");
                foreach (var contacto in contactos)
                {
                    Console.WriteLine(contacto.ToString());
                }

                Console.ReadKey();
            }
        }

        // Funciona

    }
}
