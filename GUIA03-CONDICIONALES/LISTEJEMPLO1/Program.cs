using System;
using System.Collections.Generic;
using System.Collections;

namespace LISTEJEMPLO1
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARACION O DEFINICION DE LA LISTA
            List<string> listadecolores = new List<string>();
            List<string> listaFrutas = new List<string>();
            List<double> listaNotas = new List<double>();
            //AGREGAR ELEMENTOS A LA LISTA
            listadecolores.Add("AMARILLO");
            listadecolores.Add("ROJO");
            listadecolores.Add("BLANCO");
            listadecolores.Add("NEGRO");

            Console.WriteLine("LA LISTA TIENE : " + listadecolores.Count + "elementos");
            //ACCESO A LOS ELEMTOS DE LSTA
            Console.WriteLine("elementos en pocision 0: " + listadecolores[0]);
            listadecolores[1] = "GRIS";
            Console.WriteLine("elementos en pocision 1: " + listadecolores[1]);
            Console.WriteLine("************************************");
            for (int i = 0; i < listadecolores.Count; i++)
            {
                Console.WriteLine("elementos " + i + ": " + listadecolores[i]);
            }
            Console.WriteLine("************************************");
            listadecolores.Sort();
            foreach (string color in listadecolores)
            {
                Console.WriteLine("color: " + color );
            }
            Console.WriteLine("************************************");

            Console.WriteLine("digite la cantidad de frutas");
            _ = int.TryParse(Console.ReadLine(), out int cant1);
            //Solicitar los n datos para ingresar a la lista
            for (int i = 0; i < cant1; i++)
            {
                Console.WriteLine("Ingrese una fruta");
                listaFrutas.Add(Console.ReadLine());
            }
            Console.WriteLine("************************************");
            // Visualización elementos lista
            listaFrutas.Sort();
            foreach(string item in listaFrutas)
            {
                Console.WriteLine("Fruta: " + item);
            }
            Console.WriteLine("************************************");
            Console.WriteLine("Digite la cantidad de notas");
            _ = int.TryParse(Console.ReadLine(), out int cant2);
            double suma = 0, promedio;
            for (int i = 0; i < cant2; i++)
            {
                Console.WriteLine("Ingrese una nota");
                _ = double.TryParse(Console.ReadLine(), out double nota);
                listaNotas.Add(nota);
            }
            Console.WriteLine("************************************");
            // Visualización elementos lista
            foreach (double item in listaNotas)
            {
                //suma = suma + item;
                suma += item;
            }
            promedio = suma / cant2;
            Console.WriteLine("El promedio es: " + promedio);
            
        }
    }
}
