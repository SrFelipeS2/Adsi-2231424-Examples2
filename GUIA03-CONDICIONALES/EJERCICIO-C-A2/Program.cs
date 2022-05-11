using System;

public class Program
{
	public static void Main()
	/*2. Dado el monto de una compra calcular el descuento considerado
• Descuento es 20% si el monto es mayor a 20000 pesos.

GFPI-F-135 V01

• Descuento es 10% si el monto es mayor a 10000 pesos y menor o igual a 20000 pesos.
• no hay descuento si el monto es menor o igual a 10000 pesos. */
	{
		double montocompra, descuento;
		Console.WriteLine("digite el precio de su compra");
		montocompra = double.Parse(Console.ReadLine());
		if (montocompra > 20000)
		{
			descuento = montocompra * 0.20;
			Console.WriteLine("su descuento es de= " + descuento);
		}
		else if (montocompra > 10000 && montocompra <= 20000)
		{
			descuento = montocompra * 0.10;
			Console.WriteLine("su descuento es de= " + descuento);
		}
		else { Console.WriteLine("no hay descuento"); }
	}
}