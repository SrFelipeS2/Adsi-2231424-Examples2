using System;

namespace form4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Suponga que se tiene un conjunto de calificaciones de un grupo de 40 alumnos.
             * Realizar un algoritmo para calcular la calificación promedio y la 
             * calificación más baja de todo el grupo.*/
            int i;
            double notas, prom=0, califb=500, suma=0;
            for ( i = 1; i <=40; i++)
            {
                Console.WriteLine("digite la nota del estudiante");
                _ = double.TryParse(Console.ReadLine(), out notas);
                if(notas < califb)
                {
                    califb = notas;
                }
                suma += notas;
            }
            prom = suma / (i-1);
            Console.WriteLine("la nota mas baja es: " + califb +
                " el pormedio de la clase es: " +prom);

        }
    }
}
