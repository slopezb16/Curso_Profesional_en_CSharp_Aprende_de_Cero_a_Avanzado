using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen
{
    /* Un almacén de escritorios hace los siguientes descuentos: 
     * si el cliente compra menos de 5 unidades se le da un descuento del 10% sobre la compra; 
     * si el número de unidades es nayor o igual a cinco pero menos de 10 se le otorga un descuento del 20% y, 
     * si son 10 o más se le da un descuento del 40%.
     * Hacer un programa que determine cuánto debe pagar un cliente si el valor de cada escritorios de $650 dolares */
    internal class Program
    {
        /* tener en cuenta
         * Numero de escritorios
         * Valor a Pagar
         * Realizar SubProgramas (Metodos y Funciones)
         * Metodo - > PedirDatos() - Numero de escritorios
         * Metodo - > CalcularValor() - Calcular precio - Numero de escritorios
         * Metodo - > MostrarResultados() - Valor a pagar - Recibo - total - descuento - valor a pagar
         */

        // Constante del precio unitario
        const double PRECIO_UNITARIO = 650;

        static void Main(string[] args)
        {
            int numeroEscritorios;
            double valor_A_Pagar; // cambiado a double para coincidir con CalcularValor()

            //PedirDatos(out numeroEscritorios); // otra forma
            numeroEscritorios = PedirDatos();
            valor_A_Pagar = CalcularValor(numeroEscritorios);
            MostrarResultados(numeroEscritorios, valor_A_Pagar);

            Console.ReadKey(); // para que no se cierre la consola de inmediato
        }

        // Método que pide la cantidad de escritorios
        //static void PedirDatos(out int numeroEscritorios)
        static int PedirDatos()
        {
            Console.Write("Ingrese el número de escritorios a comprar: ");
            int numeroEscritorios = int.Parse(Console.ReadLine());
            return numeroEscritorios;
        }

        // Función que calcula el valor total con descuento
        static double CalcularValor(int numeroEscritorios)
        {
            double subtotal = numeroEscritorios * PRECIO_UNITARIO;
            double descuento = 0;

            if (numeroEscritorios < 5)
            {
                descuento = subtotal * 0.10;
            }
            else if (numeroEscritorios >= 5 && numeroEscritorios < 10)
            {
                descuento = subtotal * 0.20;
            }
            else
            {
                descuento = subtotal * 0.40;
            }

            return subtotal - descuento;
        }

        // Método que muestra los resultados al cliente
        static void MostrarResultados(int numeroEscritorios, double total)
        {
            double subtotal = numeroEscritorios * PRECIO_UNITARIO;
            double descuento = subtotal - total;

            Console.WriteLine("\n----- RECIBO DE COMPRA -----");
            Console.WriteLine($"Cantidad de escritorios: {numeroEscritorios}");
            Console.WriteLine($"Precio unitario: ${PRECIO_UNITARIO}");
            Console.WriteLine($"Subtotal: ${subtotal}");
            Console.WriteLine($"Descuento aplicado: ${descuento}");
            Console.WriteLine($"TOTAL A PAGAR: ${total}");
        }
    }
}