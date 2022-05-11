using System;

namespace EJERCICIO_C_M1
{
    class Program

    /*1. La empresa comercializadora Solva vende escobas, recogedores y aromatizantes,
clasifica a sus clientes de acuerdo a la frecuencia de compras con las condiciones
siguientes:
Si el cliente es de la categoría 1 se le descuenta el 5%
Si el cliente es de la categoría 2 se le descuenta el 8%
Si el cliente de de la categoría 3 se le descuenta el 12%
Si el cliente es de la categoría 4 se le descuenta el 15%*/
    {
        static void Main(string[] args)
        {
            string NOM;
            double Cat, CE, CR, CA, PE=3000, PR=2000, PA=1000,TS, TC, Des;
            Console.WriteLine("Buen dia cual es su nombre?");
            NOM = Console.ReadLine();
            Console.WriteLine("Buen dia cual es su Categoria?");
            Cat = double.Parse(Console.ReadLine());
            Console.WriteLine("Buen dia cuantas Escobas va a comprar?");
            CE = double.Parse(Console.ReadLine());
            Console.WriteLine("Buen dia cuantos recogedores va a comprar?");
            CR = double.Parse(Console.ReadLine());
            Console.WriteLine("Buen dia cuantos Aromatizantes va a comprar?");
            CA = double.Parse(Console.ReadLine());
            TS = (PE * CE) + (PR * CR) + (PA * CA);
            switch (Cat)
            {
                case 1:
                    Des = TS * 0.05;
                    break;
                case 2:
                    Des = TS * 0.08;
                    break;
                case 3:
                    Des = TS * 0.12;
                    break;
                case 4:
                    Des = TS * 0.15;
                    break;
                default:
                    Des = 0;
                      Console.WriteLine("Buen dia no eligio bien la categoria");
                    break;
            }
            TC = TS - Des;
            Console.WriteLine("Buen dia: " + NOM + "\nel subtotal es: "
                + TS + "\nel descuento es de: " + Des + "\nEl total a pagar: " + TC );

        }
    }
}
