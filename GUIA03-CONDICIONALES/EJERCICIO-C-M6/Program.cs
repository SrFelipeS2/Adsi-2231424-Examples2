using System;

class MainClass
{
    public static void Main(string[] args)
    {
    /* Desarrollar un algoritmo que lea el nombre del mes y el año e imprima en pantalla cuantos días tiene. 
     * Es necesario tener en cuenta si es año bisiesto o no.*/

     int mes, año, dias;


        Console.WriteLine("Digite un mes");
        Console.WriteLine("1:  Enero");
        Console.WriteLine("2:  Febrero");
        Console.WriteLine("3:  Marzo");
        Console.WriteLine("4:  Abril");
        Console.WriteLine("5:  Mayo");
        Console.WriteLine("6:  Junio");
        Console.WriteLine("7:  Julio");
        Console.WriteLine("8:  Agosto");
        Console.WriteLine("9:  Septiembre");
        Console.WriteLine("10: Ocutbre");
        Console.WriteLine("11: Noviembre");
        Console.WriteLine("12: Diciembre");

        _ = int.TryParse(Console.ReadLine(), out mes);

        Console.WriteLine("Digite un año");
        _ = int.TryParse(Console.ReadLine(), out año);

        dias = 0;

        switch (mes)
        {
            case 1:
                Console.WriteLine("usted eligió Enero");
                dias = 31;
                break;

            case 2:
                Console.WriteLine("usted eligió Febrero");
                if (año % 4 == 0 && año % 100 != 0 || año % 400 == 0)
                {
                    dias = 29;
                }
                else
                {
                    dias = 28;
                }
                break;

            case 3:
                Console.WriteLine("usted eligió Marzo");
                dias = 31;
                break;

            case 4:
                Console.WriteLine("usted eligió Abril");
                dias = 30;
                break;

            case 5:
                Console.WriteLine("usted eligió Mayo");
                dias = 31;
                break;

            case 6:
                Console.WriteLine("usted eligió Junio");
                dias = 30;
                break;

            case 7:
                Console.WriteLine("usted eligió Julio");
                dias = 31;
                break;

            case 8:
                Console.WriteLine("usted eligió Agosto");
                dias = 31;
                break;

            case 9:
                Console.WriteLine("usted eligió Septiembre");
                dias = 30;
                break;

            case 10:
                Console.WriteLine("usted eligió Octubre");
                dias = 31;
                break;

            case 11:
                Console.WriteLine("usted eligió Noviembre");
                dias = 30;
                break;

            case 12:
                Console.WriteLine("usted eligió Diciembre");
                dias = 31;
                break;

            default:
                Console.WriteLine("Eligio una opcion incorrecta");
                break;
        }
        Console.WriteLine("este mes tiene " + dias + " dias");
    }
}
