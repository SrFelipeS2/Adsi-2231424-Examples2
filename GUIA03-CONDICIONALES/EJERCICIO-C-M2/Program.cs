using System;

namespace EJERCICIO_C_M2
{
    class Program

    /* 2. Una compañía de fumigación utiliza aviones para fumigar las cosechas contra una gran variedad de plagas. Las
cantidades que la compañía cobra a los granjeros depende de qué es lo que se desea fumigar y del número de
hectáreas que se desea fumigar, de acuerdo con la siguiente distribución :
Tipo 1 : Fumigación contra malas hierbas, $50000 por hectárea
Tipo 2 : Fumigación contra moscas y mosquitos, $70000 por hectárea
Tipo 3 : Fumigación contra gusanos, $80000 por hectárea.
Tipo 4 : Fumigación contra todo lo anterior, $190000 por hectárea.

• Si el área a fumigar es mayor de 100 hectáreas, el granjero goza de un 5% de descuento.
• Además, si la cuenta total sobrepasa el $1000000 se hace acreedor a un 10% de descuento sobre la cantidad
que sobrepase el $1000000.
• Si ambos descuentos son aplicables, el correspondiente a la superficie se considera primero.
Diseñe el programa que lea el nombre del granjero, el tipo de fumigación solicitada (1-4) y el número de hectáreas a
fumigar.
Se debe imprimir el nombre del granjero y la cuenta total.*/
    {
        static void Main(string[] args)
        {
            string NOM;
            double Tipo, HectF,Precio=0, Des2,Totalpag=0;
            Console.WriteLine("Buen dia cual es su nombre?");
            NOM = Console.ReadLine();
            Console.WriteLine(" cual es  el tipo de fumigacion que va a realizar?");
            Tipo = double.Parse(Console.ReadLine());
            Console.WriteLine("cuantas hectarias va a fumigar?");
            HectF = double.Parse(Console.ReadLine());
            switch (Tipo)
            {
                case 1:
                    Precio = HectF * 50000;
                    break;
                case 2:
                    Precio = HectF * 70000;
                    break;
                case 3:
                    Precio = HectF * 80000;
                    break;
                case 4:
                    Precio = HectF * 190000;
                    break;
                default:
                    Tipo = 0;
                    Console.WriteLine("Buen dia no eligio bien la categoria");
                    break;
            }
            if (HectF > 100 )
            {
               Totalpag = Precio * 0.95;
            }
           
            else if (Precio > 1000000 && HectF < 100)
            {
                Des2 = (Precio - 1000000) * 0.10;
                Totalpag = Precio - Des2;
            }
            else if (Precio > 1000000 && HectF > 100)
            {
                Totalpag = Precio * 0.95;
            }
            else
            {
                Totalpag = Precio;
            }

            Console.WriteLine("Buen dia: " + NOM +  "\nEl total a pagar: " + Totalpag);

        }
    }
}