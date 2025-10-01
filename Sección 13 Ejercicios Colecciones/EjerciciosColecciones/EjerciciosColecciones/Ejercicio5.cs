using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosColecciones
{
    internal class Ejercicio5
    {
        static void Main5()
        {
            Queue<string> colaPedidos = new Queue<string>();

            colaPedidos.Enqueue("Pizza");
            colaPedidos.Enqueue("Hamburguesa");
            colaPedidos.Enqueue("Ensalada");

            Console.WriteLine("📌 Procesando pedidos en orden:");
            while (colaPedidos.Count > 0)
            {
                string pedido = colaPedidos.Dequeue();
                Console.WriteLine($"✅ Pedido listo: {pedido}");
            }
        }
    }
}
