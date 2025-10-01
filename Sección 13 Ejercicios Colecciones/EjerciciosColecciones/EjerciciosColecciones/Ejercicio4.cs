using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosColecciones
{
    internal class Ejercicio4
    {
        static void Main4()
        {
            Queue<string> colaNombres = new Queue<string>();

            colaNombres.Enqueue("Ana");
            colaNombres.Enqueue("Juan");
            colaNombres.Enqueue("Pedro");
            colaNombres.Enqueue("Maria");

            Console.WriteLine("📌 Nombres en orden de llegada:");
            foreach (string nombre in colaNombres)
            {
                Console.WriteLine(nombre);
            }

            // Eliminamos el primero
            colaNombres.Dequeue();

            Console.WriteLine("\n📌 Nombres después de eliminar el primero:");
            foreach (string nombre in colaNombres)
            {
                Console.WriteLine(nombre);
            }
        }
    }
}
