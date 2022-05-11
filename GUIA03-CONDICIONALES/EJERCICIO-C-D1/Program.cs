using System;

public class Program
{
	public static void Main()
	{
		/*1. Desarrollar un algoritmo que lea dos números y los imprima en forma ascendente.*/
		double num1, num2;
		Console.WriteLine("Ingrese el numero 1");
		num1 = double.Parse(Console.ReadLine());
		Console.WriteLine("Ingrese el numero 2");
		num2 = double.Parse(Console.ReadLine());
		if (num1 > num2)
		{
			Console.WriteLine("--------------");
			Console.WriteLine(num2);
			Console.WriteLine(num1);
			Console.WriteLine("--------------");
		}
		else
		{
			Console.WriteLine("--------------");
			Console.WriteLine(num1);
			Console.WriteLine(num2);
			Console.WriteLine("--------------");
		}

	}
}