using System;

namespace POOEJERCICIO2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realizar la clase trabajador identificando los atributos principales. Se debe tener un método
de clase que permita decir cuánto se ganó el trabajador teniendo en cuenta el precio por
hora y la cantidad de horas trabajadas en un mes. Declarar 3 instancias de la clase trabajador
y decir por cada uno, cuánto se ganó en ese mes trabajado*/
            TRABAJADORES trabajador1 = new TRABAJADORES();
            TRABAJADORES trabajador2 = new TRABAJADORES();
            TRABAJADORES trabajador3 = new TRABAJADORES();
            Console.WriteLine("POR FAVOR INGRESE SU NOMBRE COMPLETO ");
            trabajador1.nombre_trabajador = Console.ReadLine();
            Console.WriteLine("********************");
            Console.WriteLine("POR FAVOR DIGITE SU NUMERO DE IDENTIFICACION");
            _ = int.TryParse(Console.ReadLine(), out int IDENTIFICACION);
            trabajador1.numero_identificacion = (IDENTIFICACION);
            Console.WriteLine("********************");
            Console.WriteLine("POR FAVOR DIGITE SU NUMERO DE HORAS TRABAJADAS");
            _ = int.TryParse(Console.ReadLine(), out int HORAS_TRABAJADAS);
            trabajador1.horas_trabajdas = (HORAS_TRABAJADAS);
            Console.WriteLine("********************");
            Console.WriteLine("POR FAVOR DIGITE EL PRECIO DE LAS HORAS TRABAJADAS");
            _ = int.TryParse(Console.ReadLine(), out int PRECIO_HORAS);
            trabajador1.precio_horas = (PRECIO_HORAS);
            Console.WriteLine("********************");
            Console.WriteLine("POR FAVOR INGRESE SU NOMBRE COMPLETO ");
            trabajador2.nombre_trabajador = Console.ReadLine();
            Console.WriteLine("********************");
            Console.WriteLine("POR FAVOR DIGITE SU NUMERO DE IDENTIFICACION");
            _ = int.TryParse(Console.ReadLine(), out  IDENTIFICACION);
            trabajador2.numero_identificacion = (IDENTIFICACION);
            Console.WriteLine("********************");
            Console.WriteLine("POR FAVOR DIGITE SU NUMERO DE HORAS TRABAJADAS");
            _ = int.TryParse(Console.ReadLine(), out HORAS_TRABAJADAS);
            trabajador2.horas_trabajdas = (HORAS_TRABAJADAS);
            Console.WriteLine("********************");
            Console.WriteLine("POR FAVOR DIGITE EL PRECIO DE LAS HORAS TRABAJADAS");
            _ = int.TryParse(Console.ReadLine(), out  PRECIO_HORAS);
            trabajador2.precio_horas = (PRECIO_HORAS);
            Console.WriteLine("********************");
            Console.WriteLine("POR FAVOR INGRESE SU NOMBRE COMPLETO ");
            trabajador3.nombre_trabajador = Console.ReadLine();
            Console.WriteLine("********************");
            Console.WriteLine("POR FAVOR DIGITE SU NUMERO DE IDENTIFICACION");
            _ = int.TryParse(Console.ReadLine(), out  IDENTIFICACION);
            trabajador3.numero_identificacion = (IDENTIFICACION);
            Console.WriteLine("********************");
            Console.WriteLine("POR FAVOR DIGITE SU NUMERO DE HORAS TRABAJADAS");
            _ = int.TryParse(Console.ReadLine(), out HORAS_TRABAJADAS);
            trabajador3.horas_trabajdas = (HORAS_TRABAJADAS);
            Console.WriteLine("********************");
            Console.WriteLine("POR FAVOR DIGITE EL PRECIO DE LAS HORAS TRABAJADAS");
            _ = int.TryParse(Console.ReadLine(), out PRECIO_HORAS);
            trabajador3.precio_horas = (PRECIO_HORAS);
            Console.WriteLine("****************************************************");
            Console.WriteLine("********************************************************");
            Console.WriteLine(" EL USUARIO SE LLAMA " + trabajador1.nombre_trabajador + " SE IDENTIFICA CON EL NUMERO: " + trabajador1.numero_identificacion + " LAS HORAS TRABAJADAS AL MES SON DE  " + trabajador1.horas_trabajdas + " EL PRECIO POR HORA ES DE : " + trabajador1.precio_horas + " SU SALARIO ES: " + trabajador1.Calculo_salario() );
            Console.WriteLine("********************************************************");
            Console.WriteLine(" EL USUARIO SE LLAMA " + trabajador2.nombre_trabajador + " SE IDENTIFICA CON EL NUMERO: " + trabajador2.numero_identificacion + " LAS HORAS TRABAJADAS AL MES SON DE  " + trabajador2.horas_trabajdas + " EL PRECIO POR HORA ES DE : " + trabajador2.precio_horas + " SU SALARIO ES: " + trabajador2.Calculo_salario());
            Console.WriteLine("********************************************************");
            Console.WriteLine(" EL USUARIO SE LLAMA " + trabajador3.nombre_trabajador + " SE IDENTIFICA CON EL NUMERO: " + trabajador3.numero_identificacion + " LAS HORAS TRABAJADAS AL MES SON DE  " + trabajador3.horas_trabajdas + " EL PRECIO POR HORA ES DE : " + trabajador3.precio_horas + " SU SALARIO ES: " + trabajador3.Calculo_salario());
        }
    }
}
