using System;

namespace EJERCICIOS_FOR_NUM8
{
    class Program
    {

        static void Main(string[] args)
        {
           
            double n, numero, num_mayor = 0;
            int i=1;
            Console.WriteLine("buen dia digite cuantos numeros desea registrar");
            _ = double.TryParse(Console.ReadLine(), out n);
            while (i <= n)
            {
                Console.WriteLine("ingrese el numero" + i);
                _ = double.TryParse(Console.ReadLine(), out numero);
                if (i == 1)
                {
                    num_mayor = numero;
                }
                else if (numero > num_mayor)
                {
                    num_mayor = numero;
                }
                i++;
            }
            Console.WriteLine("el numero mayor es: " + num_mayor);
        }
    }
}