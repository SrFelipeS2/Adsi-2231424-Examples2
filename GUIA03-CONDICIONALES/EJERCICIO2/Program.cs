using System;
	public class Program
{
	public static void Main()
	{
		/*La compañía de seguros de vida atlas se va a cambiar de domicilio y por lo tanto pone en venta su
terreno pero no tiene una idea del valor del terreno, entonces solicita al departamento de sistemas
que le desarrolle un algoritmo con la finalidad de que calcule e imprima el precio del terreno del cual
se tiene los siguientes datos: largo, ancho y precio por metro cuadrado, si el terreno tiene más de
400 metros cuadrados se hace un descuento del 10%.*/
		double precioT, largo, ancho, pM2, descuento;
		Console.WriteLine("Digite el largo del terreno");
		largo = double.Parse(Console.ReadLine());
		Console.WriteLine("Digite el ancho del terreno");
		ancho = double.Parse(Console.ReadLine());
		Console.WriteLine("Digite el precio por metro cuadrado");
		pM2 = double.Parse(Console.ReadLine());
		double area;
		area = largo * ancho;
		precioT = area * pM2;
		if (area > 400)
		{
			descuento = precioT * 0.10;
			precioT = precioT - descuento;
		}
		Console.WriteLine("El precio del terreno es: " + precioT);
	}
} 
