using System;

namespace EJERCICIO_Do_WHILE_1
{
    class Program
    {
        /*1. En un supermercado una ama de casa pone en su carrito los artículos que va tomando de los
    estantes. La señora quiere asegurarse de que el cajero le cobre bien lo que ella ha comprado, por lo
    que cada vez que toma un articulo anota su precio junto con la cantidad de artículos iguales que ha
    tomado y determina cuanto dinero gastara en ese articulo; a esto le suma lo que ira gastando en los
    demás artículos, hasta que decide que ya tomo todo lo que necesitaba. Ayúdale a esta señora a
    obtener el total de sus compras.*/
        static void Main(string[] args)
        {
            double valorArticulo, cantidadArticulos, costoTotal=0;
            int compra=1;
            do
            {
                Console.WriteLine("ingrese el valor del articulo");
                _ = double.TryParse(Console.ReadLine(), out valorArticulo);
                Console.WriteLine("ingrese la cantidad del mismo articulo ");
                _ = double.TryParse(Console.ReadLine(), out cantidadArticulos);
                costoTotal += valorArticulo * cantidadArticulos;
                Console.WriteLine("desea comprar otro articulo?, 1 para continuar, 0 para finalizar compra");
                _ = int.TryParse(Console.ReadLine(), out compra);
            } while (compra != 0);
            Console.WriteLine("el total de las compras es: " + costoTotal);
        }
    }
}
