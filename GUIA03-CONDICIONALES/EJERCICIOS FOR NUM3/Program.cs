using System;

namespace EJERCICIOS_FOR_NUM3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3. Leer 20 números e imprimir cuantos son positivos, 
             * cuantos negativos y cuantos cero.*/

            double num, numpos = 0, numneg = 0, cero = 0;
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("Ingrese un numero");
                _ = double.TryParse(Console.ReadLine(), out num);
                if (num > 0)
                {
                    numpos++;
                }
                else if ( num < 0)
                {
                    numneg++;   
                }
                else
                {
                   cero++;
                }
            }
            Console.WriteLine("los numeros psotivos son: " + numpos);
            Console.WriteLine("los numeros negativos son: " + numneg);
            Console.WriteLine("los ceros son: " + cero);
        }
    }
}
