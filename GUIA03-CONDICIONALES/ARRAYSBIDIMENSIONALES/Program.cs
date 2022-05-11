using System;

namespace ARRAYSBIDIMENSIONALES
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            Console.WriteLine("ARRAYS BIDIMENCIONALES");
            /* MANERA DE DECLARA UN ARRAY BIDIMENCIONAL*/
            /* int[,] matriz1; declaracion */
            /*matriz1 = new int[3, 2];/*inicializacion*/
            /*matriz2[2, 0] = 20; asignacion manual a una posicion del array bidimencional*/
            Console.WriteLine("por favor digite la cantidad de filas que va a tener la matriz");
            _ = int.TryParse(Console.ReadLine(), out int filas);
            Console.WriteLine("*********************************");
            Console.WriteLine("por favor digite la cantidad de columnas que va a tener la matriz");
            _ = int.TryParse(Console.ReadLine(), out int columnas);
            Console.WriteLine("*********************************");
            int[,] matriz2 = new int[filas, columnas];/*declaracion eh inicializacion*/
           
            for (int f = 0; f < matriz2.GetLength(0); f++)/*este es el ciclo para recorrer filas de la matriz*/
            { 
                for(int c = 0; c < matriz2.GetLength(1); c++)/*este es el ciclo para recorrer las columnas*/
                {
                    Console.WriteLine("ingrese el numero que va a ir en la poscicion de la fila #" + f + 
                        " y en la posicion de la columna #" + c);
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
            }
            Console.WriteLine("la suma de todos numeros almacenados en la matriz es igual a: " + suma);
        }
    }
}
