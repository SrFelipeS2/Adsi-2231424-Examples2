using System;

namespace EJERCICIOARRAY1
{
    class Program
    {
        static void Main(string[] args)
        {
/*1. Calcular el promedio de 50 valores almacenados en un vector. Determinar además cuantos son
mayores que el promedio, imprimir el promedio, el número de datos mayores que el promedio y una
lista de valores mayores que el promedio.*/
            double mayorP = 0, promedio, suma = 0;
            int  posvector;
            Console.WriteLine("POR FAVOR INGRESE LAS POSICIONES DEL VECTOR: " );
            /*_ = int.TryParse(Console.ReadLine(), out posvector);*/
            posvector = int.Parse(Console.ReadLine());
            double[] valor;
            valor = new double[posvector];
            for (int i = 0; i < valor.Length; i++)
            {
                Console.WriteLine("POR FAVOR INGRESE EL VALOR : " + (i + 1));
                valor[i] = double.Parse(Console.ReadLine());
                suma += valor[i];
                Console.WriteLine("************************************");
            }
            promedio = suma / posvector;
            Console.WriteLine("EL LISTADO DE  VALORES QUE SON MAYORES AL PROMEDIO SON");
            for (int i = 0; i < valor.Length; i++)
            {
                if (valor[i] > promedio)
                { 
                    Console.WriteLine(valor[i]);
                    mayorP ++;
                }
            }
            Console.WriteLine("************************************");
            Console.WriteLine("EL PROMEDIO DE LOS VALORES ES: "+ promedio);
            Console.WriteLine("LA CANTIDAD DE VALORES QUE SON MAYORES AL PROMEDIO SON: " + mayorP);

        }
    }
}
