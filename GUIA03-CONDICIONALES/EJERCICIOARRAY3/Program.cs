using System;

namespace EJERCICIOARRAY3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3. Almacenar 15 números en un vector, imprimir cuantos son ceros, cuántos son negativos, cuantos
positivos. Imprimir además la suma de los negativos, la suma de los ceros y la suma de los positivos.*/
            int ceros=0, negativos=0, positivos=0;
            double sumneg = 0, sumpos = 0;
            double[] valor;
            valor = new double[15];
            for (int i = 0; i < valor.Length; i++)
            {
                Console.WriteLine("POR FAVOR INGRESE EL VALOR : " + (i + 1));
                valor[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("************************************");
            }
            for (int i = 0; i < valor.Length; i++)
            {
                if (valor[i] == 0)
                {
                    ceros++;
                }
                else if (valor[i] < 0)
                {
                    negativos++;
                    sumneg += valor[i];
                }
                else if (valor[i] > 0)
                {
                    positivos++;
                    sumpos += valor[i];
                }
            }
            Console.WriteLine("LA CANTIDAD DE CEROS QUE SE ALMACENARON EN EL VECTOR SON: " + ceros);
            Console.WriteLine("LA CANTIDAD DE NUMEROS POSITIVOS QUE SE ALMACENARON EN EL VECTOR SON: " + positivos);
            Console.WriteLine("LA CANTIDAD DE NUMEROS NEGATIVOS  QUE SE ALMACENARON EN EL VECTOR SON: " + negativos);
            Console.WriteLine("LA SUMA DE NUMEROS NEGATIVOS  QUE SE ALMACENARON EN EL VECTOR ES: " + sumneg);
            Console.WriteLine("LA SUMA DE NUMEROS POSITIVOS QUE SE ALMACENARON EN EL VECTOR ES: " + sumpos);
            Console.WriteLine("LA SUMA DE LOS CEROS  QUE SE ALMACENARON EN EL VECTOR ES IGUAL A 0 ");
        }
    }
}
