using System;

public class Program
{
	public static void Main()
	{
		/*En un supermercado se hace una promoción, mediante la cual el cliente obtiene un descuento
dependiendo de un número que se escoge al azar. Si el numero escogido es menor que 74 el
descuento es del 15% sobre el total de la compra, si es mayor o igual a 74 el descuento es del 20%.
Obtener cuánto dinero se le descuenta.*/
		double sorteo, precio, totalp,totalp1;
		Console.WriteLine("cual es el costo total de los productos?");
		totalp = double.Parse(Console.ReadLine());
		Console.WriteLine("cual es el numero que saco en el sorteo?");
		sorteo = double.Parse(Console.ReadLine());
		if (sorteo <= 74)
		{
			precio = totalp * 0.15;
			totalp1 = totalp - precio;
			Console.WriteLine("obtiene un descuento del 15% del total de su compra, " +
				"antes del descuento el costo es de: " + totalp + 
				"con el descuento es de: " + totalp1);
		}
		if (sorteo > 74)
		{
			precio = totalp * 0.20;
			totalp1 = totalp - precio;
			Console.WriteLine("obtiene un descuento del 20% del total de su compra, " +
				"antes del descuento el costo es de: " + totalp + 
			"con el descuento es de: " + totalp1);
		}
	}
}