using System;

namespace EJERCICIOARRAY2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
  2. Llenar dos vectores A y B de 10 elementos cada uno, sumar el elemento uno del vector A con el
elemento uno del vector B y así sucesivamente hasta 10, almacenar el resultado en un vector C, e
imprimir el vector resultante.
             */
            double[] A;
            A = new double[10];
            double[] B;
            B = new double[10];
            double[] C;
            C = new double[10];
            Console.WriteLine("POR FAVOR INGRESE LOS 10 VALORES DEL PRIMER VECTOR");
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(" ESPACIO # : " + (i + 1));
                A[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("POR FAVOR INGRESE LOS 10 VALORES DEL SEGUNDO VECTOR");
            for (int i = 0; i < B.Length; i++)
            {
                Console.WriteLine(" ESPACIO # : " + (i + 1));
                B[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("EL VECTOR RESULTANTE ES: ");
            for (int i = 0; i < C.Length; i++)
            {
                C[i] = A[i]+B[i];
                Console.WriteLine(C[i]);
            }

           
        }
    }
}
