using System;

public class Program
{
	public static void Main()
	{
		/*4. Una empresa de bienes raíces ofrece casas de interés social, bajo las siguientes condiciones: Si los ingresos del
comprador son mayores o iguales a $800000 la cuota inicial será del 15% del costo de la casa y el resto se
distribuirá en pagos mensuales, a pagar en diez años. Si los ingresos del comprador son inferiores a de $800000
la cuota inicial será del 30% del costo de la casa y el resto se distribuirá en pagos mensuales a pagar en 7 años.
La empresa quiere saber cuanto debe pagar un comprador por concepto de cuota inicial y cuanto por cada
pago mensual ingresando el valor de la casa.*/
		double ingreso, valorV, cuota = 0, pagMen = 0;
		Console.WriteLine("Hola, digite su ingreso mensual");
		ingreso = double.Parse(Console.ReadLine());
		Console.WriteLine("cual es el valor total de la vivienda");
		valorV = double.Parse(Console.ReadLine());
		if (ingreso >= 800000)
		{
			cuota = valorV * 0.15;
			pagMen = (valorV - cuota) / 120;
		}
		else
		{
			cuota = valorV * 0.30;
			pagMen = (valorV - cuota) / 84;
		}
		Console.WriteLine("el valor de la cuota inicial es: " + cuota);
		Console.WriteLine("las cuotas mensuales son de: " + pagMen);
	}
}