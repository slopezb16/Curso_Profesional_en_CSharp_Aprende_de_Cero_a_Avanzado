using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosEstructuras
{
    internal class Ejercicio6
    {
        static void Main()
        {
            // Solicitar monto de la factura
            Console.Write("Ingrese el monto de la factura: ");
            double montoFactura = double.Parse(Console.ReadLine());

            // Solicitar si es cliente VIP
            Console.Write("¿Es cliente VIP? (1 = Sí, 0 = No): ");
            int respuestaVIP = int.Parse(Console.ReadLine());

            // Validar si la respuesta ingresada es correcta (0 o 1)
            if (respuestaVIP != 0 && respuestaVIP != 1)
            {
                Console.WriteLine($"Ingresaste el número {respuestaVIP}, el cual no es válido. Solo se permite 1 o 0.");
            }
            else
            {
                // Convertimos la respuesta a bool
                bool esVIP = respuestaVIP == 1;

                // Validamos las condiciones con OR (Factura > 100 O ser VIP)
                if (montoFactura > 100 || esVIP)
                {
                    // Conjunción adicional: si factura > 100 Y VIP → acceso especial
                    if (montoFactura > 100 && esVIP)
                    {
                        Console.WriteLine("¡Acceso VIP Premium! Cumples ambas condiciones.");
                    }
                    else
                    {
                        Console.WriteLine("Acceso concedido a la zona de clientes especiales.");
                    }
                }
                else
                {
                    Console.WriteLine("No tienes acceso a la zona de clientes especiales.");
                }
            }
        }
    }
}
