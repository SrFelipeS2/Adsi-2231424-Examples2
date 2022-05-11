using System;

public class Program
{
	public static void Main()
	{
		/*2. En una empresa se requiere calcular el salario semanal de cada uno de los n obreros que laboran en
		ella. El salario se obtiene de la sig. forma:
		Si el obrero trabaja 40 horas o menos se le paga $20 por hora
		Si trabaja más de 40 horas se le paga $20 por cada una de las primeras 40 horas y $25 por cada hora
		extra.*/
		int obreros, n=0;
		double pagoT, horas;

		Console.WriteLine("Ingrese la cantidad de obreros");
		_ = int.TryParse(Console.ReadLine(), out obreros);
        while (n < obreros)
        {
			Console.WriteLine("Ingrese la cantidad de horas del trabajador " + (n+1));
			_ = double.TryParse(Console.ReadLine(), out horas);
			if (horas <= 40)
            {
				pagoT = 20 * horas;
            }
            else
            {
				pagoT = (horas - 40 )* 25 + (20 * 40);
				
            }
			Console.WriteLine("el pago del trabajador  " + (n+1) + " es :" + pagoT );
			n++;
		}
		

	}
}
