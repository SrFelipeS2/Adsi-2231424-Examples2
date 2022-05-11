using System;

namespace EJERCICIO_C_M3
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
            double Opercion, V, res; 
            Console.WriteLine("Buen dia que operacion va a realzar?");
            Opercion = double.Parse(Console.ReadLine());
            Console.WriteLine("Buen dia cual es el valor con que realizara la operacion?");
            V = double.Parse(Console.ReadLine());
            
            switch (Opercion)
            {
                case 1:
                    res= 100*V;
                    break;
                case 2:
                    res = Math.Pow(100,V); 
                    break;
                case 3:
                    res = 100/V;
                    break;
                
                default:
                    res = 0;
              
                    break;
            }
           
            Console.WriteLine("Buen dia el resultado es:" + res );

        }
    }
}
