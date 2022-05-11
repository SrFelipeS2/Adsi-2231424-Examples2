using System;

namespace EJERCICIOS_FOR_NUM7_1
{
    class Program
    /*7. Al cerrar un expendio de naranjas, 15 clientes recibirán un 15% de descuento si 
     * compran más de 10
kilos. Determinar cuánto pagará cada cliente y cuanto percibirá la tienda por esas compras.*/
    {
        static void Main(string[] args)
        {
            double precio, kilos, descuento=0, total, GananciaTotal=0 ;
            Console.WriteLine("buen dia digite cual es el precio por kilo de narnajas");
            _ = double.TryParse(Console.ReadLine(), out precio);

            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine("buen dia digite cuantos kilos compro el cliente # " + i);
                _ = double.TryParse(Console.ReadLine(), out kilos);
                if (kilos > 10)
                {
                    total = precio * kilos;
                    descuento = total * 0.15;
                }
                else
                {
                    total = precio * kilos;
                }
                Console.WriteLine("la persona" + i +" tiene que pagar un total de " + (total-descuento));
                Console.WriteLine("el descuento es de:" + descuento);
                GananciaTotal = GananciaTotal + (total - descuento); 
            }
            Console.WriteLine("las ganancias de la tienda son $ :" + GananciaTotal);
        }
    }
}
