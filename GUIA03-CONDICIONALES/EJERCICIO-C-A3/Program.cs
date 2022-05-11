using System;

public class Program
{
	public static void Main()
	/* 3. En una fábrica de computadoras se planea ofrecer a los clientes un descuento que dependerá del número de
computadoras que compre. Si las computadoras son menos de cinco se les dará un 10% de descuento sobre el
total de la compra; si el número de computadoras es mayor o igual a cinco pero menos de diez se le otorga un
20% de descuento; y si son 10 o más se les da un 40% de descuento. El precio de cada computadora es de
$1100000*/
	{
		double numero, tot, descuento, tp = 0;
		Console.WriteLine("cuantas computadores va a comprar?");
		numero = double.Parse(Console.ReadLine());
		tot = numero * 1100000;
		if (numero < 5)
		{
			descuento = tot * 0.10;
			tp = tot - descuento;
			Console.WriteLine("el descuento aplicado es de $" + descuento);
		}
		else if (numero >= 5 && numero < 10)
		{
			descuento = tot * 0.20;
			tp = tot - descuento;
			Console.WriteLine("el descuento aplicado es de $" + descuento);
		}
		else if (numero >= 10)
		{
			descuento = tot * 0.40;
			tp = tot - descuento;
			Console.WriteLine("el descuento aplicado es de $" + descuento);
		}
		Console.WriteLine("El total a pagar por las  computadoras compradas es: $" + tp);
	}
}