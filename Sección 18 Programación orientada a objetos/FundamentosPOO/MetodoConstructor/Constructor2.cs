using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstructor
{
    internal class Constructor2
    {
        // Creamos nuestra estructura fuera del método principal Main
        public struct Agenda
        {
            // Campos públicos
            public string nombre;
            public string telefono;
            public int edad;

            // 👉 1. Constructor principal (nombre, teléfono, edad)
            public Agenda(string pNombre, string pTelefono, int pEdad)
            {
                Console.WriteLine("⚙️ Constructor Principal: (nombre, teléfono, edad)");

                nombre = pNombre;
                edad = pEdad;

                if (pTelefono.Length > 8)
                {
                    telefono = pTelefono;
                }
                else
                {
                    telefono = "Teléfono no válido, verifique nuevamente";
                }
            }

            // 👉 2. Sobrecarga con nombre y edad (sin teléfono)
            public Agenda(string pNombre, int pEdad)
            {
                Console.WriteLine("⚙️ Sobrecarga 1: (nombre, edad)");

                nombre = pNombre;
                edad = pEdad;
                telefono = "Sin teléfono";
            }

            // 👉 3. Sobrecarga con solo nombre (se piden datos en consola)
            public Agenda(string pNombre)
            {
                Console.WriteLine("⚙️ Sobrecarga 2: (nombre)");

                nombre = pNombre;

                Console.WriteLine("Ingresa tu edad:");
                edad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingresa tu teléfono:");
                telefono = Console.ReadLine();

                if (telefono.Length < 8)
                {
                    telefono = "Sin teléfono";
                }
            }

            // 👉 4. Sobrecarga con código (simula que se crea desde un identificador)
            public Agenda(int codigo)
            {
                Console.WriteLine("⚙️ Sobrecarga 3: (código)");

                Console.WriteLine("Ingresa tu nombre:");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingresa tu edad:");
                edad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingresa tu teléfono:");
                telefono = Console.ReadLine();

                if (telefono.Length < 8)
                {
                    telefono = "Sin teléfono";
                }
            }

            // 👉 Sobrescribir ToString
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Nombre: {0}, Teléfono: {1}, Edad: {2}", nombre, telefono, edad);
                return sb.ToString();
            }
        }

        static void Main2(string[] args)
        {
            // Invocación de diferentes constructores
            Agenda amigo = new Agenda("Jorge", "(+57)555-1234", 35);   // Constructor principal
            Agenda amigo1 = new Agenda("Pedro", "(123)", 25);          // Constructor principal
            Agenda amigo2 = new Agenda("Jose", 28);                   // Sobrecarga 1
            Agenda amigo3 = new Agenda("Marta");                      // Sobrecarga 2 (pide datos en consola)
            Agenda amigo4 = new Agenda(25);                           // Sobrecarga 3 (pide datos en consola)

            // Imprimir resultados
            Console.WriteLine("\n📋 Resultados:");
            Console.WriteLine(amigo.ToString());
            Console.WriteLine(amigo1.ToString());
            Console.WriteLine(amigo2.ToString());
            Console.WriteLine(amigo3.ToString());
            Console.WriteLine(amigo4.ToString());

            Console.ReadKey();
        }
    }
}
