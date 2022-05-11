using System;

public class Program
{
	public static void Main()
	{
		/*Calcular el total que una persona debe pagar en un almacén, si el precio de cada llanta es de $80000
si se compran menos de 5 llantas y de $70000 si se compran 5 o más.*/
		double Cantidad, precio, totalp = 0;
		Console.WriteLine("ingrese cuantas llanatas compro");
		Cantidad = double.Parse(Console.ReadLine());
		if (Cantidad > 5)
		{
			precio = 70000;
			totalp = precio * Cantidad;
		}
		if (Cantidad <= 5)
		{
			precio = 80000;
			totalp = precio * Cantidad;
		}

		Console.WriteLine("El total a pagas es :" + totalp);
	}
}