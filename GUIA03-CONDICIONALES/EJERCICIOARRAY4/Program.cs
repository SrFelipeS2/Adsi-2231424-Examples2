using System;

namespace EJERCICIOARRAY4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4. Almacenar 8 números en un vector, almacenarlos en otro vector en orden inverso al vector original
e imprimir el vector resultante.*/
        
            double[] A;
            A = new double[8];
            double[] B;
            B =  A;
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine("POR FAVOR INGRESE EL VALOR : " + (i + 1));
                A[i] = double.Parse(Console.ReadLine());  
            }
            Array.Reverse(B);
            Console.WriteLine("****************************************************");
            for (int i = 0; i < B.Length; i++)
            {
                
                Console.WriteLine(+B[i]);
            }
               
        }
    }
}
