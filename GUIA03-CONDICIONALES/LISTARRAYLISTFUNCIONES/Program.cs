using System;
using System.Collections;

namespace LISTARRAYLISTFUNCIONES
{
    class Program
    {
        static void Main(string[] args)
        {
            string cant2,busqueda,busqueda1;
            int posicion, posicion1, INFO;
            bool cant3;
            /*declaracion del arraylist*/
            ArrayList componentes = new ArrayList();
            ArrayList videojuegos = new ArrayList();
            /*adicion de elemntos a la lista*/
            componentes.Add("procesador");
            componentes.Add("RAM");
            componentes.Add("MotherBoard");
            componentes.Add("SSD");
            componentes.Add("TarjetaDeVideo");
            componentes.Add("FuenteDePoder");
            componentes.Add("Refrigeracion");
            /*accediendo a los elementos de la lista*/
            Console.WriteLine("*********************************");
            Console.WriteLine(componentes[0]);
            Console.WriteLine(componentes[1]);
            Console.WriteLine(componentes[2]);
            /*reasignando valores en la lista*/
            componentes[1] = "MemoriaRAM";
            /*mostrando el cambio en consola*/
            Console.WriteLine("*********************************");
            Console.WriteLine(componentes[1]);
            /*accediendo a todos los elementos de la lista y mostrandolos*/
            Console.WriteLine("*********************************");
            foreach (string mostrar in componentes)
            {
                Console.WriteLine("componentes: " + mostrar);
            }
            /*insertando un elemento a toda la lista, en una posicion especifica y mostrandolo*/ 
            Console.WriteLine("*********************************");
            componentes.Insert(4, "ventiladores");
            foreach (string mostrar in componentes)
            {
                Console.WriteLine("componentes: " + mostrar);
            }
            Console.WriteLine("*********************************");
            /* utilizamos el sort para organizar una lista recien hecha*/
            Console.WriteLine("digite la cantidad de videojuegos");
            _ = int.TryParse(Console.ReadLine(), out int cant1);
            for (int i = 0; i < cant1; i++)
            {
                Console.WriteLine("Ingrese el nombre del juego");
                videojuegos.Add(Console.ReadLine());
            }
            videojuegos.Sort();
            foreach (string item in videojuegos)
            {
                Console.WriteLine(" videojuego: " + item);
            }
            Console.WriteLine("*********************************");
            /*utilizaos el sort para organizar una lista ya creada*/
            componentes.Sort();
            foreach (string mostrar in componentes)
            {
                Console.WriteLine("componentes: " + mostrar);
            }
            Console.WriteLine("*********************************");
            /*busqueda de un elemento dentro de la lista*/
            Console.WriteLine("ingrese el valor de busqueda");
            cant2=Console.ReadLine();
            cant3 = componentes.Contains(cant2);
            if (cant3 == true)
            {
                Console.WriteLine("el elemnto se encuentra en la lista"); 
            }
            else
            {
                Console.WriteLine("el elemnto  no se encuentra");
            }
            Console.WriteLine("*********************************");
            /*busqueda con el indexof*/
            Console.WriteLine("ingrese el valor de busqueda");
            busqueda = Console.ReadLine();
            posicion = componentes.IndexOf(busqueda);
            if (posicion != -1)
            {
                Console.WriteLine("el elemnto se encuentra en la posicion numero: " + posicion);
            }
            else
            {
                Console.WriteLine("el elemnto no se encontro ");
            }
            Console.WriteLine("*********************************");
            componentes.Add("SSD");
            foreach (string mostrar in componentes)
            {
                    Console.WriteLine("componentes: " + mostrar);
            }
            Console.WriteLine("ingrese el valor de busqueda");
            Console.WriteLine("*********************************");
            busqueda1 = Console.ReadLine();
            posicion1 = componentes.LastIndexOf(busqueda1);
            Console.WriteLine("el elemnto se encuentra en la posicion numero: " + posicion1);
            Console.WriteLine("*********************************");
            INFO = componentes.Count;
            Console.WriteLine("LA LISTA TIENE EL SIGUIENTE NUMERO DE COMPONETES ANTES DE BORRARLA "+ INFO);
            componentes.Clear();
            Console.WriteLine("*********************************");
            INFO = componentes.Count;
            Console.WriteLine("La lista se elimino " + INFO);



        }
    }
}
