using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosEstructuras
{
    internal class Ejercicio5
    {
        static void Main5()
        {
            // Solicitar datos al usuario
            Console.Write("Ingrese su calificación (0 - 100): ");
            int calificacion = int.Parse(Console.ReadLine());

            Console.Write("Ingrese sus días de asistencia (0 - 30): ");
            int asistencia = int.Parse(Console.ReadLine());

            // Validar si los datos están en el rango correcto
            if (calificacion > 100 || asistencia > 30)
            {
                Console.WriteLine($"Ingresaste puntaje: {calificacion} y asistencia: {asistencia}.");
                Console.WriteLine("Datos erróneos. Verifica los datos ingresados.");
            }
            else
            {
                // Validar si cumple ambas condiciones para aprobar
                if (calificacion > 70 && asistencia > 20)
                {
                    Console.WriteLine("¡Has aprobado el curso!");
                }
                else
                {
                    Console.WriteLine("Lo siento, reprobaste el curso.");
                }
            }
        }
    }
}
