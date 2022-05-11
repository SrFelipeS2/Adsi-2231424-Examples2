using System;

namespace EJERCICIO_Do_WHILE_6
{
    class Program
    {
        /*6. Leer por cada alumno de Diseño estructurado de algoritmos su número de control y su calificación en
cada una de las 5 unidades de la materia. Al final que escriba el número de control del alumno que
obtuvo mayor promedio. Suponga que los alumnos tienen diferentes promedios.*/
        static void Main(string[] args)
        {
            int n, control, control1=0;
            double A, B, C, D, E, promedio=0, promedio_mayor=0;
            Console.WriteLine("ingrese el numero de estudiantes");
            _ = int.TryParse(Console.ReadLine(), out n);
            do
            {
                Console.WriteLine("ingresa un numero de control ");
                _ = int.TryParse(Console.ReadLine(), out control);
                Console.WriteLine("ingresa la primer calificacion ");
                _ = double.TryParse(Console.ReadLine(), out A);
                Console.WriteLine("ingresa la segunda calificacion ");
                _ = double.TryParse(Console.ReadLine(), out B);
                Console.WriteLine("ingresa la tercera calificacion ");
                _ = double.TryParse(Console.ReadLine(), out C);
                Console.WriteLine("ingresa la cuarta calificacion ");
                _ = double.TryParse(Console.ReadLine(), out D);
                Console.WriteLine("ingresa la quinta calificacion ");
                _ = double.TryParse(Console.ReadLine(), out E);
                promedio = (A + B + C + D + E) / 5;
                Console.WriteLine("el promedio es: " + promedio);
                if (promedio > promedio_mayor)
                {
                    promedio_mayor = promedio;
                    control1 = control;
                }
                n = n - 1;
            } while (n != 0);
            Console.WriteLine("el promedio mayor es: " + promedio_mayor + " el numero de control del alumno es: " + control1);
            


        }
    }
}
