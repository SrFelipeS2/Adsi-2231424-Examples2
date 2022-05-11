using System;

public class Program
{
	public static void Main()
	{
		/*2. Un obrero necesita calcular su salario semanal, el cual se obtiene de la sig. manera:
• Si trabaja 40 horas o menos se le paga $16 por hora
• Si trabaja más de 40 horas se le paga $16 por cada una de las primeras 40 horas y $20 por cada hora
extra.*/
		double horsem, pago, phext, hext, tpag;
		Console.WriteLine("cuantas horas trabajadas realizo en la semana?");
		horsem = double.Parse(Console.ReadLine());
		if (horsem <= 40)
		{
			pago = horsem * 16000;
			Console.WriteLine("el pago semanal es: " + pago);
		}
		else
		{
			hext = (horsem - 40);
			phext = (hext * 20000);
			pago = (horsem - hext) * 16000;
			tpag = pago + phext;
			Console.WriteLine("el pago semanal es: " + tpag);
		}

	}
}