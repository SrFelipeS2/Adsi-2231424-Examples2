using System;

public class Program
{
	public static void Main()
	/*5. Una frutería ofrece las manzanas con descuento según la siguiente tabla:
NUM. DE KILOS COMPRADOS % DESCUENTO
0 - 2 0
2.01 - 5 10
5.01 - 10 15
10.01 en adelante 20

Determinar cuanto pagara una persona que compre manzanas es esa frutería sabiendo que el kilo vale $1300
*/
	{
		double descuento, precio, kMan;
		Console.WriteLine("digite la cantidad de kilos que comprara");
		kMan = double.Parse(Console.ReadLine());
		precio = kMan * 1300;
		if (kMan < 0 && kMan <= 2)
		{
			descuento = 0;
		}
		else if (kMan > 2 && kMan < 5)
		{
			descuento = precio * 0.10;
			Console.WriteLine("el descuento aplicado es de $" + descuento);
			Console.WriteLine("el precio a pagar por las manzanas es de $" + precio * 0.90);
		}
		else if (kMan > 5 && kMan < 10)
		{
			descuento = precio * 0.15;
			Console.WriteLine("el descuento aplicado es de $" + descuento);
			Console.WriteLine("el precio a pagar por las manzanas es de $" + precio * 0.85);
		}
		else if (kMan > 10)
		{
			descuento = precio * 0.20;
			Console.WriteLine("el descuento aplicado es de $" + descuento);
			Console.WriteLine("el precio a pagar por las manzanas es de $" + precio * 0.80);
		}
		Console.WriteLine("el el precio por kilo es a $1300");

	}
}