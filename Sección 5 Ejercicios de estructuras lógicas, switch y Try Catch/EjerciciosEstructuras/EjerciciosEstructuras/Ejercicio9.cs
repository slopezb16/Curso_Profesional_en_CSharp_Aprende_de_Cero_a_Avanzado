using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosEstructuras
{
    internal class Ejercicio9
    {
        static void Main()
        {
            Console.WriteLine("=== Calificación de Notas ===");

            // Solicitar la nota
            Console.Write("Ingrese la nota del estudiante (0 - 100): ");
            int nota = Convert.ToInt32(Console.ReadLine());

            // Validar rango
            if (nota < 0 || nota > 100)
            {
                Console.WriteLine("Error: La nota ingresada no es válida. Debe estar entre 0 y 100.");
            }
            else
            {
                // Calcular decena para el switch
                int decena = nota / 10;

                string calificacion;

                switch (decena)
                {
                    case 10: // Para el 100 exacto
                    case 9:
                        calificacion = "A";
                        break;
                    case 8:
                        calificacion = "B";
                        break;
                    case 7:
                        calificacion = "C";
                        break;
                    case 6:
                        calificacion = "D";
                        break;
                    default:
                        calificacion = "F";
                        break;
                }

                Console.WriteLine($"La calificación del estudiante es: {calificacion}");
            }

            Console.ReadKey();
        }
    }
}
