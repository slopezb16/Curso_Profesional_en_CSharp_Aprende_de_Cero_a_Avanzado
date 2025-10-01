using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosEstructuras
{
    internal class Ejercicio4
    {
        static void Main4()
        {
            // Preguntar si es cliente nuevo
            Console.Write("¿Cliente nuevo? (Sí/No): ");
            string respuestaCliente = Console.ReadLine();

            // Preguntar si ha hecho compras antes
            Console.Write("¿Has hecho compras antes? (Sí/No): ");
            string respuestaCompras = Console.ReadLine();

            // Declarar variables booleanas
            bool cliente = (respuestaCliente.ToLower() == "sí");
            bool compras = (respuestaCompras.ToLower() == "sí");

            // Validación con OR (||)
            if (cliente || compras)
            {
                Console.WriteLine("Usted es elegible para un descuento en su compra.");
            }
            else
            {
                Console.WriteLine("No hay descuento disponible para esta compra.");
            }
        }
    }
}
