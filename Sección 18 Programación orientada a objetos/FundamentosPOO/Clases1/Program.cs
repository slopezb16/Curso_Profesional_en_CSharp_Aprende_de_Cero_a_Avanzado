using System;

namespace Clases1
{
    class Cubo // Creamos clase cubo
    {
        // Declarar datos 
        public int lado;
        public int area;
        public int volumen;

        // Método para calcular el área
        public void CalcularArea()
        {
            area = (lado * lado) * 6;
        }

        // Método para calcular el volumen 
        public void CalcularVolumen()
        {
            volumen = lado * lado * lado;
        }
    }

    class Prisma // Creamos clase Prisma
    {
        // Declarar datos 
        private int ancho, alto, espesor, area, volumen;

        // Definimos las propiedades 
        public int Ancho
        {
            get { return ancho; }
            set { ancho = (value <= 0) ? 1 : value; }
        }

        public int Alto
        {
            get { return alto; }
            set { alto = (value <= 0) ? 1 : value; }
        }

        public int Espesor
        {
            get { return espesor; }
            set { espesor = (value <= 0) ? 1 : value; }
        }

        public int Area => area;
        public int Volumen => volumen;

        // Definimos constructor
        public Prisma()
        {
            Console.WriteLine("Ingrese el Ancho:");
            ancho = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el Alto:");
            alto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el Espesor:");
            espesor = Convert.ToInt32(Console.ReadLine());
        }

        // Métodos de la clase Prisma
        public void CalcularVolumen()
        {
            volumen = ancho * alto * espesor;
        }

        public void CalcularArea()
        {
            int a1 = 2 * CalcularRectangulo(ancho, alto);
            int a2 = 2 * CalcularRectangulo(ancho, espesor);
            int a3 = 2 * CalcularRectangulo(alto, espesor);

            area = a1 + a2 + a3;
        }

        private int CalcularRectangulo(int a, int b)
        {
            return a * b;
        }

        // Sobrescribimos ToString
        public override string ToString()
        {
            string mensaje = $"Ancho {ancho} Alto {alto} Espesor {espesor} ";
            mensaje += $"Área {area} Volumen {volumen}";
            return mensaje;
        }

        public void ImprimirResultado()
        {
            Console.WriteLine($"El área es {area}, volumen es {volumen}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Clase 74
            Console.WriteLine("\n=== Clases en C# ===");

            // =======================================
            // 1. Ejemplo Clases
            // =======================================
            Console.WriteLine("\n--- Ejemplo 1: Clase Cubo ---");

            Cubo miCubo = new Cubo { lado = 7 };
            Cubo tuCubo = new Cubo { lado = 8 };

            miCubo.CalcularArea();
            miCubo.CalcularVolumen();
            tuCubo.CalcularArea();
            tuCubo.CalcularVolumen();

            Console.WriteLine($"Área = {miCubo.area}, Volumen = {miCubo.volumen}");
            Console.WriteLine($"Área = {tuCubo.area}, Volumen = {tuCubo.volumen}");

            // Clase 75
            Console.WriteLine("\n=== Clases 2 y 3 en C# ===");

            Console.WriteLine("\n--- Ejemplo 2: Clase Prisma ---");

            Prisma miPrisma = new Prisma();
            miPrisma.CalcularArea();
            miPrisma.CalcularVolumen();

            Console.WriteLine(miPrisma.ToString());
            miPrisma.ImprimirResultado();

            Console.WriteLine("\n--------------------------");
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}