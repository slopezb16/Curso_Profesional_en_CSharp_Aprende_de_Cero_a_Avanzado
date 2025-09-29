using System;
using System.Text; // Para usar StringBuilder

namespace EstructurasEnlazadas
{
    internal class Program
    {
        // 👉 Estructura Direccion
        public struct Direccion
        {
            public string Calle;
            public int Numero;

            // Constructor
            public Direccion(string pCalle, int pNumero)
            {
                Calle = pCalle;
                Numero = pNumero;
            }

            // Sobrescribir ToString
            public override string ToString()
            {
                return $" Dirección: {Calle} #{Numero}";
            }
        }

        // 👉 Estructura Agenda (enlaza Direccion)
        public struct Agenda
        {
            public string Nombre;
            public string Telefono;
            public int Edad;
            public Direccion Domicilio; // Estructura enlazada

            // 1. Constructor completo
            public Agenda(string pNombre, string pTelefono, int pEdad, string pCalle, int pNumero)
            {
                Nombre = pNombre;
                Edad = pEdad;

                if (pTelefono.Length > 8)
                {
                    Telefono = pTelefono;
                }
                else
                {
                    Telefono = "Teléfono no válido, verifique nuevamente";
                }

                // Instanciamos la estructura Direccion
                Domicilio = new Direccion(pCalle, pNumero);
            }

            // 2. Constructor con nombre y edad
            public Agenda(string pNombre, int pEdad)
            {
                Nombre = pNombre;
                Edad = pEdad;
                Telefono = "Sin teléfono";
                Domicilio = new Direccion("Sin dirección", 0);
            }

            // 3. Constructor con solo nombre (solicita datos)
            public Agenda(string pNombre)
            {
                Nombre = pNombre;

                Console.WriteLine("Ingresa tu edad:");
                Edad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingresa tu teléfono:");
                Telefono = Console.ReadLine();

                if (Telefono.Length < 8)
                {
                    Telefono = "Sin teléfono";
                }

                Domicilio = new Direccion("Sin dirección", 0);
            }

            // 👉 Sobrescribir ToString
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Nombre: {0}, Teléfono: {1}, Edad: {2}", Nombre, Telefono, Edad);
                sb.Append(Domicilio.ToString()); // Agregamos la dirección
                return sb.ToString();
            }
        }

        static void Main(string[] args)
        {
            // Creación de instancias con diferentes constructores
            Agenda amigo = new Agenda("Jorge", "(+57)555-1234", 35, "Av Principal", 112);
            Agenda amigo1 = new Agenda("Pedro", "(123)", 25, "Av 2", 500);
            Agenda amigo2 = new Agenda("Jose", 28);
            Agenda amigo3 = new Agenda("Marta"); // Aquí pedirá edad y teléfono en consola

            // Resultados
            Console.WriteLine("\n📋 Resultados:");
            Console.WriteLine(amigo.ToString());
            Console.WriteLine(amigo1.ToString());
            Console.WriteLine(amigo2.ToString());
            Console.WriteLine(amigo3.ToString());

            Console.ReadKey();
        }
    }
}