using System;

namespace EjemploWhile2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una compañía de seguros tiene contratados a n vendedores. Cada uno hace tres ventas a la semana.
            //Su política de pagos es que un vendedor recibe un sueldo base, y un 10% extra por comisiones de
            //sus ventas. El gerente de su compañía desea saber cuanto dinero obtendrá en la semana cada
            //vendedor por concepto de comisiones por las tres ventas realizadas, y cuanto tomando en cuenta
            //su sueldo base y sus comisiones.

            int cantidad, vendedor = 0;
            double sueldoBase, comisiones, venta1, venta2, venta3, sueldoTotal;
            Console.WriteLine("Ingrese la cantidad de vendedores");
            _ = int.TryParse(Console.ReadLine(), out cantidad);



            while (vendedor < cantidad)
            {
                Console.WriteLine("Ingrese el sueldo base del vendedor #" + (vendedor + 1));
                _ = double.TryParse(Console.ReadLine(), out sueldoBase);


                Console.WriteLine("Digite el valor de las ventas del vendedor #" + (vendedor + 1));
                _ = double.TryParse(Console.ReadLine(), out venta1);
                _ = double.TryParse(Console.ReadLine(), out venta2);
                _ = double.TryParse(Console.ReadLine(), out venta3);

                comisiones = (venta1 + venta2 + venta3) * 0.1;
                sueldoTotal = sueldoBase + comisiones;

                Console.WriteLine("El valor de las comisiones por las tres ventas del vendedor #" + (vendedor + 1) + " es: $" + comisiones + " y el sueldo total es: $" + sueldoTotal);
                vendedor++;
            }

        }
    }
}
