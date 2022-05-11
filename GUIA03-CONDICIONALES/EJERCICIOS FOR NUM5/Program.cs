using System;

namespace EJERCICIOS_FOR_NUM5
{
    class Program
    {
        static void Main(string[] args)
        /*Calcular e imprimir la tabla de multiplicar de un número cualquiera. 
         * Imprimir el multiplicando, el multiplicador y el producto.*/
        {
            int num,multiplicacion, i;
            Console.WriteLine("ingrese cualquier numero");
            _ = int.TryParse(Console.ReadLine(), out num);
            for ( i = 1; i <= 10; i++)
            {
                multiplicacion = num * i;
                Console.WriteLine("multiplicando: "+ num +" multiplicador: " +i+" producto: " + multiplicacion);
            }

        }
    }
}
