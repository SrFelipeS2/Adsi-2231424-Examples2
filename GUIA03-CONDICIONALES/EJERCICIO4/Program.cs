using System;

public class Program
{
	public static void Main()
	{
		string Art;
		double precioa, clave, tpagar = 0, Descuento1, Descuento2;
		Console.WriteLine("ingrese el nombre del articulo");
		Art = Console.ReadLine();
		Console.WriteLine("ingrese el precio del articulo");
		precioa = double.Parse(Console.ReadLine());
		Console.WriteLine("ingrese la clave");
		clave = double.Parse(Console.ReadLine());

		if (clave == 1)
		{
			Descuento1 = precioa * 0.10;
			tpagar = precioa - Descuento1;
		}
		if (clave == 2)
		{
			Descuento2 = precioa * 0.20;
			tpagar = precioa - Descuento2;
		}
		Console.WriteLine("El nombre del atriculo es :" + Art);
		Console.WriteLine("la clave es :" + clave);
		Console.WriteLine("El  precio  original del atriculo es :" + precioa);
		Console.WriteLine("El  precio  con descuento del atriculo es :" + tpagar);
	}
}
/*Hacer un algoritmo que imprima el nombre de un artículo, clave, precio original y su precio con
descuento. El descuento lo hace en base a la clave, si la clave es 1 el descuento es del 10% y si la
clave es 2 el descuento en del 20% (solo existen dos claves).*/