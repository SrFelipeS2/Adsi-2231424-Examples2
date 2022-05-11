using System;

namespace EJERCICIO_WHILE_6
{
    class Program
    {
        /*6. Calcular el promedio de edades de hombres, mujeres y de todo un grupo de n alumnos.*/
        static void Main(string[] args)
        {
            int alumnos, n = 0, hombres=0, mujeres=0, edad;
            double suma = 0, promedioclase, promediohombres, promediomujeres, edadpormhombre=0,edadprommujer=0;
            string genero="hombre", cadena, minuscula;
            Console.WriteLine("Ingrese la cantidad de alumnos");
            _ = int.TryParse(Console.ReadLine(), out alumnos);
            while (n < alumnos)
            {
                Console.WriteLine("Ingrese el genero del alumno" + (n + 1));
                cadena = Console.ReadLine();
                minuscula = cadena.ToLower();
                bool respuesta = genero.Equals(minuscula);
                Console.WriteLine("Ingrese la edad de el alumno" + (n + 1));
                _ = int.TryParse(Console.ReadLine(), out edad);
                if (respuesta)
                {
                    edadpormhombre += edad;
                    hombres++;
                }
                else
                {
                    edadprommujer += edad;
                    mujeres++;
                }
                suma += edad;
                n++;
            }
            
            promedioclase = suma / alumnos;
            promediohombres = edadpormhombre / hombres;
            promediomujeres = edadprommujer / mujeres;
            Console.WriteLine("el promedio de edades  de toda la clase es: " + promedioclase + " el promedio de edades para los hombres de la clase es:  " + promediohombres + " el promedio de edades para las mujeres que hay en la clase es: " + promediomujeres);
        }
    }
    }

