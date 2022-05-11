using System;

namespace POOEJERCICIO1
{
    class Program
    {
        static void Main(string[] args)
        {
            EMPLEADO EMPLEADO1 = new EMPLEADO();
            Console.WriteLine("POR FAVOR INGRESE SU NOMBRE COMPLETO ");
            EMPLEADO1.Metodo_nombre_empleado = Console.ReadLine();
            Console.WriteLine("********************");
            Console.WriteLine("POR FAVOR DIGITE SU NUMERO DE IDENTIFICACION");
            _ = int.TryParse(Console.ReadLine(), out int IDENTIFICACION);
            EMPLEADO1.setIdentificacion(IDENTIFICACION);
            Console.WriteLine("********************");
            Console.WriteLine("POR FAVOR INGRESE SU EMAIL COMPLETO ");
            EMPLEADO1.Metodo_email_empleado = Console.ReadLine();
            Console.WriteLine("********************");
            Console.WriteLine("POR FAVOR INGRESE SU TELEFONO COMPLETO ");
            _ = int.TryParse(Console.ReadLine(), out int TELEFONO);
            EMPLEADO1.telefono_empleado = TELEFONO;
            Console.WriteLine("********************");
            Console.WriteLine("POR FAVOR INGRESE SU SALARIO ");
            _ = int.TryParse(Console.ReadLine(), out int SALARIO);
            EMPLEADO1.salario_empleado = SALARIO;
            Console.WriteLine("********************");
            Console.WriteLine("POR FAVOR INGRESE SUS GASTOS ");
            _ = int.TryParse(Console.ReadLine(), out int GASTOS);
            EMPLEADO1.setgastos_empleado(GASTOS);
            Console.WriteLine("********************");
            Console.WriteLine("EL NOMBRE Y LA IDENTIFICACION PARA EL USUARIO 2 YA ESTAN SETEADAS");
            Console.WriteLine("********************");


            EMPLEADO EMPLEADO2 = new EMPLEADO("DAVID" , 1059864853);
            Console.WriteLine("POR FAVOR INGRESE SU EMAIL COMPLETO ");
            EMPLEADO2.Metodo_email_empleado = Console.ReadLine();
            Console.WriteLine("********************");
            Console.WriteLine("POR FAVOR INGRESE SU TELEFONO COMPLETO ");
            _ = int.TryParse(Console.ReadLine(), out TELEFONO);
            EMPLEADO2.telefono_empleado = TELEFONO;
            Console.WriteLine("********************");
            Console.WriteLine("POR FAVOR INGRESE SU SALARIO ");
            _ = int.TryParse(Console.ReadLine(), out SALARIO);
            EMPLEADO2.salario_empleado = SALARIO;
            Console.WriteLine("********************");
            Console.WriteLine("POR FAVOR INGRESE SUS GASTOS ");
            _ = int.TryParse(Console.ReadLine(), out GASTOS);
            EMPLEADO2.setgastos_empleado(GASTOS);
            Console.WriteLine("********************");
            Console.WriteLine("EL NOMBRE, LA IDENTIFICACION, EL TELEFONO Y EL EMAIL PARA EL USUARIO 3 YA ESTAN SETEADAS");
            Console.WriteLine("********************");
            

            EMPLEADO EMPLEADO3 = new EMPLEADO("SERGIO", 1053897456, "SERGIO@MISENA.EDI.CO", 3107889856);
            Console.WriteLine("POR FAVOR INGRESE SU SALARIO ");
            _ = int.TryParse(Console.ReadLine(), out  SALARIO);
            EMPLEADO3.salario_empleado = SALARIO;
            Console.WriteLine("********************");
            Console.WriteLine("POR FAVOR INGRESE SUS GASTOS ");
            _ = int.TryParse(Console.ReadLine(), out GASTOS);
            EMPLEADO3.setgastos_empleado(GASTOS);

            Console.WriteLine("********************************************************");
            Console.WriteLine(" EL USUARIO SE LLAMA "+  EMPLEADO1.Metodo_nombre_empleado+" SE IDENTIFICA CON EL NUMERO: " +EMPLEADO1.getIdentificacion() + " SU CONTACTO VIA CORREO ELECTRONICO ES: " + EMPLEADO1.Metodo_email_empleado + " SU TELEFONO ES: " + EMPLEADO1.telefono_empleado + " SU SALARIO ES: " + EMPLEADO1.salario_empleado + " SUS GASOS MENSUALES SON: " + EMPLEADO1.getgastos_empleado()+" EL SUELDO QUELE QUEDA PARA SUS HOBIES ES: " + EMPLEADO1.calculo_salario_restante());
            Console.WriteLine("********************************************************");
            Console.WriteLine(" EL USUARIO SE LLAMA " + EMPLEADO2.Metodo_nombre_empleado + " SE IDENTIFICA CON EL NUMERO: " + EMPLEADO2.getIdentificacion() + " SU CONTACTO VIA CORREO ELECTRONICO ES: " + EMPLEADO2.Metodo_email_empleado + " SU TELEFONO ES: " + EMPLEADO2.telefono_empleado + " SU SALARIO ES: " + EMPLEADO2.salario_empleado + " SUS GASOS MENSUALES SON: " + EMPLEADO2.getgastos_empleado() + " EL SUELDO QUELE QUEDA PARA SUS HOBIES ES: " + EMPLEADO2.calculo_salario_restante());
            Console.WriteLine("********************************************************");
            Console.WriteLine(" EL USUARIO SE LLAMA " + EMPLEADO3.Metodo_nombre_empleado + " SE IDENTIFICA CON EL NUMERO: " + EMPLEADO3.getIdentificacion() + " SU CONTACTO VIA CORREO ELECTRONICO ES: " + EMPLEADO3.Metodo_email_empleado + " SU TELEFONO ES: " + EMPLEADO3.telefono_empleado + " SU SALARIO ES: " + EMPLEADO3.salario_empleado + " SUS GASOS MENSUALES SON: " + EMPLEADO3.getgastos_empleado() + " EL SUELDO QUELE QUEDA PARA SUS HOBIES ES: " + EMPLEADO3.calculo_salario_restante());


        }
    }
}
