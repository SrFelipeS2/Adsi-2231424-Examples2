using System;

namespace EJERCICIOS_FOR_NUM2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2. Leer 10 números e imprimir solamente los números positivos*/
            double numerospos;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Ingrese un numero");
                _ = double.TryParse(Console.ReadLine(), out numerospos);
                if (numerospos > 0) {
                Console.WriteLine("el numero" +
                    " es"+numerospos);
                }

            }
        }
    }
}
