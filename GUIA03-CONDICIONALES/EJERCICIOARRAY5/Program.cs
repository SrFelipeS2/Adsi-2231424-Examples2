using System;

namespace EJERCICIOARRAY5
{
    class Program
    {
        static void MainT(string[] args)
        {
            /*5. Diseñe un algoritmo que lea un número cualquiera y lo busque en el vector X, el cual tiene
almacenados 12 elementos. Escribir la posición donde se encuentra almacenado el número en el
vector o el mensaje “NO” si no lo encuentra.*/
            Console.WriteLine("Hello World!");
            double[] valor= { 0,1,2,3,4,5,6,7,8,9,10,11,12};
            Console.WriteLine("POR FAVOR INGRESE UN NUMERO CUALQUIERA : ");
            _ = double.TryParse(Console.ReadLine(), out double numero);
            if (numero < 0 || numero > 12)
            {
                Console.WriteLine("NO SE ENCONTRARON RESULTADOS EN LA BUSQUEDA : ");
            }
            else
            {
                Console.WriteLine("LA POSICION EN LA QUE SE ENCUENTRA EL VALOR QUE INGRESO ES ; ");
                for (int i = 0; i < valor.Length; i++)
                {
                    if (valor[i] == numero)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            
        }
    }
}
