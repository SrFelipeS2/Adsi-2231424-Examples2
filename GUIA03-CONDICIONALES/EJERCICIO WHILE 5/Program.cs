using System;

namespace EJERCICIO_WHILE_5
{
    class Program
    {
        /*5. Obtener el promedio de calificaciones de un grupo de n alumnos.*/
        static void Main(string[] args)
        {
           int alumnos, n = 0;
            double notas, suma=0, promedioclase;
            Console.WriteLine("Ingrese la cantidad de alumnos");
            _ = int.TryParse(Console.ReadLine(), out alumnos);



            while (n < alumnos)
            {
                Console.WriteLine("Ingrese la nota del alumno #" + (n + 1));
                _ = double.TryParse(Console.ReadLine(), out notas);
                suma += notas;
                n++;
            }
            promedioclase = suma / alumnos;
            Console.WriteLine("el promedio de calificaciones de toda la clase es: " + promedioclase); 
        }
    }
}
