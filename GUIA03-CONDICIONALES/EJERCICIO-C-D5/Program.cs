using System;

public class Program
{
	public static void Main()
	{
		/*Un cliente ordena cierta cantidad de brochas de cerda y rodillos; las brochas de cerda tienen un 20% de
descuento y los rodillos un 15% de descuento. Los datos que se tienen por cada tipo de artículo son: la cantidad
pedida y el precio unitario. Además, si se paga de contado todo tiene un descuento del 7%. Elaborar un
programa en LPP y DFD que calcule y muestre en pantalla el costo total de la orden, tanto para el pago de
contado como para el caso de pago de crédito. Para el caso de pago de contado el usuario ingresa 1, para pago
a crédito el usuario ingresa 2.*/
		double brochas, rodillos, Vbrocha, Vrodillo, VTB, VTR, VTBP = 0, VTRP = 0, VT, desc;
		int pago;
		Console.WriteLine("cuantas brochas compro?");
		brochas = double.Parse(Console.ReadLine());
		Console.WriteLine("cuantas rodillos compro?");
		rodillos = double.Parse(Console.ReadLine());
		Console.WriteLine("cual es el valor de las brochas?");
		Vbrocha = double.Parse(Console.ReadLine());
		Console.WriteLine("cual es el valor de las rodillo?");
		Vrodillo = double.Parse(Console.ReadLine());
		VTB = Vbrocha * brochas;
		VTBP = VTB - (VTB * 0.20);
		VTR = Vrodillo * rodillos;
		VTRP = VTR - (VTR * 0.15);
		VT = VTRP + VTBP;
		Console.WriteLine("como desea pagar? ingrese 1 para credito, ingrese 2 para pagar de contado");
		pago = int.Parse(Console.ReadLine());
		if (pago == 1)
		{
			Console.WriteLine("usted va a pagar a credito el valor total de las brochas y los rodillos ocn descuento es de:" + VT);
		}
		else
		{
			desc = VT - (VT * 0.07);
			Console.WriteLine("usted va a pagar de contado :" + desc);
		}
	}
}