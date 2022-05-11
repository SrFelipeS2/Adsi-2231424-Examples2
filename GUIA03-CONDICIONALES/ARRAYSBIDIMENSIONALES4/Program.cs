using System;

namespace ARRAYSBIDIMENSIONALES4
{
    class Program
    {
        static void Main(string[] args)
        {
         
            bool perdiste = false;
            int[,] cuadromagico;
            int suma = 0;
            int[] columnas;
            int[] filas;
            int[] diagonales = new int [2];

            Console.WriteLine("por favor digite la cantidad de filas  y columnas que va a tener el cuadro magico");
            _ = int.TryParse(Console.ReadLine(), out int dimensiones );
            Console.WriteLine("\n antes de llenar el cuadro magico recuerda las siguientes reglas:1" +
                " La suma de los números de cualquier línea (horizontal, vertical o diagonal) será siempre la misma" +
                " \n 2 Los números de un cuadrado mágico deben ser todos diferentes. \n recuerda tambien que las dimensiones" +
                " minimas de un cuadrado magico son de 3 filas por 3 columnas \n a medida que vas llenando los numeros " +
                "el prgrama te indicara especificamente en que casilla del cuadro agico estas asignando el valor," +
                " debes guiarte de esto para que hagas tus calculos y asi poder completar el cuadro magico");
            columnas = new int[dimensiones];
            filas = new int[dimensiones];
           
                Console.WriteLine("*********************************");
                cuadromagico = new int[dimensiones, dimensiones];
                for (int f = 0; f < cuadromagico.GetLength(0); f++)/*este es el ciclo para recorrer filas de la matriz*/
                {
                    for (int c = 0; c < cuadromagico.GetLength(1); c++)/*este es el ciclo para recorrer las columnas*/
                    {
                        Console.WriteLine("ingrese el numero que va a ir en la poscicion de la fila #" + f +
                            " y en la posicion de la columna #" + c);

                        cuadromagico[f, c] = int.Parse(Console.ReadLine());
                        Console.WriteLine("*********************************");

                    }
                }
                for (int f = 0; f < cuadromagico.GetLength(0); f++)/*este es el ciclo para recorrer filas de la matriz*/
                {

                    for (int c = 0; c < cuadromagico.GetLength(1); c++)/*este es el ciclo para recorrer las columnas*/
                    {
                        suma += cuadromagico[f, c];

                    }
                    filas[f] = suma;
                    suma = 0;

                }
                for (int f = 0; f < cuadromagico.GetLength(1); f++)/*este es el ciclo para recorrer filas de la matriz*/
                {

                    for (int c = 0; c < cuadromagico.GetLength(0); c++)/*este es el ciclo para recorrer las columnas*/
                    {
                        suma += cuadromagico[c, f];
                    }
                    columnas[f] = suma;
                    suma = 0;

                }
                for (int i = 0; i < cuadromagico.GetLength(0); i++)
                {
                    suma += cuadromagico[i, i];

                }
                diagonales[0] = suma;
                Console.WriteLine("la suma de las diagonal de izquierda a derecha es :" + diagonales[0]);
                suma = 0;
                Console.WriteLine("*********************************");
                /* for (int i = 0,j=cuadromagico.GetLength(1)-1; i < cuadromagico.GetLength(0); i++,j--)
                 {
                     suma += cuadromagico[i, j];
                     Console.WriteLine(cuadromagico[i, j]);
                 }*/
                for (int f = 0; f < cuadromagico.GetLength(0); f++)/*este es el ciclo para recorrer filas de la matriz*/
                {
                    for (int c = dimensiones - 1; c >= 0; c--)/*este es el ciclo para recorrer las columnas*/
                    {
                        suma += cuadromagico[f, c];
                        Console.WriteLine(cuadromagico[f, c]);
                        dimensiones = dimensiones - 1;
                        break;
                    }

                }
                diagonales[1] = suma;
                Console.WriteLine("la suma de las diagonale de derechas a izquierda es :" + diagonales[1]);
                Console.WriteLine("*********************************");
                for (int c = 0; c < filas.Length; c++)
                {
                    Console.WriteLine("la suma de las filas  es :" + filas[c]);

                }
                Console.WriteLine("*********************************");
                for (int f = 0; f < columnas.Length; f++)
                {
                    Console.WriteLine("la suma de las columnas  es :" + columnas[f]);

                }
                for (int f = 0; f < columnas.Length; f++)
                {
                    if (columnas[f] != filas[f] || columnas[f] != diagonales[0] || columnas[f] != diagonales[1] || filas[f]
                        != diagonales[0] || filas[f] != diagonales[1])
                    {
                        perdiste = true;
                    }
                }
                Console.WriteLine("*********************************");
                if (perdiste == false)
                {
                    Console.WriteLine("felicitaciones has completado el cuadro magico");
                }
                else
                {
                    Console.WriteLine("fallaste intentalo nuevamente");
                }

            
        }
    }
}
