using System;

namespace EJERCICIOS_FOR_NUM1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Calcular el promedio de un alumno que tiene 7 calificaciones 
             * en la materia de Diseño Estructurado
               de Algoritmos.*/
            double notas, prom, suma=0;
            for (int i=1; i<=7; i++) {
                Console.WriteLine("buen dia digite sus notas");
                _ = double.TryParse(Console.ReadLine(), out notas);
                suma += notas;
            }
            prom = suma / 7;
            Console.WriteLine("el promedio de sus notas es: " + prom);

        }
    }
}
