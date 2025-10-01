using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosEstructuras
{
    internal class Ejercicio2
    {

        struct Producto
        {
            public string Nombre;
            public decimal Precio;
            public int CantidadEnStock;

            public override string ToString()
            {
                return $"Producto: {Nombre}, Precio: {Precio}, Stock: {CantidadEnStock}";
            }

            public decimal ValorInventario()
            {
                return Precio * CantidadEnStock;
            }
        }

        class Program2
        {
            static void Main2(string[] args)
            {
                Producto[] productos = new Producto[5];
                decimal valorTotal = 0;

                for (int i = 0; i < productos.Length; i++)
                {
                    Console.WriteLine($"\nIngrese los datos del producto {i + 1}:");

                    Console.Write("Nombre: ");
                    productos[i].Nombre = Console.ReadLine();

                    Console.Write("Precio: ");
                    productos[i].Precio = Convert.ToDecimal(Console.ReadLine());

                    Console.Write("Cantidad en stock: ");
                    productos[i].CantidadEnStock = Convert.ToInt32(Console.ReadLine());

                    valorTotal += productos[i].ValorInventario();
                }

                Console.WriteLine("\nInventario:");
                foreach (var producto in productos)
                {
                    Console.WriteLine(producto.ToString());
                }

                Console.WriteLine($"\nValor total del inventario: {valorTotal}");

                Console.ReadKey();
            }
        }


        // Funciona

    }
}
