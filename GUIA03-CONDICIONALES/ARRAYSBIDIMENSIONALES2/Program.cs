using System;

namespace ARRAYSBIDIMENSIONALES2
{
    class Program
    {
        static void Main(string[] args)
        {
            int mayor=0;
            Console.WriteLine("por favor digite la cantidad de filas que va a tener la matriz");
            _ = int.TryParse(Console.ReadLine(), out int filas);
            Console.WriteLine("*********************************");
            Console.WriteLine("por favor digite la cantidad de columnas que va a tener la matriz");
            _ = int.TryParse(Console.ReadLine(), out int columnas);
            Console.WriteLine("*********************************");
            int[,] matriz2 = new int[filas, columnas];/*declaracion eh inicializacion*/

            for (int f = 0; f < matriz2.GetLength(0); f++)/*este es el ciclo para recorrer filas de la matriz*/
            {
                for (int c = 0; c < matriz2.GetLength(1); c++)/*este es el ciclo para recorrer las columnas*/
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
                    if (matriz2[f, c] > mayor)
                    {
                        mayor = matriz2[f, c];
                    }
                    
                }
            }
            Console.WriteLine("el numero de mayor valor almacenado en la matriz es: " + mayor);
        }
    }
}
