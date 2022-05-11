using System;

namespace EJERCICIOS_FOR_NUM7
{
    class Program
    {

        static void Main(string[] args)
        {
            /*7. Encontrar el menor valor de un conjunto de n números dados.*/
            double  num_menor=0;
            int i=1;
            Console.WriteLine("buen dia digite cuantos numeros desea registrar");
            _ = double.TryParse(Console.ReadLine(), out double n);
            while (i <= n)
            {
                Console.WriteLine("ingrese el numero"+ i);
                _ = double.TryParse(Console.ReadLine(), out double numero);
                if (i==1)
                {
                    num_menor = numero;
                }
                else if (numero < num_menor)
                 {
                    num_menor = numero;
                }
                i++;
            }
            Console.WriteLine("el numero menor es: " + num_menor);
        }
    }
}
