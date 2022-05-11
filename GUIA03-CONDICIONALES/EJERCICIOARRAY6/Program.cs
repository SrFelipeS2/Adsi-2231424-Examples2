using System;

namespace EJERCICIOARRAY6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Diseñe un algoritmo que lea dos vectores A y B de 7 elementos cada uno y multiplique el primer
elemento de A con el último elemento de B y luego el segundo elemento de A por el sexto elemento
de B y así sucesivamente hasta llegar al séptimo elemento de A por el primer elemento de B. El
resultado de la multiplicación almacenarlo en un vector C. Mostrar el resultado.*/
            int POSVECT;
            Console.WriteLine("POR FAVOR INGRESE LA CANTIDAD DE POSCICIONES EN EL VECTOR : ");
            _ = int.TryParse(Console.ReadLine(), out POSVECT);
            double[] vectorA;
            vectorA = new double[POSVECT];
            double[] vectorB;
            vectorB = new double[POSVECT];
            double[] vectorC;
            vectorC = new double[POSVECT];

            for (int i = 0; i < vectorA.Length; i++)
            {
                Console.WriteLine("POR FAVOR INGRESE EL NUMERO QUE VA A ASIGNAR EN LA POSICION # " + i + " DEL VECTOR A");
                vectorA[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < vectorB.Length; i++)
            {
                Console.WriteLine("POR FAVOR INGRESE EL NUMERO QUE VA A ASIGNAR EN LA POSICION # " + i + " DEL VECTOR B");
                vectorB[i] = double.Parse(Console.ReadLine());
            }
            Array.Reverse(vectorB);
            Console.WriteLine("EL RESULTADO DE LA MULTIPLICACION AL INVERTIR UNO DE LOS DOS VECTORES ES: ");
            for (int i = 0; i < vectorC.Length; i++)
            {
                Console.WriteLine(vectorC[i]=vectorA[i]*vectorB[i]);
            }
        }
    }
}
