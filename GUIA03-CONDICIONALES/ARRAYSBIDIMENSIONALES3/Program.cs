using System;
using System.Collections;

namespace ARRAYSBIDIMENSIONALES3
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int mayor = 0;
            int indice=0;
            int[] articulo;
            int[] turno;
            string[] nombre;
            Console.WriteLine("por favor digite la cantidad de Articulos que se trabajaron en el dia");
            _ = int.TryParse(Console.ReadLine(), out int articulos);
            Console.WriteLine("*********************************");
            articulo = new int[articulos];
            nombre = new string [articulos];
            Console.WriteLine("por favor digite la cantidad de Turnos  que se trabajaron en el dia ");
            _ = int.TryParse(Console.ReadLine(), out int turnos);
            turno = new int[turnos];
            Console.WriteLine("*********************************");
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine("por favor digite el nombre de el articulo # " + (i+1) );
                nombre[i] = Console.ReadLine();
            }
            int[,] matriz2 = new int[articulos, turnos];/*declaracion eh inicializacion*/
            for (int f = 0; f < matriz2.GetLength(0); f++)/*este es el ciclo para recorrer filas de la matriz*/
            {
                for (int c = 0; c < matriz2.GetLength(1); c++)/*este es el ciclo para recorrer las columnas*/
                {
                    Console.WriteLine("EN EL ARTICULO #" + nombre[f] + " INGRESE LA PRODUCCION EN EL TURNO #" + c);
                    matriz2[f, c] = int.Parse(Console.ReadLine());
                    Console.WriteLine("*********************************");
                }
            }
            for (int f = 0; f < matriz2.GetLength(0); f++)/*este es el ciclo para recorrer filas de la matriz*/
            { 
                for (int c = 0; c < matriz2.GetLength(1); c++)/*este es el ciclo para recorrer las columnas*/
                {
                    suma += matriz2[f, c];
                }
                articulo[f] = suma;
                if (articulo[f] > mayor)
                {
                    mayor = articulo[f];
                    indice = f;
                }
                suma = 0;
            }
            for (int f = 0; f < matriz2.GetLength(1); f++)/*este es el ciclo para recorrer filas de la matriz*/
            {
                for (int c = 0; c < matriz2.GetLength(0); c++)/*este es el ciclo para recorrer las columnas*/
                {
                    suma += matriz2[c, f];
                }
                turno[f] = suma;
                suma = 0;
            }
            for(int c = 0; c < articulo.Length; c++)
            {
                Console.WriteLine("total de produccion por articulo "+ nombre[c] +" "+ articulo[c]);
            }
            for (int f = 0; f < turno.Length; f++)
            {
                Console.WriteLine("total de produccion por turno # " + (f+1) + " " + turno[f]);
            }
                Console.WriteLine("el articulo con mayor produccion es: " + nombre[indice] + 
                    " y su valor de produccion fue de " + mayor);
        }
    }
}
