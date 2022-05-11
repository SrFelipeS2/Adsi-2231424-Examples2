using System;

public class Program
{
	public static void Main()
	{
		/*8-Dada la duración en minutos de una llamada calcular el costo, considerando
• Hasta tres minutos el costo es 600
• Por encima de tres minutos es 600 más 150 por cada minuto adicional a los tres primeros.*/
		double minutos, costo;
		Console.WriteLine("Digite cuantos minutos duro la llamada");
		minutos = double.Parse(Console.ReadLine());
		costo = 600;
		if (minutos > 3)
		{
			costo = costo + (minutos - 3) * 150;
		}
		Console.WriteLine("El costo de la llamada fue de: " + costo);
	}
}