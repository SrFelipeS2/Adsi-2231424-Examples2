using System;

namespace POOEJERCICIO3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ESTUDIANTE estudiante;
            
            Console.WriteLine("BUEN DIA POR FAVOR DIGITE CUANTOS ESTUDIANTES VA A INGRESAR");
            _ = int.TryParse(Console.ReadLine(), out int numero_estudiantes);
            for (int i = 0; i < numero_estudiantes; i++)
            {
                estudiante = new ESTUDIANTE();
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
                Console.WriteLine("********************");
                if (estudiante.calculo_notas_promedio() > 3.5)
                {
                    Console.WriteLine("felicitaciones, el estudiante# " + (i+1) + " " + estudiante.nombre_estudiante + " aprobo la materia" );
                    Console.WriteLine("********************");
                }
                else
                {
                    Console.WriteLine("el estudiante# " + (i + 1) + " " + estudiante.nombre_estudiante + " reprobo la materia");
                    Console.WriteLine("********************");
                }
            }
        }
    }
}
