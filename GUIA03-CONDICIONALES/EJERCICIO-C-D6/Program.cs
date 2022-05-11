using System;

public class Program
{
	public static void Main()
	{
		/*El gobierno desea saber el numero de pinos, robles y cedros que tendrá que sembrar en el bosque, si se sabe
que en 10 metros cuadrados caben 8 pinos, en 15 metros cuadrados caben 15 robles y en 18 metros cuadrados
caben 10 cedros. También se sabe que una hectárea equivale a 10 mil metros cuadrados.*/
		double pino, roble, cedro, metros;
		Console.WriteLine("Digite total de metros cuadrados del terreno");
		metros = double.Parse(Console.ReadLine());
		if (metros > 1000000)
		{
			pino = metros * 0.70;
			roble = metros * 0.20;
			cedro = metros * 0.10;
		}
		else
		{
			pino = metros * 0.50;
			roble = metros * 0.30;
			cedro = metros * 0.20;
		}
		Console.WriteLine("El numero de arboles pinos que se pueden sembrar en " + pino + " metros  es: " + ((pino / 10) * 8));
		Console.WriteLine("El numero de arboles roble que se pueden sembrar en " + roble + " metros es: " + (roble));
		Console.WriteLine("El numero de arboles cedros que se pueden sembrar en " + cedro + " metros es: " + ((cedro / 18) * 10));
	}
}