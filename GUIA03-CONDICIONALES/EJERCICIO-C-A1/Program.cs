using System;

public class Program
{
	public static void Main()
	{
		int num1, num2, num3;
		Console.WriteLine("ingrese el primer numero");
		num1 = int.Parse((Console.ReadLine()));
		Console.WriteLine("ingrese el segundo numero");
		num2 = int.Parse((Console.ReadLine()));
		Console.WriteLine("ingrese el tercer numero");
		num3 = int.Parse((Console.ReadLine()));

		if (num1 > num2 && num1 > num3)
			Console.WriteLine(" nuemero mayor es " + num1);
		else if (num2 > num1 && num2 > num3)
			Console.WriteLine(" nuemero mayor es " + num2);
		else
		{
			if (num3 > num1 && num3 > num2)
				Console.WriteLine("nuemero mayor es " + num3);
		}
	}
}