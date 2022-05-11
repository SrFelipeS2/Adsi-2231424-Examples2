using System;

public class Program
{
	public static void Main()
	{
		/*3- Hacer un algoritmo que calcule el total a pagar por la compra de camisas. Si se compran tres camisas o mas se
aplica un descuento del 20% sobre el total de la compra y si son menos de tres camisas un descuento del 10%*/
		double camisa, pCamisa, tPagar, descuento1, descuento2;
		Console.WriteLine("Cuntas camisas desea comprar");
		camisa = double.Parse(Console.ReadLine());
		pCamisa = 30000;
		tPagar = camisa * pCamisa;
		if (camisa <= 3)
		{
			descuento1 = tPagar * 0.10;
			Console.WriteLine("El total a pagar es de: $" + (tPagar - descuento1));
		}
		else
		{
			descuento2 = tPagar * 0.20;
			Console.WriteLine("El totar a pagar es de: $" + (tPagar - descuento2));
		}
	}
}