using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coleccion_Hashtable
{
    internal class EjemploCurso
    {
        static void Main2(string[] args)
        {
            int opcion = 0;
            decimal numero = 0;
            string key = "";
            bool encontrado = false;

            Hashtable miTabla = new Hashtable();// declaramos nuestro hashtable

            do
            {
                //menu de opciones 
                Console.WriteLine("1. Add");
                Console.WriteLine("2. object");
                Console.WriteLine("3. Clear");
                Console.WriteLine("4. Contains o containsKey");
                Console.WriteLine("5. ContainsValue");
                Console.WriteLine("6. Remove");
                Console.WriteLine("7. Salir");
                Console.WriteLine("Escoge un opción");
                opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 1)
                {
                    //Pedimos el valor a introducir
                    Console.WriteLine("Ingresa precio del producto");
                    numero = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Ingresa nombre del producto");
                    key = Console.ReadLine();

                    //Adicionamos los datos
                    miTabla.Add(key, numero);

                }
                if (opcion == 2)
                {
                    //obtener elemento
                    object llave = miTabla[key];

                    //mostramos el elemento tomado
                    Console.WriteLine("El valor obtenido es: {0}", llave);

                }
                if (opcion == 3)
                {
                    //Limpiamos todos los elementos
                    miTabla.Clear();


                }
                if (opcion == 4)
                {
                    //Pedimos el nombre a mostrar 
                    Console.WriteLine("Ingresa el nombre a encontrar");
                    key = Console.ReadLine();

                    //miramos si el nombre se encuentra
                    encontrado = miTabla.ContainsKey(key);

                    Console.WriteLine("Encontrado: {0}", encontrado);


                }
                if (opcion == 5)
                {
                    //Pedimos el valor a observar
                    Console.WriteLine("Ingresa el precio a observar");
                    numero = Convert.ToDecimal(Console.ReadLine());

                    //miramos si el elemento se encuentra
                    encontrado = miTabla.ContainsValue(numero);

                    Console.WriteLine("Precio encontrado: {0}", encontrado);


                }
                if (opcion == 6)
                {
                    //Removemos el hashtable
                    miTabla.Remove(key);
                    Console.WriteLine("Elemento borrado: {0}", key);


                }

                // mostrar la información del Stack 
                Console.WriteLine("");
                foreach (DictionaryEntry tabla in miTabla)
                {
                    Console.WriteLine("key = {0}, value= {1}", tabla.Key, tabla.Value);
                    Console.WriteLine("");
                    Console.WriteLine(" _____");

                }

            } while (opcion != 7);

            Console.ReadKey();
        }
    }
}
