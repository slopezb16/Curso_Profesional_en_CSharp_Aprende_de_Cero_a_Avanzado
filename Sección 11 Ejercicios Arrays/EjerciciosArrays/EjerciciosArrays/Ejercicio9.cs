using System;

namespace EjerciciosArrays
{
    internal class Ejercicio9
    {
        static void Main9(string[] args)
        {
            string[] nombres = { "Daniel", "Carlos", "María", "Ana" };

            Console.Write("Ingrese el nombre a buscar: ");
            string nombreBuscar = Console.ReadLine();

            bool encontrado = BuscarElemento(nombres, nombreBuscar);

            if (encontrado)
                Console.WriteLine($"El nombre \"{nombreBuscar}\" SÍ está en el array.");
            else
                Console.WriteLine($"El nombre \"{nombreBuscar}\" NO se encuentra en el array.");

            Console.ReadKey();
        }

        // Método que recibe un array de cadenas y la cadena a buscar
        static bool BuscarElemento(string[] arr, string valor)
        {
            foreach (string elemento in arr)
            {
                if (elemento.Equals(valor, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
