using System;

namespace POOEJERCICIO4
{
    class Program
    {
        static void Main(string[] args)
        {
            ESTUDIANTES[] nombre; /* el vector se declara con la clase ESTUDIANTES, el tipo de vector tiene que ser igual a la clase constructora o a la clase del objeto */
            ESTUDIANTES estudiante;
            Console.WriteLine("BUEN DIA POR FAVOR DIGITE CUANTOS ESTUDIANTES VA A INGRESAR");
            _ = int.TryParse(Console.ReadLine(), out int numero_estudiantes);
            nombre = new ESTUDIANTES[numero_estudiantes]; /* se asigna el tamaño del vector*/
            for (int i = 0; i < numero_estudiantes; i++)
            {
                estudiante = new ESTUDIANTES();
                Console.WriteLine("BUEN DIA POR FAVOR DIGITE SU NOMBRE COMPLETO");
                estudiante.nombre_estudiante = Console.ReadLine();
                Console.WriteLine("********************");
                while (true)
                {
                    Console.WriteLine("BUEN DIA POR FAVOR DIGITE SU NOTA NUMERO 1, RECUERDE QUE LA CALIFICACION DEBE SER DE 0 A 5");
                    bool CORRECTA = double.TryParse(Console.ReadLine(), out double NOTA);
                    if (NOTA > 5 || NOTA < 0 || CORRECTA == false)
                    {
                        Console.WriteLine("ERROR NOTA INCORRECTA, VUELVA A DIGITAR SU NOTA");
                    }
                    else
                    {
                        estudiante.nota1_estudiante = NOTA;
                        break;
                    }
                }
                while (true)
                {
                    Console.WriteLine("BUEN DIA POR FAVOR DIGITE SU NOTA NUMERO 2, RECUERDE QUE LA CALIFICACION DEBE SER DE 0 A 5");
                    bool CORRECTA = double.TryParse(Console.ReadLine(), out double NOTA);
                    if (NOTA > 5 || NOTA < 0 || CORRECTA == false)
                    {
                        Console.WriteLine("ERROR NOTA INCORRECTA, VUELVA A DIGITAR SU NOTA");
                    }
                    else
                    {
                        estudiante.nota2_estudiante = NOTA;
                        break;
                    }
                }
                while (true)
                {
                    Console.WriteLine("BUEN DIA POR FAVOR DIGITE SU NOTA NUMERO 3, RECUERDE QUE LA CALIFICACION DEBE SER DE 0 A 5");
                    bool CORRECTA = double.TryParse(Console.ReadLine(), out double NOTA);
                    if (NOTA > 5 || NOTA < 0 || CORRECTA == false)
                    {
                        Console.WriteLine("ERROR NOTA INCORRECTA, VUELVA A DIGITAR SU NOTA");
                    }
                    else
                    {
                        estudiante.nota3_estudiante = NOTA;
                        break;
                    }
                }
                nombre[i] = estudiante;/*se agrega los datos al vector */
                Console.WriteLine("********************");
                
            }
            for (int i = 0; i < nombre.Length; i++)
            {
                if (nombre[i].calculo_notas_promedio() > 3.5)/*los datos se usan  con  el nombre del vector y despues se llama al metodo como tal para que el programa los identifique, si se hace de otra manera no los reconoce o identifica*/
                {
                    Console.WriteLine("felicitaciones, el estudiante# " + (i + 1) + " " + nombre[i].nombre_estudiante + " aprobo la materia");
                    Console.WriteLine("********************");
                }
                else
                {
                    Console.WriteLine("el estudiante# " + (i + 1) + " " + nombre[i].nombre_estudiante + " reprobo la materia");
                    Console.WriteLine("********************");
                }
            }
        }
    }
}
